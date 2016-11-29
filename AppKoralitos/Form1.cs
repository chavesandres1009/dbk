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
    public partial class Form1 : Form
    {

        MainController mcontroller;

        public Form1()
        {
            mcontroller = new MainController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura_Mesa ven1 = new Factura_Mesa();
            ven1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FacturaPLlevar llevar = new FacturaPLlevar();
            llevar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacturaRapida rapida = new FacturaRapida();
            rapida.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (login(true))
            {
                ConfigView config = new ConfigView();
                config.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (login(true))
            {
                AdmiClientes acl = new AdmiClientes();
                acl.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (login(true))
            {
                EmpleadosAdmi admi = new EmpleadosAdmi();
                admi.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (login(true))
            {
                AdmiPlatillos apla = new AdmiPlatillos();
                apla.Show();
            }
        }

        private bool login(bool admin)
        {
            Login log = new Login();
            log.ShowDialog();
            if (log.DialogResult == DialogResult.Yes)
            {
                var layout = log.Controls["tableLayoutPanel1"];
                long id = long.Parse(layout.Controls["textBox_name"].Text);
                string pass = layout.Controls["textBox_pass"].Text;
                if (!admin ? Auth.validate(id, pass) : Auth.validate_admin(id, pass))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Id de usuario o contraseña erroneos.");
                }
            }
            return false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            if (log.DialogResult == DialogResult.Yes)
            {
                var layout = log.Controls["tableLayoutPanel1"];
                long id = long.Parse(layout.Controls["textBox_name"].Text);
                string pass = layout.Controls["textBox_pass"].Text;
                if ( Auth.validate(id, pass))
                {
                    CambioContrasenaForm3 cc = new CambioContrasenaForm3(id);
                    cc.Show();
                }
                else
                {
                    MessageBox.Show("Id de usuario o contraseña erroneos.");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            if (log.DialogResult == DialogResult.Yes)
            {
                var layout = log.Controls["tableLayoutPanel1"];
                long id = long.Parse(layout.Controls["textBox_name"].Text);
                string pass = layout.Controls["textBox_pass"].Text;
                if (Auth.validate(id, pass))
                {
                    modify_user(id);
                }
                else
                {
                    MessageBox.Show("Id de usuario o contraseña erroneos.");
                }
            }
        }

        private void modify_user(long user_id)
        {
            AddModifyEmpleados modify = new AddModifyEmpleados();
            var user = mcontroller.get_empleado(user_id);
            var layout = modify.Controls["tableLayoutPanel1"];
            layout.Controls["textBox_name"].Text = user.nombre;
            layout.Controls["maskedTextBox1"].Text = user.telefono;
            layout.Controls["textBox_mail"].Text = user.correo;
            modify.ShowDialog();
            if (modify.DialogResult == DialogResult.OK)
            {
                mcontroller.set_empleado(user_id, layout.Controls["textBox_name"].Text.ToString(),
                                        layout.Controls["maskedTextBox1"].Text.ToString(),
                                        layout.Controls["textBox_mail"].Text.ToString());
            }
            else if (modify.DialogResult == DialogResult.Cancel)
            {
                modify.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            if (log.DialogResult == DialogResult.Yes)
            {
                var layout = log.Controls["tableLayoutPanel1"];
                long id = long.Parse(layout.Controls["textBox_name"].Text);
                string pass = layout.Controls["textBox_pass"].Text;
                if (Auth.validate(id, pass))
                {
                    ConsultWindow cw = new ConsultWindow();
                    cw.Show();
                }
                else
                {
                    MessageBox.Show("Id de usuario o contraseña erroneos.");
                }
            }
        }
    }
}
