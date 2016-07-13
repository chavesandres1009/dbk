using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppKoralitos.Model.Clases;
using databaseK.DB;
using databaseK.Context;

namespace AppKoralitos.Model
{
    class Shared
    {
        public static int CANTIDAD_MESAS = 15;
        public List<Mesa> mesas { get; set; }
        public Dictionary<long, Familia_Platillo> menu { get; set; }

        public void init()
        {
            init_mesas();
            init_menu();
        }

        public void init_mesas()
        {
            for(var i = 1; i <= CANTIDAD_MESAS; ++i)
            {
                mesas.Add(new Mesa(i));
            }
        }

        public void init_menu()
        {
            using (var db = new DB(new MyContext()))
            {
                var familias = db.familias_p.get_all().ToList();
                foreach (var f in familias)
                {
                    var platillos = db.platillos.get_all().ToList();
                    menu.Add(f.id, new Familia_Platillo(f.id, f.nombre));
                    foreach (var p in platillos)
                    {
                        menu[f.id].platillos.Add(new Platillo(p.nombre, p.precio));
                    }
                }
            }
        }

    }
}
