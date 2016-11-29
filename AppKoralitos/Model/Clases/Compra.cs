using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKoralitos.Model.Clases
{
    class Compra
    {
        public long id { get; set; }
        public long id_cliente { get; set; }
        public long id_empleado { get; set; }
        public DateTime date { get; set; }
        public int mesa { get; set; }
        public bool contado { get; set; }
        public float iv { get; set; }
        public float iS { get; set; }
        public float descuento { get; set; }
        public float subtotal { get; set; }
        public float total { get; set; }
        public List<Platillo> platillos { get; set; }
        
        public Compra(long id, long cliente, long empleado, DateTime date, int mesa, bool contado, 
            float iv, float iS, float desc, float subtotal, float total, List<Platillo> platillos)
        {
            this.id = id;
            this.id_cliente = cliente;
            this.id_empleado = empleado;
            this.date = date;
            this.mesa = mesa;
            this.contado = contado;
            this.iv = iv;
            this.iS = iS;
            this.subtotal = subtotal;
            this.total = total;
            this.platillos = platillos;
        }            

        public int cant_platillo(long id)
        {
            return platillos.Count(e => e.id == id);
        }

    }
}
