using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Familia_Platillo
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public Dictionary<long, Platillo> platillos { get; set; }

        public Familia_Platillo(long id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            platillos = new Dictionary<long, Platillo>();
        }

        public Platillo get_platillo(long id)
        {
            return platillos.ContainsKey(id) ? platillos[id] : null;
        }
    }
}
