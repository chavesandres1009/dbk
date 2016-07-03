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
    class CompraPlatilloEntity
    {
        [Key]
        public long id { get; set; }
        public long platillo { get; set; }
        public long compra { get; set; }

        public PlatillosEntity platillo_E { get; set; }
        public ComprasEntity compra_E { get; set; }
    }
}
