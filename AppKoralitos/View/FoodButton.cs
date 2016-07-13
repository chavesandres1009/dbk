using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKoralitos.View
{
    class FoodButton : Button
    {
        TableLayoutPanel table { get; set; }
        
        public FoodButton(TableLayoutPanel table)
        {
            this.table = table;
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
