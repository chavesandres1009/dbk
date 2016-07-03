using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Entities;

namespace databaseK.Context
{
    class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {

        }

        public DbSet<ClientesEntity> clientes { get; set; }
        public DbSet<EmpleadosEntity> empleados { get; set; }
        public DbSet<FamiliasPEntity> familias_p { get; set; }
        public DbSet<ComprasEntity> compras { get; set; }
        public DbSet<PlatillosEntity> platillos { get; set; }
        public DbSet<CompraPlatilloEntity> compra_platillo { get; set; }
    }
}
