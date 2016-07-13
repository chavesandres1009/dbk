using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseK.Entities
{
    [Table("platillos")]
    public class PlatillosEntity
    {
        [Key]
        public long id { get; set; }
        
        public long familia { get; set; }

        public string nombre { get; set; }
        public float precio { get; set; }
        public bool acompanamiento { get; set; }

        [ForeignKey("familia")]
        public FamiliasPEntity familia_E { get; set; }
        public virtual ICollection<CompraPlatilloEntity> compras_platillo { get; set; }
    }
}
