using ChelseaManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChelseaManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTeam_Click(object sender, EventArgs e)
        {
            TeamPanel panel = new TeamPanel();
            panelMain.Controls.Clear();
            
            panelMain.Controls.Add(panel);
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            StaffPanel panel = new StaffPanel();
            panelMain.Controls.Clear();
            
            panelMain.Controls.Add(panel);
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            StatsPanel panel = new StatsPanel();
            panelMain.Controls.Clear();
            
            panelMain.Controls.Add(panel);
        }

       
    }
}
