using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Context;
using databaseK.Entities;

namespace databaseK.DB.Tables
{
    public class Platillos : Basic<PlatillosEntity>
    {
        public Platillos(MyContext context) : base(context) { }

        public IEnumerable<PlatillosEntity> platillos_familia(long f_id)
        {
            var platillos = where((e) => e.familia == f_id);
            return platillos.ToList();
        }
    }
}
