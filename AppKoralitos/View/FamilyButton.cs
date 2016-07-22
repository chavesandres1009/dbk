using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKoralitos.View
{
    class FamilyButton : Button
    {
        List<FoodButton> platillos { get; set; }

        public FamilyButton(string name, List<FoodButton> platillos) : base()
        {
            this.platillos = platillos;
            this.Name = "btn" + name;
            this.Text = name;
        }

        public void active_btns()
        {
            foreach(var p in platillos)
            {
                p.Visible = true;
            }
        }

        public void deactive()
        {
            foreach(var p in platillos)
            {
                p.Visible = false;  
            }
        }
    }
}
