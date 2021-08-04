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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (!panel1.Controls.Contains(ucCreatures.Instance))
            {
                panel1.Controls.Add(ucCreatures.Instance);
                ucCreatures.Instance.Dock = DockStyle.Fill;
                ucCreatures.Instance.BringToFront();
            }
            else
                ucCreatures.Instance.BringToFront();
        }

        private void PanelCreatures_Paint(object sender, PaintEventArgs e)
        {

        }

        //загрузка userControl Существа
        private void ButtonCreatures_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucCreatures.Instance))
            {
                panel1.Controls.Add(ucCreatures.Instance);
                ucCreatures.Instance.Dock = DockStyle.Fill;
                ucCreatures.Instance.BringToFront();
            }
            else
                ucCreatures.Instance.BringToFront();
        }

        //загрузка userControl Заклинания
        private void Button2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucMagic.Instance))
            {
                panel1.Controls.Add(ucMagic.Instance);
                ucMagic.Instance.Dock = DockStyle.Fill;
                ucMagic.Instance.BringToFront();
            }
            else
                ucMagic.Instance.BringToFront();
        }

        //загрузка userControl Битва
        private void ButtonBattle_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucBattle.Instance))
            {
                panel1.Controls.Add(ucBattle.Instance);
                ucBattle.Instance.Dock = DockStyle.Fill;
                ucBattle.Instance.BringToFront();
            }
            else
                ucBattle.Instance.BringToFront();
        }
    }
}
