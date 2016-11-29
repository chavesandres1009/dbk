using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    public class Empleado
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public bool is_admin { get; set; }
        public string pass { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }


        public Empleado(long id, string nombre, bool is_administrador, string pass, string telefono, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.is_admin = is_administrador;
            this.pass = pass;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
