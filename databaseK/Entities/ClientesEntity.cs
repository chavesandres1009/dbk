using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseK.Entities
{
    [Table("clientes")]
    public class ClientesEntity
    {
        [Key]
        public long id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }

        public virtual ICollection<ComprasEntity> compras { get; set; }
    }
}
