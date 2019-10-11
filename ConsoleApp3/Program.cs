using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nombres = new int[10];
       
            List<int> lNb = new List<int>();
            //List<int> lPair = new List<int>();

            int ii;
            var rand = new Random();

            for (ii=0; ii<10; ii++)
            {
                lNb.Add(rand.Next(100));
            }

            //foreach (var item in collection)
            //{

            //}

            foreach (var n in lNb) Console.WriteLine(n);

            Console.WriteLine();

            //Array.Sort(nombres);
            lNb.Sort();

            foreach (var n in lNb) Console.WriteLine(n);

            var lPair = lNb.Where(i => i % 2 == 0);

            Console.WriteLine();

            foreach (var n in lPair) Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
