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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
            lblDineLoc.Text = GlobalVar.Location;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (gridList.Rows.Count == 0) {
                GlobalVar.NoitemClear();
            }
            else {
                GlobalVar.ModalClearAll();
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            GlobalVar.DisplayOrders();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            FrmDineLoc frmDineLoc = new FrmDineLoc();
            frmDineLoc.ShowDialog();
            this.Hide();
        }
    }
}
