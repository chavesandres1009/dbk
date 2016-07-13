using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Context;
using databaseK.Entities;

namespace databaseK.DB.Tables
{
    public class Compras : Basic<ComprasEntity>
    {
        public Compras(MyContext context) : base(context) { }

    }
}
