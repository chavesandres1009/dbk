using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Orden
    {
        public List<Platillo> platillos { get; set; }

        public Orden()
        {
            this.platillos = new List<Platillo>();
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
                suma += p.precio;
            }
            return suma;
        }
       
    }
}
