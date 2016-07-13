using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKoralitos
{
    public partial class FacturaPLlevar : Form
    {
        public FacturaPLlevar()
        {
            InitializeComponent();
            add_buttons();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_buttons()
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Text = "Hi new button";
            flowLayoutPanel2.Controls.Add(btn);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
