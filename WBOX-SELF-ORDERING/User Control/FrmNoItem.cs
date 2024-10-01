using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBOX_SELF_ORDERING.User_Control {
    public partial class FrmNoItem : Form {
        public FrmNoItem() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
