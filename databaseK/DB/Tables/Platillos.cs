using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Context;
using databaseK.Entities;

namespace databaseK.DB.Tables
{
    class Platillos : Basic<PlatillosEntity>
    {
        public Platillos(MyContext context) : base(context) { }
    }
}
