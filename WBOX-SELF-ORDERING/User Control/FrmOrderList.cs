using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBOX_SELF_ORDERING.User_Control
{
    public partial class FrmOrderList : Form
    {
        public FrmOrderList()
        {
            InitializeComponent();
        }

        private void btnAddmore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            FrmPayment frmPayment = new FrmPayment();
            frmPayment.Show();

            //FrmMainMenu frmmenu = new FrmMainMenu();
            //frmmenu.Close();
            
        }
    }
}
