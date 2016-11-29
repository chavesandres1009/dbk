using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Entities;
using databaseK.Context;

namespace databaseK.DB.Tables
{
    public class Clientes : Basic<ClientesEntity>
    {
        public Clientes(MyContext context) : base(context) { }
        
         public ClientesEntity find_telephone(string tel)
        {
            return first(e => e.telefono1 == tel || e.telefono2 == tel);
        }
    }
}
