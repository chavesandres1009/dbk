using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppKoralitos.Controller;
using AppKoralitos.Model.Clases;
namespace AppKoralitos
{
    partial class UltimasComprasForm2 : Form
    {

        private MainController mcontroller;
        private List<Orden> pedidos;
        private int position;

        public UltimasComprasForm2(long client)
        {
            mcontroller = new MainController();
            InitializeComponent();
            position = 0;
            loadPedidos(client);
            loadList();
        }

        private void loadPedidos(long client)
        {
            pedidos = mcontroller.get_last_ordenes(client);
            position = pedidos.Count - 1;
        }

        private void loadList()
        {
            if (pedidos != null && pedidos.Count > 0)
            {
                foreach (var p in pedidos[position].platillos)
                {
                    var name = mcontroller.get_platillo(p.Key).nombre;
                    listBox1.Items.Add(p.Value + " " + name);
                }
                this.label_date.Text = pedidos[position].fecha.ToString("dd/MM/yyyy");
            }
        }

        public Orden get_order()
        {
            return pedidos[position];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            next();
            this.listBox1.Items.Clear();
            loadList(); 
        }

        private void next()
        {
            position = position - 1 < 0 ? 0 : position - 1;
        }

        private void after()
        {
            position = position + 1 >= pedidos.Count ? position : position + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            after();
            this.listBox1.Items.Clear();
            loadList();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
