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
using AppKoralitos.View;
using AppKoralitos.Model.Clases;

namespace AppKoralitos
{
    public partial class Factura_Mesa : Form
    {
        private long visible_family = -1;
        private List<Platillo> orden;

        public Factura_Mesa()
        {
            this.mcontrol = new MainController();
            this.orden = new List<Platillo>();
            InitializeComponent();
            this.init_food();
            this.init_mesas();
            this.init_combo();
        }

        private void init_combo()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach(var c in mcontrol.get_clientes())
            {
                datos.Add(c.Value.nombre);
            }
            this.comboBox1.AutoCompleteCustomSource = datos;
        }

        private void btn_family_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                long id = long.Parse(btn.Name.Substring(12));
                if (visible_family > 0)
                {
                    hide_buttons();
                }
                visible_family = id;
                show_buttons(id);
            }
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                long id = long.Parse(btn.Name.Substring(13));
                add_food_row(id);
            }
        }

        private void btn_mesas_click(object sender, EventArgs e)
        {

        }

        private void add_food_row(long id)
        {
            var p = mcontrol.get_menu()[visible_family].get_platillo(id);
            if (p != null)
            {
                orden.Add(p);
                dataGridView1.Rows.Add(p.nombre, p.precio, p.precio, "Quitar");
            }
        }

        private void show_buttons(long id)
        {
            foreach (var p in mcontrol.get_menu()[id].platillos)
            {
                platillos_btns[p.id].Visible = true;
            }
        }

        private void hide_buttons()
        {
            foreach (var p in mcontrol.get_menu()[visible_family].platillos)
            {
                platillos_btns[p.id].Visible = false;
            }
        }

        private float get_total()
        {
            float suma = 0;
            foreach(var p in orden)
            {
                suma += p.precio;
            }
            return suma;
        }

        private void clear_last()
        {
            if (dataGridView1.RowCount > 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.RowCount - 1]);
            }
        }

        private void row_added(object sender, DataGridViewRowsAddedEventArgs e)
        {
            update_total();
        }

        private void row_removed(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            update_total();
        }

        private void update_total()
        {
            float suma = get_total();
            this.label_total_iv.Text = suma.ToString();
            this.label_total_sin_iv.Text = suma.ToString();
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                remove_platillo(dataGridView1.CurrentRow);
            }
        }

        private void remove_platillo(DataGridViewRow row)
        {
            if (!row.IsNewRow)
            {
                orden.Remove(orden[row.Index]);
                dataGridView1.Rows.Remove(row);
                update_total();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
