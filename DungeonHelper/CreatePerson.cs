using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonHelper
{
    public partial class CreatePerson : Form
    {
        Creatures person;
        ucBattle battle;
        public CreatePerson(ucBattle battle)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            this.battle = battle;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Weapons weapon = new Scimitar();
            Magic magic = new MagicMissile();
            int w = comboBox1.SelectedIndex;
            int m = comboBox2.SelectedIndex;
            switch (w)
            {
                case 0: weapon = new Scimitar();
                    break;
                case 1: weapon = new LongSword();
                    break;
                case 2: weapon = new Сlaws();
                    break;
            }
            switch (m)
            {
                case 0:
                    magic = new MagicMissile();
                    break;
                case 1:
                    magic = new FireBall();
                    break;
                case 2:
                    magic = new IceKnife();
                    break;
            }
            battle.AddPerson(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text), weapon, magic);
            
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
