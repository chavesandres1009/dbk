﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Entities;
using databaseK.Context;

namespace databaseK.DB.Tables
{
    class Clientes : Basic<ClientesEntity>
    {
        public Clientes(MyContext context) : base(context) { }
        
         
    }
}
