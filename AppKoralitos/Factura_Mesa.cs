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
    public partial class Factura_Mesa : Form
    {
        private long visible_family = -1;
        private Mesa mesa_actual;

        public Factura_Mesa()
        {
            this.mcontrol = new MainController();
            InitializeComponent();
            init_default_values();
            this.init_food();
            this.init_mesas();
            this.init_combo();
        }

        private void init_default_values()
        {
            this.textBox_iv.Text = mcontrol.get_iv().ToString();
            this.textBox_is.Text = mcontrol.get_is().ToString();
        }

        private void init_combo()
        {
            foreach(var c in mcontrol.get_clientes())
            {
                ComboBoxItem item = new ComboBoxItem() { Value = c.Key, Text = c.Value.nombre };
                this.comboBox_name_cliente.Items.Add(item);
                this.comboBox_name_cliente.AutoCompleteCustomSource.Add(c.Value.nombre);
            }
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

        private void abrir_mesa(int id)
        {
            Mesa m = mcontrol.get_mesas()[id];
            guardar_datos();
            if (m.estado == Mesa.LIBRE)
            {
                DialogResult result = MessageBox.Show("¿Desea abrir la mesa #" + id + "?",
                    "Mesa #" + id, MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    m.estado = Mesa.OCUPADO;
                    mesa_actual = m;
                    mesas_btns[id].BackColor = Color.LightGreen;
                    this.comboBox_name_cliente.Text = mesa_actual.orden.client_name;
                    change_grid();
                }
            }
            else
            {
                cambiar_mesa(m);
            }
        }

        private void cambiar_mesa(Mesa table)
        {
            mesa_actual = table;
            this.comboBox_name_cliente.Text = mcontrol.get_mesas()[table.num_mesa].orden.client_name;
            this.textBox_iv.Text = mcontrol.get_mesas()[table.num_mesa].orden.iv.ToString();
            this.textBox_is.Text = mcontrol.get_mesas()[table.num_mesa].orden.iS.ToString();
            this.textBox_desc.Text = mcontrol.get_mesas()[table.num_mesa].orden.descuento.ToString();
            this.textBox_idMesero.Text = mcontrol.get_mesas()[table.num_mesa].orden.id_mesero.ToString();
            cambiar_pago(mesa_actual.orden.contado);
            change_grid();
        }

        private void guardar_datos()
        {
            if(mesa_actual != null)
            {
                var item = this.comboBox_name_cliente.SelectedItem as ComboBoxItem;
                mesa_actual.orden.id_cliente = item != null ? (long)item.Value : mcontrol.default_client();
                mesa_actual.orden.client_name = this.comboBox_name_cliente.Text;
                mesa_actual.orden.iv = float.Parse(this.textBox_iv.Text);
                mesa_actual.orden.iS = float.Parse(this.textBox_is.Text);
                mesa_actual.orden.descuento = float.Parse(this.textBox_desc.Text);
                mesa_actual.orden.id_mesero = !this.textBox_idMesero.Text.Equals("") ? long.Parse(this.textBox_idMesero.Text) : mcontrol.default_empleado();
                mesa_actual.orden.contado = this.button_tipo_pago.Text.Equals("Contado");
            }
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && mesa_actual != null)
            {
                long id = long.Parse(btn.Name.Substring(13));
                add_food_row(id);
            }
        }

        private void btn_mesas_click(object sender, EventArgs e)
        {
            Button mbtn = sender as Button;
            if (mbtn != null)
            {
                int id = int.Parse(mbtn.Name.Substring(9));
                abrir_mesa(id);
            }
        }

        private void change_grid()
        {
            this.dataGridView1.Rows.Clear();
            foreach(var p in mesa_actual.orden.platillos)
            {
                load_grid(p.Value, p.Key);
            }
            update_total();
        }

        private void load_grid(int cant, long platillo)
        {
            var p = mcontrol.get_platillo(platillo);
            float iv = float.Parse(this.textBox_iv.Text) / 100 + 1;
            if (p != null)
            {
                for (int i = 0; i < cant; ++i)
                {
                    dataGridView1.Rows.Add(p.id, p.nombre, p.precio, p.precio * iv, "Quitar", true);
                }
            }
        }

        private void add_food_row(long id)
        {
            var p = mcontrol.get_menu()[visible_family].get_platillo(id);
            if (p != null)
            {
                float iv = float.Parse(this.textBox_iv.Text) / 100 + 1; 
                mesa_actual.orden.add_plate(id);
                dataGridView1.Rows.Add(p.id ,p.nombre, p.precio, p.precio * iv , "Quitar", true);
            }
        }

        private void show_buttons(long id)
        {
            foreach (var p in mcontrol.get_menu()[id].platillos)
            {
                platillos_btns[p.Key].Visible = true;
            }
        }

        private void hide_buttons()
        {
            foreach (var p in mcontrol.get_menu()[visible_family].platillos)
            {
                platillos_btns[p.Key].Visible = false;
            }
        }

        /*private float get_total()
        {
            return mesa_actual.orden.total();
        }*/

        private float get_total()
        {
            float suma = 0;
            foreach(DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[5].Value.Equals(true))
                {
                    suma += float.Parse(row.Cells[2].Value.ToString());
                }
            }
            return suma;
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
            this.label_sub_total.Text = suma.ToString("#,#");
            this.label_total_desc.Text = (iv + iS + suma).ToString("#,#");
            this.label_total.Text = (iv + iS + suma - desc).ToString("#,#");
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1.CurrentRow.IsNewRow)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    remove_platillo(dataGridView1.CurrentRow);
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 5)
                {
                    dataGridView1.CurrentRow.Cells[5].Value = !((bool)dataGridView1.CurrentRow.Cells[5].Value);
                    update_total();
                }
            }
        }

        private void remove_platillo(DataGridViewRow row)
        {
            if (!row.IsNewRow)
            {
                long id = long.Parse(row.Cells[0].Value.ToString());
                mesa_actual.orden.remove_plate(id);
                dataGridView1.Rows.Remove(row);
                update_total();
            }
        }

        private void cancelar()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            Orden platillos = new Orden(); 
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[5].Value.Equals(true))
                    {
                        rows.Add(row);
                        long id = long.Parse(row.Cells[0].Value.ToString());
                        platillos.add_plate(id);
                    }
                }
            }
            cobrar(platillos);
            foreach (var r in rows)
            {
                remove_platillo(r);
            }
            this.comboBox_name_cliente.Text = "";
            cerrar_mesa();
        }

        private void cobrar(Orden orden)
        {
            guardar_datos();
            float subtotal = float.Parse(this.label_sub_total.Text);
            float total = float.Parse(this.label_total.Text);
            mcontrol.add_new_compra(mesa_actual.orden.id_cliente, mesa_actual.orden.id_mesero, DateTime.Today, mesa_actual.num_mesa, mesa_actual.orden.contado, 
                mesa_actual.orden.iv, mesa_actual.orden.iS, mesa_actual.orden.descuento, orden.toArray(), subtotal, total);
            Factura factura = new Factura(mesa_actual.orden);
            factura.factura(this.comboBox_name_cliente.Text, " ", subtotal, mesa_actual.orden.descuento, total);
        }

        private void cerrar_mesa()
        {
            if(mesa_actual.orden.platillos.Count == 0)
            {
                mesas_btns[mesa_actual.num_mesa].BackColor = Color.Aqua;
                mesa_actual.close_table();
            }
        }

        private void button_tipo_pago_Click(object sender, EventArgs e)
        {
            cambiar_pago(!this.button_tipo_pago.Text.Equals("Contado"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            Factura fac = new Factura(mesa_actual.orden);
            fac.pre_factura();
        }

        private void textBox_desc_TextChanged(object sender, EventArgs e)
        {
            if (mesa_actual != null)
            {
                update_total();
            }
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = sender as TextBox;
            if(box != null)
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

        private void button_Cancelar(object sender, EventArgs e)
        {
            cancelar();
        }
    }
}
