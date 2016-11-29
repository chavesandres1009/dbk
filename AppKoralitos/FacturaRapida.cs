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

namespace AppKoralitos
{
    public partial class FacturaRapida : Form
    {
        private long act_family = -1;
        private Orden orden;

        public FacturaRapida()
        {
            this.mcontroller = new Controller.MainController();
            this.orden = new Orden();
            InitializeComponent();
            init_food();
            init_default_values();
            init_combo();
        }

        private void init_default_values()
        {
            this.textBox_iv.Text = mcontroller.get_iv().ToString();
            this.textBox_is.Text = mcontroller.get_is().ToString();
        }

        private void init_combo()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach (var c in mcontroller.get_clientes())
            {
                datos.Add(c.Value.nombre);
            }
            this.comboBox_name_cliente.AutoCompleteCustomSource = datos;
        }

        private void btn_family_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                long id = long.Parse(btn.Name.Substring(12));
                if (act_family > 0)
                {
                    change_visivility(false);
                }
                act_family = id;
                change_visivility(true);
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

        private void add_food_row(long id)
        {
            var p = mcontroller.get_menu()[act_family].get_platillo(id);
            if (p != null)
            {
                orden.add_plate(id);
                dataGridView1.Rows.Add(p.id, p.nombre, p.precio, p.precio, "Quitar");
            }
        }

        private void change_visivility(bool value)
        {
            foreach (var f in mcontroller.get_menu()[act_family].platillos)
            {
                this.platillos_btns[f.Key].Visible = value;
            }
        }

        private float get_total()
        {
            return orden.total();
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
            float iv = !this.textBox_iv.Text.Equals("") ? (float.Parse(this.textBox_iv.Text) / 100) * suma : 0;
            float iS = !this.textBox_is.Text.Equals("") ? (float.Parse(this.textBox_is.Text) / 100) * suma : 0;
            float desc = !this.textBox_desc.Text.Equals("") ? float.Parse(this.textBox_desc.Text) : 0;
            this.label_subtotal.Text = suma.ToString("#,#");
            this.label_total.Text = (suma + iv + iS).ToString("#,#");
            this.total_desc.Text = (suma + iv + iS - desc).ToString("#,#");
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                remove_platillo(dataGridView1.CurrentRow);
            }
        }

        private void remove_platillo(DataGridViewRow row)
        {
            if (!row.IsNewRow)
            {
                long id_plate = long.Parse(row.Cells[0].Value.ToString());
                orden.remove_plate(id_plate);
                dataGridView1.Rows.Remove(row);
                update_total();
            }
        }

        private void cancelar()
        {
            try
            {
                Factura nf = new Factura(this.orden);
                float iv = float.Parse(textBox_iv.Text);
                float iS = float.Parse(textBox_is.Text);
                float desc = float.Parse(textBox_desc.Text);
                float subtotal = float.Parse(label_subtotal.Text);
                float total = float.Parse(total_desc.Text);
                bool contado = this.button_tipo_pago.Text.Equals("Contado");
                this.mcontroller.add_new_compra(get_cliente(), get_mesero(), DateTime.Now, -1, contado, iv, iS, desc, orden.toArray(), subtotal, total);
                nf.factura(comboBox_name_cliente.Text, "", subtotal, desc, total);
                this.dataGridView1.Rows.Clear();
                this.orden = new Orden();
                MessageBox.Show("La compra se a realizado con exito");
            } catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error.\nError :" + e.Message);
            }
        }

        private long get_cliente()
        {
            long value;
            try
            {
                value = this.mcontroller.get_clientes().First(e => e.Value.nombre == comboBox_name_cliente.Text).Key;
            } catch (Exception e)
            {
                value = this.mcontroller.get_clientes().First(c => c.Value.nombre == "Desconocido").Key;
            }
            return value;
        }

        private long get_mesero()
        {
            var m = mcontroller.get_empleado(long.Parse(this.textBox_idMesero.Text));
            return m != null ? m.id : 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void click_tipo_pago(object sender, EventArgs e)
        {
            if (this.button_tipo_pago.Text.Equals("Contado"))
            {
                this.button_tipo_pago.Text = "Crédito";
                this.button_tipo_pago.BackColor = Color.Gold;
            }
            else
            {
                this.button_tipo_pago.Text = "Contado";
                this.button_tipo_pago.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura pre = new Factura(this.orden);
            pre.pre_factura();
        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {
            update_total();
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box != null)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == ',') && (box.Text.Contains(',')))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
