using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseK.Entities
{
    [Table("compra_platillo")]
    public class CompraPlatilloEntity
    {
        [Key]
        public long id { get; set; }
        public long platillo { get; set; }
        public long compra { get; set; }

        [ForeignKey("platillo")]
        public virtual PlatillosEntity platillo_E { get; set; }
        [ForeignKey("compra")]
        public virtual ComprasEntity compra_E { get; set; }
    }
}
