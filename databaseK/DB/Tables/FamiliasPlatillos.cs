using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Entities;
using databaseK.Context;

namespace databaseK.DB.Tables
{
    class FamiliasPlatillos : Basic<FamiliasPEntity>
    {
        public FamiliasPlatillos(MyContext context) : base(context) { }
    }
}
