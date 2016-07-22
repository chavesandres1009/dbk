using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Platillo
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }

        public Platillo(long id, string nombre, float precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
