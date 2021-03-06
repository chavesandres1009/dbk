﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseK.Entities
{
    [Table("empleados")]
    public class EmpleadosEntity
    {
        [Key]
        public long id { get; set; }
        public string nombre { get; set; }
        public bool is_administrador { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }

        public virtual ICollection<ComprasEntity> ventas_E { get; set; }
    }
}
