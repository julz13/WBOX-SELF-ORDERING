namespace WBOX_SELF_ORDERING
{
    partial class FrmDineLoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucLogo1 = new WBOX_SELF_ORDERING.User_Control.ucLogo();
            this.btnBack = new AP4_2.RJControls.RJButton();
            this.btnDinein = new AP4_2.RJControls.RJButton();
            this.btnTakeout = new AP4_2.RJControls.RJButton();
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
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnDinein);
            this.panel2.Controls.Add(this.btnTakeout);
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
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(940, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnDinein
            // 
            this.btnDinein.BackColor = System.Drawing.Color.Crimson;
            this.btnDinein.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDinein.BorderColor = System.Drawing.Color.Empty;
            this.btnDinein.BorderRadius = 30;
            this.btnDinein.BorderSize = 2;
            this.btnDinein.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDinein.FlatAppearance.BorderSize = 0;
            this.btnDinein.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDinein.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDinein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinein.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinein.ForeColor = System.Drawing.Color.Black;
            this.btnDinein.Image = global::WBOX_SELF_ORDERING.Properties.Resources.restaurant_tablecloth_cutlery_spoon_fork_icon_196752;
            this.btnDinein.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDinein.Location = new System.Drawing.Point(42, 40);
            this.btnDinein.Name = "btnDinein";
            this.btnDinein.Padding = new System.Windows.Forms.Padding(10);
            this.btnDinein.Size = new System.Drawing.Size(340, 340);
            this.btnDinein.TabIndex = 6;
            this.btnDinein.Text = "Dine in";
            this.btnDinein.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDinein.TextColor = System.Drawing.Color.Black;
            this.btnDinein.UseVisualStyleBackColor = false;
            this.btnDinein.Click += new System.EventHandler(this.btnDinein_Click);
            // 
            // btnTakeout
            // 
            this.btnTakeout.BackColor = System.Drawing.Color.Crimson;
            this.btnTakeout.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnTakeout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTakeout.BorderRadius = 20;
            this.btnTakeout.BorderSize = 0;
            this.btnTakeout.FlatAppearance.BorderSize = 0;
            this.btnTakeout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnTakeout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTakeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeout.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeout.ForeColor = System.Drawing.Color.Black;
            this.btnTakeout.Image = global::WBOX_SELF_ORDERING.Properties.Resources.take_away_food_cup_paper_bag_drink_coffee_icon_210212;
            this.btnTakeout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTakeout.Location = new System.Drawing.Point(449, 40);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Padding = new System.Windows.Forms.Padding(10);
            this.btnTakeout.Size = new System.Drawing.Size(340, 340);
            this.btnTakeout.TabIndex = 5;
            this.btnTakeout.Text = "Take-out";
            this.btnTakeout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTakeout.TextColor = System.Drawing.Color.Black;
            this.btnTakeout.UseVisualStyleBackColor = false;
            this.btnTakeout.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // FrmDineLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(940, 920);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDineLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDineLoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AP4_2.RJControls.RJButton btnDinein;
        private AP4_2.RJControls.RJButton btnTakeout;
        private AP4_2.RJControls.RJButton btnBack;
        private System.Windows.Forms.Panel panel3;
        private User_Control.ucLogo ucLogo1;
        private System.Windows.Forms.Label label1;
    }
}