using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppKoralitos.Model.Clases;

namespace AppKoralitos.View
{
    class FoodButton : Button
    {
        Platillo platillo { get; }

        public FoodButton(Platillo platillo) : base()
        {
            this.platillo = platillo;
            this.Name = "btn_" + platillo.nombre;
            this.Text = platillo.nombre;
        }

        public void action()
        {

        }

        override
        protected void OnClick(EventArgs e)
        {
            MessageBox.Show("The calculations are complete", "My Application",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
