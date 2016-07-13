using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseK.Entities;
using databaseK.Context;

namespace databaseK.DB.Tables
{
    public class Empleados : Basic<EmpleadosEntity>
    {
        public Empleados(MyContext context) : base(context) { }
    }
}
