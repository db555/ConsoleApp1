using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection MaBase = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MaBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //SqlCommand command = new SqlCommand("Select * From Personne", MaBase);
            //command.Connection.Open();
            //SqlDataReader sR = command.ExecuteReader();

            //while (sR.Read())
            //{
            //    Console.WriteLine($"{sR["Nom"]} " + $"{sR["Prenom"]} " + $"{sR["DNais"]} ");
            //}
            //command.Connection.Close();


            //utiliser path.fullpath
            using (SqlConnection MaBase = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MaBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                MaBase.Open();
                using (SqlCommand command = new SqlCommand("Select * From Personne", MaBase))
                {
                    using (SqlDataReader sR = command.ExecuteReader())
                    {
                        while (sR.Read())
                        {
                            Console.WriteLine($"{sR["Nom"]} " + $"{sR["Prenom"]} " + $"{sR["DNais"]} ");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
