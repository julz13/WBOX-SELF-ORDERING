using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WBOX_SELF_ORDERING.Models;

namespace WBOX_SELF_ORDERING
{
    public partial class FrmDineLoc : Form
    {
        public FrmDineLoc()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            FrmLandingPage frmstart = new FrmLandingPage();
            frmstart.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e) {
            GlobalVar.Location = "Take-out";
            FrmMainMenu frmMenu = new FrmMainMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnDinein_Click(object sender, EventArgs e) {
            GlobalVar.Location = "Dine in";
            FrmMainMenu frmMenu = new FrmMainMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
