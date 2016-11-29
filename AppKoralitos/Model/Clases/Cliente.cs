using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Cliente
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string direccion { get; set; }

        public Cliente(long id, string nombre, string correo, string telefono1, string telefono2, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.direccion = direccion;
        }
    }
}
