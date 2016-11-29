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

        public Dictionary<int, Mesa> get_mesas()
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

        public long default_client()
        {
            return Shared.default_client;
        }

        public long default_empleado()
        {
            return Shared.default_emp;
        }

        public List<Empleado> get_empleados()
        {
            return Shared.get_instance().empleados();
        }

        public Empleado get_empleado(long id)
        {
            return Shared.get_instance().get_empleado(id);
        }

        public void empleado_change_pass(long id, string new_pass)
        {
            Shared.get_instance().empleado_change_pass(id, new_pass);
        }

        public Mesa get_mesa(int id)
        {
            return Shared.get_instance().get_mesa(id);
        }

        public string get_ced()
        {
            return Shared.get_instance().get_ced();
        }

        public void set_ced(string ced)
        {
            Shared.get_instance().set_ced(ced);
        }

        public int get_cant_mesas()
        {
            return Shared.get_instance().cant_mesas();
        }

        public void set_cant_mesas(int cant)
        {
            Shared.get_instance().set_mesas(cant);
        }

        public float get_iv()
        {
            return Shared.get_instance().iv();
        }

        public void set_iv(float iv)
        {
            Shared.get_instance().set_iv(iv);
        }

        public float get_is()
        {
            return Shared.get_instance().iS();
        }

        public void set_is(float iS)
        {
            Shared.get_instance().set_is(iS);
        }

        public float get_costo_trasnporte()
        {
            return Shared.get_instance().transporte();
        }

        public string get_impresora()
        {
            return Shared.get_instance().get_impresora();
        }

        public void set_impresora(string impresora)
        {
            Shared.get_instance().set_impresora(impresora);
        }

        public void save_changes()
        {
            Shared.get_instance().save_changes();
        }

        public Cliente cliente_by_telephone(string tel)
        {
            return Shared.get_instance().cliente_by_telephone(tel);
        }

        public void set_cliente(long id, string name, string tel1, string tel2, string mail, string dir)
        {
            Shared.get_instance().set_cliente(id, name, tel1, tel2, mail, dir);
        }

        public void remove_cliente(long id)
        {
            Shared.get_instance().remove_cliente(id);
        }

        public void set_empleado(long id, string name, string tel, string mail)
        {
            Shared.get_instance().set_empleado(id, name, tel, mail);
        }

        public void remove_empleado(long id)
        {
            Shared.get_instance().remove_empleado(id);
        }

        public void add_empleado(string name, string tel, string mail)
        {
            Shared.get_instance().add_empleado(name, tel, mail);
        }

        public void add_cliente(string name, string tel1, string tel2, string mail, string dir)
        {
            Shared.get_instance().add_clientes(name, tel1, tel2, mail, dir);
        }

        public void add_family(string name)
        {
            Shared.get_instance().add_family(name);
        }

        public void remove_family(long id)
        {
            Shared.get_instance().remove_family(id);
        }

        public void modify_family(long id, string name)
        {
            Shared.get_instance().modify_family(id, name);
        }

        public void add_plate(long family, string name, float price)
        {
            Shared.get_instance().add_new_plate(family, name, price);
        }

        public Platillo get_platillo(long id)
        {
            return Shared.get_instance().get_plate(id);
        }

        public void modify_plate(long id, string name, float price)
        {
            Shared.get_instance().modify_plate(id, name, price);
        }

        public void remove_plate(long id)
        {
            Shared.get_instance().remove_plate(id);
        }

        public void add_new_compra(long client, long m, DateTime date, int table, bool contado, float iv, float iS, float discount,  long[] order, float subtotal, float total)
        {
            Shared.get_instance().add_new_compra(client, m, date, table, contado, iv, iS, discount, order, subtotal, total);
        }

        public List<Compra> get_compras(DateTime d1, DateTime d2)
        {
            return Shared.get_instance().get_compras_dates(d1, d2);
        }

        public List<Orden> get_last_ordenes(long id)
        {
            return Shared.get_instance().get_last_ordenes(id);
        }
    }
}
