using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppKoralitos.Model;
using AppKoralitos.Model.Clases;

namespace AppKoralitos.Controller
{
    class MainController
    {
        public MainController()
        {
        }

        public List<Mesa> get_mesas()
        {
            return Shared.get_instance().mesas;
        }

        public Dictionary<long, Familia_Platillo> get_menu()
        {
            return Shared.get_instance().menu;
        }

        public Dictionary<long, Cliente> get_clientes()
        {
            return Shared.get_instance().clientes;
        }
    }
}
