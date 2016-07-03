using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Context;
using databaseK.DB.Tables;

namespace databaseK.DB
{
    class DB : IDisposable
    {
        private MyContext context;

        public Clientes clientes { get; }
        public Empleados empleados { get; }
        public FamiliasPlatillos familias_p { get; }
        public Compras compras { get; }
        public Platillos platillos { get; }
        public CompraPlatillo compra_platillo { get; }

        public DB(MyContext context)
        {
            this.context = context;
            this.clientes = new Clientes(context);
            this.empleados = new Empleados(context);
            this.familias_p = new FamiliasPlatillos(context);
            this.compras = new Compras(context);
            this.platillos = new Platillos(context);
            this.compra_platillo = new CompraPlatillo(context);
        }

        public int save_changes()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public MyContext getContext()
        {
            return context;
        }
    }
}
