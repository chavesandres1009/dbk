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
        public Dictionary<long, Cliente> clientes { get; set; }
        private static Shared instance;


        private Shared()
        {
            this.mesas = new List<Mesa>();
            this.menu = new Dictionary<long, Familia_Platillo>();
            this.clientes = new Dictionary<long, Cliente>();
            init();
        }

        public static Shared get_instance()
        {
            return instance != null ? instance : instance = new Shared();
        }

        public void init()
        {
            init_mesas();
            init_menu();
            load_clientes();
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
                    var platillos = db.platillos.platillos_familia(f.id);
                    menu.Add(f.id, new Familia_Platillo(f.id, f.nombre));
                    foreach (var p in platillos)
                    {
                        menu[f.id].platillos.Add(new Platillo(p.id, p.nombre, p.precio));
                    }
                }
            }
        }

        public void load_clientes()
        {
            using (var db = new DB(new MyContext()))
            {
                var clientesdb = db.clientes.get_all();
                foreach (var c in clientesdb)
                {
                    clientes.Add(c.id, new Cliente(c.id, c.nombre, c.correo, c.telefono, c.direccion));
                }
            }
        }

    }
}
