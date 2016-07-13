using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Mesa
    {
        public const int LIBRE = 0;
        public const int  OCUPADO = 1;

        public int num_mesa { get; set; }
        public int estado { get; set; }

        public Mesa(int num_mesa)
        {
            this.num_mesa = num_mesa;
            this.estado = LIBRE;
        }
    }
}
