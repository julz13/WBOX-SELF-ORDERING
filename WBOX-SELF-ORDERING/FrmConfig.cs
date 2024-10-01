using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WBOX_SELF_ORDERING.Helpers;
using WBOX_SELF_ORDERING.Models;

namespace WBOX_SELF_ORDERING
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            GlobalVar.InitializeConfiguration();
            txtServer.Text = GlobalVar.Server;
            txtDatabase.Text = GlobalVar.Database;
            txtUsername.Text = GlobalVar.Username;
            txtPassword.Text = GlobalVar.Password;
            txtRequest.Text = GlobalVar.Request;
            txtWData.Text = GlobalVar.Data;
            txtPass.Text = GlobalVar.wPass;
        }

        public Configuration SystemConfiguration
        {
            get
            {
                return new Configuration() {
                    server = txtServer.Text.Trim().ToString(),
                    database = txtDatabase.Text.Trim().ToString(),
                    username = txtUsername.Text.Trim().ToString(),
                    password = txtPassword.Text.Trim().ToString(),
                    Request = txtRequest.Text.Trim().ToString(),
                    WBOX = txtWData.Text.Trim().ToString(),
                    Wpass = txtPass.Text.Trim().ToString()
                };
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            GlobalVar._settings.Save<Configuration>(SystemConfiguration, "Configuration");
            MessageBox.Show(String.Format("{0}", "Settings Saved! \n\nApplication needs to reset .."));
            //this.Close();
            Application.Restart();
        }
    }
}
