using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMALauncher_V3._0.Forms;

namespace VMALauncher_V3._0
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void smach_Click(object sender, EventArgs e)
        {
            St_Machines stmach = new St_Machines();
            stmach.Show();
        }

        private void pmach_Click(object sender, EventArgs e)
        {
            Pr_Machines prmach = new Pr_Machines();
            prmach.Show();
        }
    }
}
