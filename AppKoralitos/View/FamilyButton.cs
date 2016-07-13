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

        public FamilyButton(List<FoodButton> platillos)
        {
            this.platillos = platillos;
        }
    }
}
