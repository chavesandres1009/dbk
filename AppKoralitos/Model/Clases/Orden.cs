using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AppKoralitos.Controller;

namespace AppKoralitos.Model.Clases
{
    class Orden
    {
        public Dictionary<long, int> platillos { get; set; }
        public float iv { get; set; }
        public float iS { get; set; }
        public float descuento { get; set; }
        public long id_cliente { get; set; }
        public long id_mesero { get; set; }
        public string client_name { get; set; }
        public bool contado { get; set; }
        public DateTime fecha { get; set; }

        public Orden()
        {
            this.platillos = new Dictionary<long, int>();
        }
        
        public Boolean is_empty()
        {
            return platillos.Count.Equals(0);
        }

        public float total()
        {
            float suma = 0;
            foreach(var p in platillos)
            {
                suma += Shared.get_instance().get_plate(p.Key).precio * p.Value;
            }
            return suma;
        }

        public void reset_order()
        {
            platillos.Clear();
            id_cliente = Shared.default_client;
            id_mesero = Shared.default_emp;
            client_name = "";
        }

        public void add_plate(long id)
        {
            if(platillos.ContainsKey(id))
            {
                ++platillos[id];
            }
            else
            {
                platillos.Add(id, 1);
            }
        }

        public void remove_plate(long id)
        {
            if (platillos[id] == 1)
            {
                platillos.Remove(id);
            }
            else
            {
                --platillos[id];
            }
        }

        public long[] toArray()
        {
            List<long> list = new List<long>();
            foreach(var p in platillos)
            {
                for (int i = 0; i < p.Value; ++i) {
                    list.Add(p.Key);
                }
            }
            return list.ToArray();
        }
        
       
    }
}
