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
    public partial class EmpleadosAdmi : Form
    {
        private MainController mcontroller;

        public EmpleadosAdmi()
        {
            this.mcontroller = new MainController();
            InitializeComponent();
            fill_grid();
        }

        private void fill_grid()
        {
            foreach(var e in mcontroller.get_empleados())
            {
                this.dataGridView1.Rows.Add(e.id, e.nombre, e.telefono, e.correo, e.is_admin ,"Eliminar");
            }
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                remove(this.dataGridView1.CurrentRow);
            }
        }

        private void modify()
        {
            AddModifyEmpleados modify = new AddModifyEmpleados();
            var row = dataGridView1.CurrentRow;
            var layout = modify.Controls["tableLayoutPanel1"];
            long id = long.Parse(row.Cells[0].Value.ToString());
            layout.Controls["textBox_name"].Text = row.Cells[1].Value.ToString();
            layout.Controls["maskedTextBox1"].Text = row.Cells[2].Value.ToString();
            layout.Controls["textBox_mail"].Text = row.Cells[3].Value.ToString();
            modify.ShowDialog();
            if (modify.DialogResult == DialogResult.OK)
            {
                mcontroller.set_empleado(id, layout.Controls["textBox_name"].Text.ToString(),
                                        layout.Controls["maskedTextBox1"].Text.ToString(),
                                        layout.Controls["textBox_mail"].Text.ToString());

                row.Cells[1].Value = layout.Controls["textBox_name"].Text;
                row.Cells[2].Value = layout.Controls["maskedTextBox1"].Text;
                row.Cells[3].Value = layout.Controls["textBox_mail"].Text;
            }
            else if (modify.DialogResult == DialogResult.Cancel)
            {
                modify.Close();
            }
        }

        private void remove(DataGridViewRow row)
        {
            if (!row.IsNewRow)
            {
                long id = long.Parse(row.Cells[0].Value.ToString());
                mcontroller.remove_empleado(id);
                this.dataGridView1.Rows.Remove(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddModifyEmpleados add = new AddModifyEmpleados();
            add.ShowDialog();

            if (add.DialogResult == DialogResult.OK)
            {

                var layout = add.Controls["tableLayoutPanel1"];
                mcontroller.add_empleado(layout.Controls["textBox_name"].Text.ToString(),
                    layout.Controls["maskedTextBox1"].Text.ToString(),
                    layout.Controls["textBox_mail"].Text.ToString());
                this.dataGridView1.Rows.Clear();
                fill_grid();
            }
            else if (add.DialogResult == DialogResult.Cancel)
            {
                add.Close();
            }
        }
    }
}
