using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Entities;

namespace databaseK.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {

        }

        public MyContext(string connString) : base(connString) { }

        public virtual DbSet<ClientesEntity> clientes { get; set; }
        public virtual DbSet<EmpleadosEntity> empleados { get; set; }
        public virtual DbSet<FamiliasPEntity> familias_p { get; set; }
        public virtual DbSet<ComprasEntity> compras { get; set; }
        public virtual DbSet<PlatillosEntity> platillos { get; set; }
        public virtual DbSet<CompraPlatilloEntity> compra_platillo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
