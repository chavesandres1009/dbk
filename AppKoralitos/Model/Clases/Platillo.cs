using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Platillo
    {
        public long id_padre { get; set; }
        public long id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }

        public Platillo(long id_padre, long id, string nombre, float precio)
        {
            this.id_padre = id_padre;
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        public override bool Equals(object obj)
        {
            Platillo p = obj as Platillo;
            return p != null ? id.Equals(p.id) : false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
