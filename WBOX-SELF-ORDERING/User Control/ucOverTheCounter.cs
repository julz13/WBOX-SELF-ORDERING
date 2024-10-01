using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBOX_SELF_ORDERING.User_Control
{
    public partial class ucOverTheCounter : UserControl
    {
        public ucOverTheCounter()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Create a rounded rectangle region based on the control's size
            GraphicsPath roundedPath = new GraphicsPath();
            int radius = 90; // Adjust the radius value to change the roundness

            roundedPath.AddArc(0, 0, radius, radius, 180, 90);
            roundedPath.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            roundedPath.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            roundedPath.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            roundedPath.CloseFigure();

            // Set the region of the control to the rounded rectangle
            this.Region = new Region(roundedPath);

            // Draw a border along the edges of the control
            int borderWidth = 5; // Adjust the border width as needed
            using (Pen borderPen = new Pen(Color.DimGray, borderWidth))
            {
                g.DrawPath(borderPen, roundedPath);
            }

            // Draw a shadow around the control
            int shadowSize = 10; // Adjust the shadow size as needed
            Color shadowColor = Color.FromArgb(50, Color.Black); // Adjust the shadow color and opacity as needed
            using (GraphicsPath shadowPath = new GraphicsPath())
            using (Pen shadowPen = new Pen(shadowColor, shadowSize))
            {
                shadowPath.AddArc(-shadowSize, -shadowSize, this.Width + shadowSize * 2, this.Height + shadowSize * 2, 180, 90);
                shadowPath.AddArc(this.Width - radius, -shadowSize, radius + shadowSize, radius + shadowSize, 270, 90);
                shadowPath.AddArc(this.Width - radius, this.Height - radius, radius + shadowSize, radius + shadowSize, 0, 90);
                shadowPath.AddArc(-shadowSize, this.Height - radius, radius + shadowSize, radius + shadowSize, 90, 90);
                shadowPath.CloseFigure();

                g.DrawPath(shadowPen, shadowPath);
            }
        }
    }
}
