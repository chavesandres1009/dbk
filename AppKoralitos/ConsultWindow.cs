using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppKoralitos.Model.Clases;
using AppKoralitos.Controller;

namespace AppKoralitos
{
    public partial class ConsultWindow : Form
    {

        MainController mcontroller;

        public ConsultWindow()
        {
            mcontroller = new MainController();
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_consult_Click(object sender, EventArgs e)
        {
            this.dataGridView_empleados.Rows.Clear();
            this.dataGridView_plates.Rows.Clear();
            consult();
        }

        private void consult()
        {
            DateTime d1 = this.dateTimePicker1.Value.Date;
            DateTime d2 = this.dateTimePicker2.Value.Date;
            d2.AddHours(23);
            d2.AddMinutes(59);
            var compras = mcontroller.get_compras(d1, d2);
            float ingresos = compras.Sum(c=> c.total);
            float express = compras.Where(c => c.mesa == 0).Sum(c => c.total);
            float pllevar = compras.Where(c => c.mesa < 0).Sum(c => c.total);
            float local = compras.Where(c => c.mesa > 0).Sum(c => c.total);

            this.label_ingresos.Text = ingresos.ToString("#,#");
            this.label_express.Text = express.ToString("#,#");
            this.label_llevar.Text = pllevar.ToString("#,#");
            this.label_local.Text = local.ToString("#,#");
            this.label_total.Text = ingresos.ToString("#,#");
            load_grid_empleados(compras);
            load_grid_plates(compras);
        }

        private void load_grid_empleados(List<Compra> compras)
        {
            var em = mcontroller.get_empleados();
            foreach (var e in em)
            {
                var list = compras.Where(c => c.id_empleado == e.id);
                int can = list.Count();
                float total = list.Sum(c=>c.total);
                add_empleados(e.id, e.nombre, can, total);
            }
        }

        private void load_grid_plates(List<Compra> compras)
        {
            var menu = mcontroller.get_menu(); ;
            foreach (var family in menu)
            {
                foreach (var p in family.Value.platillos)
                {
                    var list = compras.Where(c=> c.platillos.Contains(p.Value));
                    int can = list.Sum(c => c.cant_platillo(p.Key));
                    add_platillos(p.Key, p.Value.nombre, p.Value.precio, can);
                }
            }
        }

        private void add_empleados(long id, string name, int cant, float total)
        {
            this.dataGridView_empleados.Rows.Add(id, name, cant, total);
        }

        private void add_platillos(long id, string name, float price, int cant)
        {
            this.dataGridView_plates.Rows.Add(id, name, price, cant);
        }
    }
}
