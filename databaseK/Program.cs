using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using databaseK.Context;
using databaseK.DB;

namespace databaseK
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using(var db = new MyContext())
            {
                var query1 = from b in db.clientes
                            select b;
                var query2 = from b in db.empleados
                            select b;
                var query3 = from b in db.familias_p
                            select b;
               
                Console.WriteLine("Clientes");
                foreach (var item in query1)
                {
                    Console.WriteLine(item.nombre);
                }
                Console.WriteLine("Empleados");
                foreach (var item in query2)
                {
                    Console.WriteLine(item.nombre);
                }
                Console.WriteLine("Familias");
                foreach (var item in query3)
                {
                    Console.WriteLine(item.nombre);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }*/
            using (var db = new databaseK.DB.DB(new MyContext()))
            {
                Console.WriteLine("Search cliente");
                Console.WriteLine("nombre: " + db.clientes.get(1).nombre);
                Console.WriteLine("Search empleado");
                Console.WriteLine("nombre: " + db.empleados.get(2).nombre);
                Console.WriteLine("Search familia");
                Console.WriteLine("nombre: " + db.familias_p.get(4).nombre);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
