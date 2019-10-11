using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppDir
{
    class Program
    {
        public static long TailleRep(string Rep,ref List<string> lFichiers)
        {
            long taille=0;
            DirectoryInfo dir = new DirectoryInfo(Rep);

            FileInfo[] fichiers = dir.GetFiles();

            foreach (var f in fichiers)
            {
                taille += f.Length;
                //lFichiers.Add(f.Name);
                lFichiers.Add(f.FullName);
            }

            DirectoryInfo[] Repert = dir.GetDirectories();

            foreach (var f in Repert)
            {
                taille += TailleRep(Rep + "\\" + f.Name,ref lFichiers);
            }

            return (taille);
        }
        static void Main(string[] args)
        {
            string MonFic = @"C:\Users\Administrateur\Desktop\toto.txt";
            List<string> lFichiers = new List<string>();
            string Complet;

            Console.WriteLine(TailleRep(@"C:\Users\Administrateur\Desktop\cours",ref lFichiers));

            var tFic = lFichiers.ToArray();

            System.IO.File.WriteAllLines(MonFic, tFic);

            lFichiers.Clear();
            using (System.IO.StreamReader file = new System.IO.StreamReader(MonFic))
            {
                while (!file.EndOfStream)
                {
                    lFichiers.Add(file.ReadLine());
                }
                file.Close();
            }

            Console.WriteLine("Nombre de lignes " + lFichiers.Count);

            using (System.IO.StreamReader file = new System.IO.StreamReader(MonFic))
            {
                Complet = file.ReadToEnd();
            }
            
            string[] Lignes;
            //Lignes = Complet.Split('\n');
            
            Lignes = Regex.Split(Complet, "\r\n");
            Console.WriteLine("Lignes split : " + Lignes.Length);

            Console.ReadLine();
        }
    }
}
