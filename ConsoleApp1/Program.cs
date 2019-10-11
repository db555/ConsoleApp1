using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloword
{
    public static class tool
    {
        public static double CalcAge( DateTime DateNaiss )
        {
            return ((DateTime.Now - DateNaiss).Days / 365.242189);
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

        public double CalcAge()
        {
            return ((DateTime.Now - DateNaiss).Days / 365.242189);
        }
    }

    public class IdentiteTel : identite
    {
        string NoTel;
        public IdentiteTel (string prenom, string nom, DateTime datenaiss, string noTel) : base( prenom,  nom,  datenaiss)
        {
            NoTel = noTel;
        }
    }

    class Program
    {
        //public static double age(DateTime dnais)
        //{
        //    return ((DateTime.Now - dnais).Days / 365.242189);
        //}

        //public static string jourDeLaSemaine(DateTime dt)
        //{
        //    switch (dt.DayOfWeek)
        //    {
        //        case DayOfWeek.Sunday:
        //            return "Dimanche";
        //        case DayOfWeek.Monday:
        //            return "Lundi";
        //        case DayOfWeek.Tuesday:
        //            return "Mardi";
        //        case DayOfWeek.Wednesday:
        //            return "Mercredi";
        //        case DayOfWeek.Thursday:
        //            return "Jeudi";
        //        case DayOfWeek.Friday:
        //            return "Vendredi";
        //        case DayOfWeek.Saturday:
        //            return "Samedi";
        //        default:
        //            return "";
        //    }
        //}

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

            //Console.WriteLine("saisir le 1er nombre");
            //Nb1 = Console.ReadLine();

            //for (ii=Convert.ToInt32(Nb1); ii>0; ii--)
            //{
            //    Console.WriteLine(ii);
            //}

            //ii = Convert.ToInt32(Nb1);
            //while (ii>0)
            //{
            //    Console.WriteLine(ii--);
            //}

            //if (Convert.ToInt32(Nb1) % 2 == 0)
            //{
            //    Console.WriteLine("Le nombre est pair");
            //}
            //else
            //{
            //    Console.WriteLine("Le nombre est impair");
            //}
            //Console.WriteLine("saisir le 2eme nombre");
            //Nb2 = Console.ReadLine();
            ////Console.WriteLine($"la somme est : {Convert.ToInt32(Nb1) + Convert.ToInt32(Nb2)}");
            //Console.WriteLine("la somme est : " + (Convert.ToInt32(Nb1) + Convert.ToInt32(Nb2)));

            Console.WriteLine("Quel est votre prénom ?");
            Prenom = Console.ReadLine();
            Console.WriteLine("Quel est votre nom ?");
            Nom = Console.ReadLine();

            Console.WriteLine("quel est votre date de naissance ?");
            DateNaiss = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("quel est votre no de téléphone ?");
            NoTelephone = Console.ReadLine();

            identite Personne = new identite(Prenom,Nom,DateNaiss );
            IdentiteTel PersTel = new IdentiteTel(Prenom, Nom, DateNaiss, NoTelephone);

            Console.WriteLine("Bonjour " + Prenom + " " + Nom);
            //Console.WriteLine("Votre age est " + age(Personne.DateNaiss).ToString());
            Console.WriteLine("Votre age est " + Personne.CalcAge().ToString());

            //DernierAnniv = Personne.DateNaiss.AddYears(Convert.ToInt32( (int)( age(Personne.DateNaiss))));
            //DernierAnniv = Personne.DateNaiss.AddYears((int)(age(Personne.DateNaiss)));
            DernierAnniv = DateNaiss.AddYears((int)(Personne.CalcAge()));

            Console.WriteLine("Votre dernier anniversaire était un " + identite.jourDeLaSemaine(DernierAnniv));


            for (ii = -1; ii >= -9; ii--)
            {
                //Console.WriteLine("vous avez eu " + ((int)age(DateNaiss.AddYears(-ii))).ToString() + " Ans le " + DernierAnniv.AddYears(ii) + " c'était un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
                Console.WriteLine("vous avez eu " + ((int)Personne.CalcAge() + ii) + " ans le " + DernierAnniv.AddYears(ii) + " c'était un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
            }

            for (ii = 1; ii <= 10; ii++)
            {
                //Console.WriteLine("vous aurez " + ((int)age(DateNaiss.AddYears(-ii))).ToString() + " Ans le " + DernierAnniv.AddYears(ii) + " ce sera un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));
                Console.WriteLine("vous aurez " + ((int)Personne.CalcAge()+ii) + " Ans le " + DernierAnniv.AddYears(ii) + " ce sera un " + identite.jourDeLaSemaine(DernierAnniv.AddYears(ii)));

            }


            Console.ReadLine();
        }
    }
}
