using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppKoralitos.Controller;
using AppKoralitos.Model.Clases;

namespace AppKoralitos
{
    public class Auth
    {
        public static bool validate(long id, string pass)
        {
            var control = new MainController();
            var u = control.get_empleado(id);
            return u != null ? compare_pass(u, pass)  : false;
        }

        public static Empleado validate_data(long id, string pass)
        {
            var control = new MainController();
            var u = control.get_empleado(id);
            return u != null && compare_pass(u, pass) ? u : null;
        }

        public static bool validate_admin(long id, string pass)
        {
            var control = new MainController();
            var u = control.get_empleado(id);
            return u != null ?  u.is_admin && compare_pass(u, pass) : false;
        }

        public static Empleado validate_admin_data(long id, string pass)
        {
            var control = new MainController();
            var u = control.get_empleado(id);
            return u != null && compare_pass(u, pass) && u.is_admin ? u : null;
        }

        private static bool compare_pass(Empleado user, string pass)
        {
            return user.pass != null ? user.pass.Equals(Encriptador.encryp(pass)) : true;
        }
    }
}
