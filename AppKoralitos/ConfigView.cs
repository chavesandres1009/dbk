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
    public partial class ConfigView : Form
    {

        private MainController mcontroller;

        public ConfigView()
        {
            mcontroller = new MainController();
            InitializeComponent();
            init();
        }

        private void init()
        {
            this.textBox4.Text = mcontroller.get_ced();
            this.textBox1.Text = mcontroller.get_iv().ToString();
            this.textBox2.Text = mcontroller.get_is().ToString();
            this.textBox3.Text = mcontroller.get_cant_mesas().ToString();
            init_combo();
        }

        private void init_combo()
        {
            foreach(string im in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                this.comboBox1.Items.Add(im);
                if(im == mcontroller.get_impresora())
                {
                    this.comboBox1.Text = im;
                }   
            }
        }

        private void save_changes()
        {
            this.mcontroller.set_ced(this.textBox4.Text);
            this.mcontroller.set_iv(float.Parse(this.textBox1.Text));
            this.mcontroller.set_is(float.Parse(this.textBox2.Text));
            this.mcontroller.set_cant_mesas(int.Parse(this.textBox3.Text));
            this.mcontroller.set_impresora(this.comboBox1.Text);
            this.mcontroller.save_changes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.save_changes();
            MessageBox.Show("Los cambios se han guardado correctamente, reinicie la aplicación para vizualizar los cambios");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
