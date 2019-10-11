using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloword
{
    public abstract class tool
    {
        public static double CalcAge(DateTime DateNaiss)
        {
            return ((DateTime.Now - DateNaiss).Days / 365.242189);
        }

        public static string jourDeLaSemaine(DateTime dt)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Dimanche";
                case DayOfWeek.Monday:
                    return "Lundi";
                case DayOfWeek.Tuesday:
                    return "Mardi";
                case DayOfWeek.Wednesday:
                    return "Mercredi";
                case DayOfWeek.Thursday:
                    return "Jeudi";
                case DayOfWeek.Friday:
                    return "Vendredi";
                case DayOfWeek.Saturday:
                    return "Samedi";
                default:
                    return "";
            }
        }
    }
    public class identite
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaiss { get; set; }

        public identite(string prenom, string nom, DateTime datenaiss)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaiss = datenaiss;
        }

        public override string ToString()
        {
            return (Prenom + " " + Nom);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            //string Nb1;
            //string Nb2;

            //identite Personne = new identite();
            DateTime DernierAnniv;

            int ii;
            string Prenom;
            string Nom;
            DateTime DateNaiss;
            string NoTelephone;

            Console.WriteLine("Quel est votre prénom ?");
            Prenom = Console.ReadLine();
            Console.WriteLine("Quel est votre nom ?");
            Nom = Console.ReadLine();

            Console.WriteLine("quel est votre date de naissance ?");
            DateNaiss = Convert.ToDateTime(Console.ReadLine());

          
            identite Personne = new identite(Prenom, Nom, DateNaiss);
          
            Console.WriteLine("Bonjour " + Prenom + " " + Nom);
            Console.WriteLine(Personne.ToString());

            //Console.WriteLine("Votre age est " + age(Personne.DateNaiss).ToString());
            //Console.WriteLine("Votre age est " + tool.CalcAge(Personne.DateNaiss).ToString());
            Console.WriteLine(String.Format("Votre Age est {0:0.00}", tool.CalcAge(Personne.DateNaiss)));

            //DernierAnniv = Personne.DateNaiss.AddYears(Convert.ToInt32( (int)( age(Personne.DateNaiss))));
            //DernierAnniv = Personne.DateNaiss.AddYears((int)(age(Personne.DateNaiss)));
            DernierAnniv = DateNaiss.AddYears((int)(tool.CalcAge(Personne.DateNaiss)));

            Console.WriteLine("Votre dernier anniversaire était un " + tool.jourDeLaSemaine(DernierAnniv));


            for (ii = -1; ii >= -9; ii--)
            {
                //Console.WriteLine("vous avez eu " + ((int)age(DateNaiss.AddYears(-ii))).ToString() + " Ans le " + DernierAnniv.AddYears(ii) + " c'était un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
                //Console.WriteLine("vous avez eu " + ((int)Personne.CalcAge() + ii) + " ans le " + DernierAnniv.AddYears(ii) + " c'était un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
                Console.WriteLine("vous avez eu " + ((int)tool.CalcAge(Personne.DateNaiss) + ii) + " ans le " + DernierAnniv.AddYears(ii) + " c'était un " + tool.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
            }

            for (ii = 1; ii <= 10; ii++)
            {
                //Console.WriteLine("vous aurez " + ((int)age(DateNaiss.AddYears(-ii))).ToString() + " Ans le " + DernierAnniv.AddYears(ii) + " ce sera un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
                //Console.WriteLine("vous aurez " + ((int)Personne.CalcAge() + ii) + " Ans le " + DernierAnniv.AddYears(ii) + " ce sera un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
                Console.WriteLine("vous aurez " + ((int)tool.CalcAge(Personne.DateNaiss) + ii) + " Ans le " + DernierAnniv.AddYears(ii) + " ce sera un " + tool.jourDeLaSemaine(DernierAnniv.AddYears(ii)));

            }
            

            Console.ReadLine();
        }
    }
}
