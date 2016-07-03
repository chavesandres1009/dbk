using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Context;
using databaseK.Entities;

namespace databaseK.DB.Tables
{
    class CompraPlatillo : Basic<CompraPlatilloEntity>
    {
        public CompraPlatillo(MyContext context) : base(context) { }
    }
}
