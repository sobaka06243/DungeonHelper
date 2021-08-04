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
    public partial class ucMagic : UserControl
    {
  
        public static ucMagic _instance;
        public static ucMagic Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMagic();
                return _instance;
            }
        }
        public ucMagic()
        {
            InitializeComponent();
            listMagic.SetSelected(0, true);
            string creature = listMagic.SelectedItem.ToString();
            using (StreamReader sr = new StreamReader(creature + ".txt"))
            {
                textMagic.Text = sr.ReadToEnd();
            }
        }
        //загрузка информации о заклинании
        private void ListMagic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string creature = listMagic.SelectedItem.ToString();
            using (StreamReader sr = new StreamReader(creature + ".txt"))
            {
                textMagic.Text = sr.ReadToEnd();
            }
        }
    }
}
