using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppKoralitos.Model.Clases;
using databaseK.DB;
using databaseK.Context;
using databaseK.Entities;

namespace AppKoralitos.Model
{
    class Shared
    {
        public static long default_client;
        public static long default_emp;
        public Dictionary<int, Mesa> mesas { get; set; }
        public Dictionary<long, Familia_Platillo> menu { get; set; }
        public Dictionary<long, Cliente> clientes { get; set; }
        private static Shared instance;
        public Const constantes { get; set; }


        private Shared()
        {
            this.mesas = new Dictionary<int, Mesa>();
            this.menu = new Dictionary<long, Familia_Platillo>();
            this.clientes = new Dictionary<long, Cliente>();
            this.constantes = new Const();
            init();
        }

        public static Shared get_instance()
        {
            return instance != null ? instance : instance = new Shared();
        }

        /*
        public void ConnectToTheDatabase(string username, string password)
        {
            // create the connection string; I like to user the builder
            System.Data.Common.DbConnectionStringBuilder builder
                = new System.Data.Common.DbConnectionStringBuilder();

            builder.Add("Server", "tcp:asdfewsdfgwe.database.windows.net,1422");
            builder.Add("Database", "supersonic_db");
            builder.Add("User ID", username);
            builder.Add("Password", password);
            builder.Add("Trusted_Connection", "False");
            builder.Add("Encrypt", "True");
            builder.Add("Connection Timeout", "30");

            var connString = builder.ToString();

            // Set the connection string
            MyContext context = new MyContext(connString);

            // Test with something simple
            context.Database.Connection.Open();
            string version = context.Database.Connection.ServerVersion;
            version = version.ToUpper();
        }
        */
        public void init()
        {
            init_mesas();
            init_menu();
            load_clientes();
            using(var db = new DB(new MyContext()))
            {
                var e = db.empleados.first(x => x.nombre == "Mesero Koralitos");
                default_emp = e != null ? e.id : 1;
            }
        }

        public void init_mesas()
        {
            for(var i = 1; i <= constantes.cant_mesas; ++i)
            {
                mesas.Add(i, new Mesa(i));
            }
        }

        public void init_menu()
        {
            using (var db = new DB(new MyContext()))
            {
                var familias = db.familias_p.get_all().ToList();
                foreach (var f in familias)
                {
                    menu.Add(f.id, new Familia_Platillo(f.id, f.nombre));
                    foreach (var p in f.platillos)
                    {
                        menu[f.id].platillos.Add(p.id, new Platillo(f.id, p.id, p.nombre, p.precio));
                    }
                }
            }
        }

        public void load_clientes()
        {
            using (var db = new DB(new MyContext()))
            {
                var clientesdb = db.clientes.get_all();
                foreach (var c in clientesdb)
                {
                    clientes.Add(c.id, new Cliente(c.id, c.nombre, c.correo, c.telefono1, c.telefono2, c.direccion));
                    if (c.nombre.Equals("Desconocido"))
                    {
                        default_client = c.id;
                    }
                }
            }
        }

        public string get_ced()
        {
            return constantes.cedula;
        }

        public void set_ced(string ced)
        {
            constantes.cedula = ced;
        }

        public int cant_mesas()
        {
            return constantes.cant_mesas;
        }

        public void set_mesas(int cant)
        {
            this.constantes.cant_mesas = cant;
        }

        public float iv()
        {
            return constantes.iv;
        }

        public void set_iv(float iv)
        {
            this.constantes.iv = iv;
        }

        public float iS()
        {
            return constantes.iS;
        }

        public void set_is(float iS)
        {
            this.constantes.iS = iS;
        }

        public float transporte()
        {
            return constantes.transporte;
        }

        public void save_changes()
        {
            this.constantes.save_changes();
        }

        public string get_impresora()
        {
            return constantes.impresora;
        }

        public void set_impresora(string imp)
        {
            constantes.impresora = imp;
        }

        public Mesa get_mesa(int id)
        {
            return mesas[id];
        }

        public Cliente cliente_by_telephone(string tel)
        {
            try
            {
                return clientes.First(e => e.Value.telefono1 == tel || e.Value.telefono2 == tel).Value;
            }
            catch(InvalidOperationException e)
            {
                return null;
            }
        }

        public IEnumerable<KeyValuePair<long, Cliente>> client_by_name(string name)
        {
            return clientes.Where(e => e.Value.nombre == name);
        }

        public void set_cliente(long id, string nombre, string tel1, string tel2, string mail, string dir)
        {
            using (var db = new DB(new MyContext()))
            {
                var cl = db.clientes.get(id);
                cl.nombre = nombre;
                cl.telefono1 = tel1;
                cl.telefono2 = tel2;
                cl.correo = mail;
                cl.direccion = dir;
                db.save_changes();
                clientes[id].nombre = nombre;
                clientes[id].telefono1 = tel1;
                clientes[id].telefono2 = tel2;
                clientes[id].correo = mail;
                clientes[id].direccion = dir;
            }
        }

        public void remove_cliente(long id)
        {
            using (var db = new DB(new MyContext()))
            {
                var cl = db.clientes.get(id);
                db.clientes.remove(cl);
                db.save_changes();
                clientes.Remove(id);
            }
        }

        public void set_empleado(long id, string nombre, string tel, string mail)
        {
            using(var db = new DB(new MyContext()))
            {
                var em = db.empleados.get(id);
                em.nombre = nombre;
                em.telefono = tel;
                em.correo = mail;
                db.save_changes();
            }
        }

        public List<Empleado> empleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            using(var db = new DB(new MyContext()))
            {
                foreach(var e in db.empleados.get_all())
                {
                    empleados.Add(new Empleado(e.id, e.nombre, e.is_administrador, e.password, e.telefono, e.correo));
                }
            }
            return empleados;
        }

        public void remove_empleado(long id)
        {
            using (var db = new DB(new MyContext()))
            {
                db.empleados.remove(db.empleados.get(id));
            }
        }

        public void add_empleado(string name, string tel, string mail)
        {
            using(var db = new DB(new MyContext()))
            {
                var em = new EmpleadosEntity() { nombre = name, is_administrador = false, telefono = tel, correo = mail };
                db.empleados.add(em);
                db.save_changes();
            }
        }

        public Empleado get_empleado(long id)
        {
            Empleado empleado = null;
            using(var db = new DB(new MyContext()))
            {
                var em = db.empleados.get(id);
                if(em != null)
                {
                    empleado = new Empleado(em.id, em.nombre, em.is_administrador, em.password, em.telefono, em.correo);
                }
            }
            return empleado;
        }

        public void empleado_change_pass(long id, string new_pass)
        {
            using(var db = new DB(new MyContext()))
            {
                var em = db.empleados.get(id);
                em.password = new_pass;
                db.save_changes();
            }
        }

        public void add_clientes(string name, string tel1, string tel2, string mail, string dir)
        {
            using(var db = new DB(new MyContext()))
            {
                db.clientes.add(new ClientesEntity() { nombre = name, telefono1 = tel1, telefono2 = tel2, correo = mail, direccion = dir});
                db.save_changes();
                clientes = new Dictionary<long, Cliente>();
                load_clientes();
            }
        }

        public void add_new_compra(long cl, long m, DateTime date, int mesa, bool contado,
            float iv, float iS, float desc, long[] platillos, float sub_total, float total)
        {
            using(var db = new DB(new MyContext()))
            {
                ComprasEntity entity = db.compras.add(new ComprasEntity() {
                    cliente = cl,
                    mesero = m,
                    fecha = date,
                    mesa = mesa,
                    contado = contado,
                    impuesto_v = iv,
                    impuesto_s = iS,
                    descuento = desc,
                    subtotal = sub_total,
                    total = total
                });
                db.save_changes();
                foreach (var p in platillos)
                {
                    entity.platillos.Add(new CompraPlatilloEntity() { platillo = p });
                }
                db.save_changes();
            }
        }

        public void add_family(string name)
        {
            using(var db = new DB(new MyContext()))
            {
                FamiliasPEntity entity = db.familias_p.add( new FamiliasPEntity() { nombre = name });
                db.save_changes();
                menu.Add(entity.id, new Familia_Platillo(entity.id, name));
            }
        }

        public void remove_family(long id)
        {
            using(var db = new DB(new MyContext()))
            {
                db.familias_p.remove(db.familias_p.get(id));
                menu.Remove(id);
                db.save_changes();
            }
        }

        public void modify_family(long id, string name)
        {
            using(var db = new DB(new MyContext()))
            {
                var family = db.familias_p.get(id);
                family.nombre = name;
                db.save_changes();
                menu[id].nombre = name;
            }
        }

        public void modify_plate(long id, string name, float precio)
        {
            using(var db = new DB(new MyContext()))
            {
                var plate = db.platillos.get(id);
                plate.nombre = name;
                plate.precio = precio;
                db.save_changes();
                menu[plate.familia].get_platillo(id).nombre = name;
                menu[plate.familia].get_platillo(id).precio = precio;
            }
        }

        public void add_new_plate(long family, string name, float precio)
        {
            using(var db = new DB(new MyContext()))
            {
                PlatillosEntity entity = db.platillos.add(new PlatillosEntity() { familia = family, nombre = name, precio = precio });
                db.save_changes();
                menu[family].platillos.Add(entity.id ,new Platillo(family, entity.id, entity.nombre, entity.precio));
            }
        }

        public Platillo get_plate(long id)
        {
            return menu.First(f => f.Value.get_platillo(id) != null).Value.get_platillo(id);
        }

        public void remove_plate(long id)
        {
            using(var db = new DB(new MyContext()))
            {
                PlatillosEntity entity = db.platillos.remove(db.platillos.get(id));
                db.save_changes();
                menu[entity.familia].platillos.Remove(id);
            }
        }

        public List<Compra> get_compras_dates(DateTime d1, DateTime d2)
        {
            List<Compra> list_compras = new List<Compra>();
            using(var db = new DB(new MyContext()))
            {
                var compras = db.compras.get_all().Where(e=> e.fecha >= d1 && e.fecha <= d2);
                foreach(var c in compras)
                {
                    List<Platillo> plate = new List<Platillo>();
                    foreach(var p in c.platillos)
                    {
                        plate.Add(new Platillo(p.platillo_E.familia, p.platillo_E.id, 
                            p.platillo_E.nombre, p.platillo_E.precio));
                    }
                    list_compras.Add(new Compra(c.id, c.cliente, c.mesero, c.fecha, c.mesa, c.contado, 
                        c.impuesto_v, c.impuesto_s, c.descuento, c.subtotal, c.total, plate));
                }
            }
            return list_compras;
        }

        public List<Orden> get_last_ordenes(long client)
        {
            List<Orden> ordenes = null;
            using(var db = new DB(new MyContext()))
            {
                var ordenes_consult = db.compras.get_all().Where(c => c.cliente == client); ;
                ordenes = new List<Orden>();
                foreach (var order in ordenes_consult)
                {
                    var orden = new Orden() { iv = order.impuesto_v, iS = order.impuesto_s, contado = order.contado,
                        id_cliente = client, id_mesero = order.mesero, descuento = order.descuento, fecha = order.fecha };
                    foreach (var p in order.platillos)
                    {
                        orden.add_plate(p.platillo);
                    }
                    ordenes.Add(orden);
                }
            }
            return ordenes;
        }


    }
}
