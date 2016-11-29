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

namespace AppKoralitos
{
    public partial class AdmiClientes : Form
    {
        MainController mcontroller;
        
        public AdmiClientes()
        {
            mcontroller = new MainController();
            InitializeComponent();
            fill_Grid();
        }

        private void fill_Grid()
        {
            foreach(var c in mcontroller.get_clientes())
            {
                this.dataGridView1.Rows.Add(c.Value.id, c.Value.nombre, c.Value.telefono1, c.Value.correo, c.Value.direccion, "Modificar", "Eliminar");
            }
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                modify();
            }
            if(this.dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                remove(dataGridView1.CurrentRow);
            }
        }

        private void remove(DataGridViewRow row)
        {
            if (!row.IsNewRow)
            {
                long id = long.Parse(row.Cells[0].Value.ToString());
                mcontroller.remove_cliente(id);
                this.dataGridView1.Rows.Remove(row);
            }
        }

        private void modify()
        {
            AddModifyClient modify = new AddModifyClient();
            var row = dataGridView1.CurrentRow;
            var layout = modify.Controls["tableLayoutPanel1"];
            long id = long.Parse(row.Cells[0].Value.ToString());
            layout.Controls["textBox_name"].Text = row.Cells[1].Value.ToString();
            layout.Controls["textBox_tel"].Text = row.Cells[2].Value.ToString();
            layout.Controls["textBox_mail"].Text = row.Cells[3].Value.ToString();
            layout.Controls["richTextBox_dir"].Text = row.Cells[4].Value.ToString();
            modify.ShowDialog();
            if(modify.DialogResult == DialogResult.OK)
            {
                mcontroller.set_cliente(id, layout.Controls["textBox_name"].Text.ToString(),
                                        layout.Controls["TextBox_tel1"].Text.ToString(),
                                        layout.Controls["TextBox_tel2"].Text.ToString(),
                                        layout.Controls["textBox_mail"].Text.ToString(),
                                        layout.Controls["richTextBox_dir"].Text.ToString());

                row.Cells[1].Value = layout.Controls["textBox_name"].Text;
                row.Cells[2].Value = layout.Controls["textBox_tel"].Text;
                row.Cells[3].Value = layout.Controls["textBox_mail"].Text;
                row.Cells[4].Value = layout.Controls["richTextBox_dir"].Text;
            } else if (modify.DialogResult == DialogResult.Cancel)
            {
                modify.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddModifyClient add = new AddModifyClient();
            add.ShowDialog();

            if(add.DialogResult == DialogResult.OK)
            {

                var layout = add.Controls["tableLayoutPanel1"];
                mcontroller.add_cliente(layout.Controls["textBox_name"].Text.ToString(),
                    layout.Controls["TextBox_tel1"].Text.ToString(),
                    layout.Controls["TextBox_tel2"].Text.ToString(),
                    layout.Controls["textBox_mail"].Text.ToString(),
                    layout.Controls["richTextBox_dir"].Text.ToString());
                this.dataGridView1.Rows.Clear();
                fill_Grid();
            } else if (add.DialogResult == DialogResult.Cancel)
            {
                add.Close();
            }
        }   
    }
}
