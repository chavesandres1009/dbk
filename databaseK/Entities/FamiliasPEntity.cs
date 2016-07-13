using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseK.Entities
{
    [Table("familias_p")]
    public class FamiliasPEntity
    {
        [Key]
        public long id { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<PlatillosEntity> platillos { get; set; }
    }
}
