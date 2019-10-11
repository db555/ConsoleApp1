using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nb1;
            int Nb2;
            int Res;

            while (true)
            {
                Console.WriteLine("Saisir le 1er nombre");
                Nb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Saisir le 2eme nombre");
                Nb2 = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Res = Nb1 / Nb2;
                    Console.WriteLine(Res);
                    Console.ReadLine();
                    break;
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Resaisir les nombres");
                }
            }
        }
    }
}

