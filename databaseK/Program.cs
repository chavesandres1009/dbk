using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using databaseK.Context;
using databaseK.DB;
using databaseK.Entities;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.Entity.Core.EntityClient;

namespace databaseK
{
    public class Program
    {
        public const int PARA_LLEVAR = -1;
        public const int PARA_EXPRESS = 0;

        public static string ConnectToTheDatabase(string username, string password)
        {
            var entityConnectionStringBuilder = new EntityConnectionStringBuilder();
            entityConnectionStringBuilder.Provider = "MySql.Data.MySqlClient";     //For me it is "System.Data.SqlClient";
            entityConnectionStringBuilder.ProviderConnectionString = "server=localhost;port=3306;database=koralitos;uid=root;password=root";
            //entityConnectionStringBuilder.Metadata = "res://*";
            return "server=localhost;port=3306;database=koralitos;uid=root;password=root";
        }

        static void Main(string[] args)
        {
            string connect = ConnectToTheDatabase("root", "root");
            Console.WriteLine("Connection string = " +connect);
            Console.WriteLine("Intentando conectarse...");
            using (var db = new databaseK.DB.DB(new MyContext(connect)))
            {
                Console.WriteLine("Entra a using...");
                var em = db.empleados.get_all();
                foreach (var e in em)
                {
                    Console.WriteLine("Id -> " + e.id +  " Nombre: " + e.nombre);
                }
            }
            Console.ReadKey();
            
        }
    }
}

