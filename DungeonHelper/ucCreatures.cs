using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DungeonHelper
{
    public partial class ucCreatures : UserControl
    {

        public static ucCreatures _instance;
        public static ucCreatures Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCreatures();
                return _instance;
            }
        }
        public ucCreatures()
        {
            InitializeComponent();
            listCreatures.SetSelected(0, true);
            string creature = listCreatures.SelectedItem.ToString();
            using (StreamReader sr = new StreamReader(creature + ".txt"))
            {
                textCreatures.Text = sr.ReadToEnd();
            }
        }
        public ucCreatures(ucBattle battle)
        {
            InitializeComponent();
            listCreatures.SetSelected(0, true);
            string creature = listCreatures.SelectedItem.ToString();
            using (StreamReader sr = new StreamReader(creature + ".txt"))
            {
                textCreatures.Text = sr.ReadToEnd();
            }
        }

        //просмотр характеристика существа
        private void ListCreatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            string creature = listCreatures.SelectedItem.ToString();
            using (StreamReader sr = new StreamReader(creature + ".txt"))
            {
                textCreatures.Text = sr.ReadToEnd();
            }
        }

        //добавление существа в бой
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ucBattle b = ucBattle.Instance;
            b.AddCreature(listCreatures.SelectedItem.ToString());
        }
    }
}
