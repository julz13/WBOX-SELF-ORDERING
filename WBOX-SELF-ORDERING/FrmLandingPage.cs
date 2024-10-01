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
    public partial class FrmLandingPage : Form
    {
        public FrmLandingPage()
        {
            InitializeComponent();
        }

        private void FrmLandingPage_Load(object sender, EventArgs e)
        {
            //// Set the desired width and height for the form
            //int desiredWidth = 1440;
            //int desiredHeight = 900;

            //// Calculate the new size and position for the form based on the desired dimensions
            //int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            //int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            //int newX = (screenWidth - desiredWidth) / 2; // Calculate the new X position
            //int newY = (screenHeight - desiredHeight) / 2; // Calculate the new Y position

            //// Set the new size and position for the form
            //this.Size = new System.Drawing.Size(desiredWidth, desiredHeight);
            //this.Location = new System.Drawing.Point(newX, newY);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmDineLoc frmDineLoc = new FrmDineLoc();
            frmDineLoc.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e) {
            FrmDineLoc frmDineLoc = new FrmDineLoc();
            frmDineLoc.Show();
            this.Hide();
        }

        private void FrmLandingPage_KeyDown(object sender, KeyEventArgs e) {

        }

        private void FrmLandingPage_KeyUp(object sender, KeyEventArgs e) {

        }
    }
}
