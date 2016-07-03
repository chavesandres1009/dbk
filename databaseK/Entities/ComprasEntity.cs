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
    class ComprasEntity
    {
        [Key]
        public long id { get; set; }

        public long cliente { get; set; }
        
        public long mesero { get; set; }

        public DateTime fecha { get; set; }
        public int mesa { get; set; }
        public float impuesto_v { get; set; }
        public float impuesto_s { get; set; }
        public float descuento { get; set; }

        public ClientesEntity cliente_E { get; set; }
        public EmpleadosEntity empleado_E { get; set; }

        public ICollection<CompraPlatilloEntity> platillos { get; set; }
    }
}
