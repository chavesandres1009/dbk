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
    public partial class AdmiPlatillos : Form
    {
        long act_family = -1;
        long act_plate = -1;

        public AdmiPlatillos()
        {
            this.mcontroller = new MainController();
            InitializeComponent();
            init_food();
        }

        private void btn_family_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                long id = long.Parse(btn.Name.Substring(12));
                if (act_family > 0)
                {
                    change_visivility(false);
                    families_btns[act_family].BackColor = Color.White;
                }
                textBox_namefamily.Text = mcontroller.get_menu()[id].nombre;
                act_family = id;
                change_visivility(true);
                families_btns[act_family].BackColor = Color.Green;
            }
        }

        private void change_visivility(bool value)
        {
            foreach(var f in mcontroller.get_menu()[act_family].platillos)
            {
                this.platillos_btns[f.Key].Visible = value;
            }
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                long id = long.Parse(btn.Name.Substring(13));
                if (act_plate > 0)
                {
                    platillos_btns[act_plate].BackColor = Color.White;
                }
                textBox_nameplate.Text = mcontroller.get_menu()[act_family].get_platillo(id).nombre;
                textBox_price.Text = mcontroller.get_menu()[act_family].get_platillo(id).precio.ToString();
                act_plate = id;
                platillos_btns[act_plate].BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (act_plate > 0)
            {
                mcontroller.modify_plate(act_plate, textBox_nameplate.Text, float.Parse(textBox_price.Text));
                platillos_btns[act_plate].Text = textBox_nameplate.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (act_family > 0)
            {
                mcontroller.modify_family(act_family, textBox_namefamily.Text);
                families_btns[act_family].Text = textBox_namefamily.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(act_plate > 0)
            {
                mcontroller.remove_plate(act_plate);
                platillos_btns[act_plate].Visible = false;
                platillos_btns.Remove(act_plate);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_new_family();
        }

        private void add_new_family()
        {
            string name = PromptDialog.ShowDialog("Ingrese el nombre de la nueva familia", "Nueva Familia");
            if (!name.Equals(""))
            {
                mcontroller.add_family(name);
                var p = mcontroller.get_menu().Last();
                families_btns.Add(p.Value.id, family_button(p.Value));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            remove_family();
        }

        private void remove_family()
        {
            if (act_family > 0)
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea borrar la familia seleccionada?", "Eliminar familia", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    mcontroller.remove_family(act_family);
                    families_btns[act_family].Visible = false;
                    act_family = -1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (act_family > 0)
            {
                AddPlatillos addplate = new AddPlatillos();
                addplate.ShowDialog();
                if (addplate.DialogResult == DialogResult.OK)
                {
                    var layout = addplate.Controls["tableLayoutPanel"];
                    mcontroller.add_plate(act_family, layout.Controls["textBox_name"].Text, float.Parse(layout.Controls["textBox_price"].Text));
                    food_button(mcontroller.get_menu()[act_family].platillos.Last().Value, true);
                }
            }
        }
    }
}
