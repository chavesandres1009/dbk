﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using databaseK.Context;
using databaseK.DB;
using databaseK.Entities;
namespace databaseK
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            using(var db = new MyContext())
            {
                var platillos = db.platillos.ToList();
                foreach(var p in platillos.ToList())
                {
                    Console.WriteLine(p.nombre);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
            */
            
            using (var db = new databaseK.DB.DB(new MyContext()))
            {

                /*foreach(var e in db.empleados.get_all())
                {
                    Console.WriteLine("Id: " + e.id + " nombre: " + e.nombre);
                }
                //Console.WriteLine("Remove familia");
                //Console.WriteLine("nombre: " + db.familias_p.remove(db.familias_p.get(12)));
                //db.save_changes();}
                /*var p1 = db.familias_p.get(4).platillos;
                foreach (var p in p1)
                {
                    Console.WriteLine("Id: " + p.id + " " + p.nombre);
                }*/
                /*
                var e = db.empleados.get(1);
                Console.WriteLine("Id:" + e.id + " nombre: " + e.nombre);
                */

                string s = "btn_platillo_208";
                Console.WriteLine("Text: " + s);
//                Console.WriteLine("Sub: " + s.Substring(12));
                Console.WriteLine("Sub: " + s.Substring(13));
                

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                
            }
            
        }
    }
}

