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
    public partial class CambioContrasenaForm3 : Form
    {

        private MainController mcontroller;
        private Empleado user;

        public CambioContrasenaForm3(long id)
        {
            this.mcontroller = new MainController();
            InitializeComponent();
            init(id);
        }

        private void init(long id)
        {
            user = mcontroller.get_empleado(id);
            this.label_username.Text = user.nombre;
        }

        private bool verificar(string pass, string reply)
        {
            return pass.Equals(reply);
        }

        private void change_pass()
        {
            if(verificar(this.textBox_new_pass.Text, this.textBox_new_pass_reply.Text))
            {
                mcontroller.empleado_change_pass(user.id, Encriptador.encryp(this.textBox_new_pass.Text));
                MessageBox.Show("Nueva contraseña registrada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            change_pass();
        }
    }
}
