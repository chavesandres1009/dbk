using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Platillo
    {
        public string nombre { get; set; }
        public float precio { get; set; }

        public Platillo(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
