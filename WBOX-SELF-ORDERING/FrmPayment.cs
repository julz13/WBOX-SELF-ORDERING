using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBOX_SELF_ORDERING
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }

        private void btnOnline_Click(object sender, EventArgs e) {
            FrmThankYou frmThankYou = new FrmThankYou();
            frmThankYou.Show();
            this.Hide();
        }
    }
}
