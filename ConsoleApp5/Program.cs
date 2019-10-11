using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public struct Processus
    {
        public string Nom;
        public double Memoire;
        public TimeSpan Processeur;
    }

    //public class DoubleComparer : IComparer // cette classe hérite de IComparer.
    //                                     // c'est cette classe qui est appelée par 
    //                                     // les méthodes de tri pour savoir comment 
    //                                     // comparer les éléments
    //{
    //    public int Compare(object x, object y) // la méthode de comparaison : 
    //                                           // elle est forcément déclarée comme cela
    //    {
    //        if ((double)x < (double)y) // bien penser à caster les objet dans la structure qui va être comparée
    //            return -1;
    //        if ((double)x > (double)y)
    //            return 1;
    //        return 0; // eh oui, si les éléments sont égaux on ne va pas s'amuser à les trier, 
    //                  // donc on retournera 0 :-D
    //    }
    //}
    class Program
    {
        
        static void Main(string[] args)
        {
            var colProc = (from oProc in Process.GetProcesses()
                           where oProc.WorkingSet64 > 20*1024*1024
                           orderby oProc.ProcessName descending
                           select  (oProc.Id, oProc.ProcessName));

            foreach (var p in colProc)
            {
                Console.WriteLine(p.Id + " " + p.ProcessName);
            }

            Console.WriteLine("");
            Console.WriteLine("Trié par mémoire");

            var colProc2 = (from oProc in Process.GetProcesses()
                       where oProc.WorkingSet64 > 20 * 1024 * 1024
                       orderby oProc.WorkingSet64 descending
                       select (oProc.Id, oProc.ProcessName, oProc.WorkingSet64));

            foreach (var p in colProc2)
            {
                Console.WriteLine(p.Id + " " + p.ProcessName + " " + p.WorkingSet64);
            }

            Console.WriteLine("");
            Console.WriteLine("Trié par temps processeur");

            var colProc3 = (from oProc in Process.GetProcesses()
                            where oProc.Id != 0
                            orderby oProc.TotalProcessorTime descending
                            select (oProc.Id, oProc.ProcessName, oProc.TotalProcessorTime));

            foreach (var p in colProc3)
            {
                Console.WriteLine(p.Id + " " + p.ProcessName + " " + p.TotalProcessorTime);
            }


            List < Processus > LesProcess = new List<Processus>();
            Processus UnProcess = new Processus();

            foreach (var p in Process.GetProcesses())
            {
                if (p.Id != 0)
                {
                    UnProcess.Nom = p.ProcessName;
                    UnProcess.Memoire = p.WorkingSet64;
                    UnProcess.Processeur = p.TotalProcessorTime;

                    LesProcess.Add(UnProcess);
                }
            }

            //System.Collections.IComparer myComparer = new DoubleComparer();

            //LesProcess.Sort(myComparer);

            Console.ReadLine();
        }



    }
}
