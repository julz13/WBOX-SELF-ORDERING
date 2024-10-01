namespace WBOX_SELF_ORDERING
{
    partial class FrmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucLogo1 = new WBOX_SELF_ORDERING.User_Control.ucLogo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new AP4_2.RJControls.RJButton();
            this.btnOTC = new AP4_2.RJControls.RJButton();
            this.btnOnline = new AP4_2.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(51, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 828);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnOTC);
            this.panel2.Controls.Add(this.btnOnline);
            this.panel2.Location = new System.Drawing.Point(4, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 421);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ucLogo1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 453);
            this.panel3.TabIndex = 5;
            // 
            // ucLogo1
            // 
            this.ucLogo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucLogo1.BackColor = System.Drawing.Color.Transparent;
            this.ucLogo1.Location = new System.Drawing.Point(343, 79);
            this.ucLogo1.Name = "ucLogo1";
            this.ucLogo1.Size = new System.Drawing.Size(255, 255);
            this.ucLogo1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(940, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.BorderRadius = 20;
            this.btnBack.BorderSize = 2;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::WBOX_SELF_ORDERING.Properties.Resources._1486348526_arrow_back_backwards_repeat_previous_80453;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(64, 760);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 65);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOTC
            // 
            this.btnOTC.BackColor = System.Drawing.Color.Crimson;
            this.btnOTC.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnOTC.BorderColor = System.Drawing.Color.Empty;
            this.btnOTC.BorderRadius = 30;
            this.btnOTC.BorderSize = 2;
            this.btnOTC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOTC.FlatAppearance.BorderSize = 0;
            this.btnOTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnOTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTC.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTC.ForeColor = System.Drawing.Color.Black;
            this.btnOTC.Image = global::WBOX_SELF_ORDERING.Properties.Resources.shopping;
            this.btnOTC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOTC.Location = new System.Drawing.Point(42, 40);
            this.btnOTC.Name = "btnOTC";
            this.btnOTC.Padding = new System.Windows.Forms.Padding(10);
            this.btnOTC.Size = new System.Drawing.Size(340, 340);
            this.btnOTC.TabIndex = 6;
            this.btnOTC.Text = "Over the Counter";
            this.btnOTC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOTC.TextColor = System.Drawing.Color.Black;
            this.btnOTC.UseVisualStyleBackColor = false;
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.Crimson;
            this.btnOnline.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnOnline.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOnline.BorderRadius = 20;
            this.btnOnline.BorderSize = 0;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.Black;
            this.btnOnline.Image = global::WBOX_SELF_ORDERING.Properties.Resources.mobile;
            this.btnOnline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOnline.Location = new System.Drawing.Point(449, 40);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Padding = new System.Windows.Forms.Padding(10);
            this.btnOnline.Size = new System.Drawing.Size(340, 340);
            this.btnOnline.TabIndex = 5;
            this.btnOnline.Text = "Online Payment";
            this.btnOnline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnline.TextColor = System.Drawing.Color.Black;
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(940, 920);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private AP4_2.RJControls.RJButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private AP4_2.RJControls.RJButton btnOTC;
        private AP4_2.RJControls.RJButton btnOnline;
        private System.Windows.Forms.Panel panel3;
        private User_Control.ucLogo ucLogo1;
        private System.Windows.Forms.Label label1;
    }
}