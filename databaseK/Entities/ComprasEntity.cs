using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseK.Entities
{
    [Table("compras")]
    public class ComprasEntity
    {
        [Key]
        public long id { get; set; }

        public long cliente { get; set; }
        
        public long mesero { get; set; }

        public DateTime fecha { get; set; }
        public int mesa { get; set; }
        public bool contado { get; set; }
        public float impuesto_v { get; set; }
        public float impuesto_s { get; set; }
        public float descuento { get; set; }
        public float subtotal { get; set; }
        public float total { get; set; }

        [ForeignKey("cliente")]
        public ClientesEntity cliente_E { get; set; }
        [ForeignKey("mesero")]
        public EmpleadosEntity empleado_E { get; set; }

        private ICollection<CompraPlatilloEntity> _platillos;

        public virtual ICollection<CompraPlatilloEntity> platillos
        {
            get { return this._platillos ?? (this._platillos = new HashSet<CompraPlatilloEntity>()); }
        }
    }
}
