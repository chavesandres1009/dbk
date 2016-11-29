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
    public partial class FacturaPLlevar : Form
    {
        private long visible_family = -1;
        private Orden orden;

        public FacturaPLlevar()
        {
            this.mcontrol = new MainController();
            this.orden = new Orden();
            InitializeComponent();
            this.init_food();
        }

        private void btn_family_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                long id = long.Parse(btn.Name.Substring(12));
                if (visible_family > 0)
                {
                    change_visivility(false);
                }
                visible_family = id;
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
            var p = mcontrol.get_platillo(id);
            if (p != null)
            {
                float iv = !this.textBox_iv.Text.Equals("") ? (float.Parse(this.textBox_iv.Text) / 100) + 1 : 0;
                orden.add_plate(id);
                dataGridView1.Rows.Add(p.id, p.nombre, p.precio, p.precio * iv, "Quitar");
            }
        }

        private void change_visivility(bool value)
        {
            foreach (var f in mcontrol.get_menu()[visible_family].platillos)
            {
                this.platillos_btns[f.Key].Visible = value;
            }
        }

        private float get_total()
        {
            return orden.total();
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
            float iv = !this.textBox_iv.Text.Equals("") ? (float.Parse(this.textBox_iv.Text) / 100) * suma : 0;
            float iS = !this.textBox_is.Text.Equals("") ? (float.Parse(this.textBox_is.Text) / 100) * suma : 0;
            float desc = !this.textBox_desc.Text.Equals("") ? float.Parse(this.textBox_desc.Text) : 0;
            float trans = !this.textBox_transporte.Text.Equals("") ? float.Parse(this.textBox_transporte.Text) : 0;
            this.label_sub_total.Text = suma.ToString("#,#");
            this.label_total_desc.Text = (iv + iS + suma + trans).ToString("#,#");
            this.label_total.Text = (iv + iS + suma + trans - desc).ToString("#,#");
        }

        private void update_table()
        {
            float iv = !this.textBox_iv.Text.Equals("") ? (float.Parse(this.textBox_iv.Text) / 100) + 1: 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[3].Value = float.Parse(row.Cells[2].Value.ToString()) * iv;
                }
            }
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 4)
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

        private void button4_Click(object sender, EventArgs e)
        {
            string tel = maskedTextBox1.Text.Remove(4,1);
            Cliente cl = mcontrol.cliente_by_telephone(tel);
            if(cl != null)
            {
                this.label_name.Text = cl.nombre;
                this.richTextBox_dir.Text = cl.direccion;
                orden.id_cliente = cl.id;
            }
            else
            {
                AddModifyClient add_view = new AddModifyClient();

                DialogResult dr = MessageBox.Show("El número ingresado no se encuentra registrado, ¡Desea agregar un nuevo usuario?", "Usuario inexistente", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    var layout = add_view.Controls["tableLayoutPanel1"];
                    layout.Controls["textBox_tel"].Text = tel;
                    add_view.ShowDialog();
                    if(add_view.DialogResult == DialogResult.OK)
                    {
                        mcontrol.add_cliente(layout.Controls["textBox_name"].Text.ToString(),
                            layout.Controls["TextBox_tel1"].Text.ToString(),
                            layout.Controls["TextBox_tel2"].Text.ToString(),
                            layout.Controls["textBox_mail"].Text.ToString(),
                            layout.Controls["richTextBox_dir"].Text.ToString());
                        this.label_name.Text = layout.Controls["textBox_name"].Text.ToString();
                        this.richTextBox_dir.Text = layout.Controls["richTextBox_dir"].Text.ToString();
                    }
                }
                else
                {
                    reset_client();
                }
            }
        }

        private void reset_client()
        {
            this.maskedTextBox1.Text = "";
            this.label_name.Text = "Sin especificar";
            this.richTextBox_dir.Text = "";
            orden.id_cliente = 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void maskedText_enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                maskedTextBox1.Select(0, 0);
            });
        }

        private void button_tipo_pago_Click(object sender, EventArgs e)
        {
            cambiar_pago(!this.button_tipo_pago.Text.Equals("Contado"));
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
        private void cancelar()
        {
            try
            {
                Factura nf = new Factura(this.orden);
                float iv = float.Parse(textBox_iv.Text);
                float iS = float.Parse(textBox_is.Text);
                float desc = float.Parse(textBox_desc.Text);
                float subtotal = float.Parse(label_sub_total.Text);
                float total = float.Parse(label_total.Text);
                bool contado = this.button_tipo_pago.Text.Equals("Contado");
                this.mcontrol.add_new_compra(orden.id_cliente, orden.id_mesero == 0 ? 1 : orden.id_mesero, DateTime.Now, 0, contado, iv, iS, desc, orden.toArray(), subtotal, total);
                nf.factura(label_name.Text, "", subtotal, desc, total);
                this.dataGridView1.Rows.Clear();
                reset_client();
                this.orden = new Orden();
                MessageBox.Show("La compra se a realizado con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error.\nError :" + e.Message);
            }
        }

        private void cambiar_pago(bool contado)
        {
            if (!contado)
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

        private void button_ultimosP_Click(object sender, EventArgs e)
        {
            if (orden.id_cliente > 1)
            {
                search_last_compra();
            }
        }

        private void search_last_compra()
        {
            UltimasComprasForm2 ul = new UltimasComprasForm2(this.orden.id_cliente);
            ul.ShowDialog();

            if(ul.DialogResult == DialogResult.OK)
            {
                orden.platillos = ul.get_order().platillos;
                cargarGrid_ultimaCompra();
            }
        }

        private void cargarGrid_ultimaCompra()
        {
            this.dataGridView1.Rows.Clear();
            foreach(var p in orden.platillos)
            {
                for(int i = 0; i < p.Value; ++i)
                {
                    add_food_row(p.Key);
                }
            }
        }
    }


}
