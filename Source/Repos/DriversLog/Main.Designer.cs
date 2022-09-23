namespace DriversLog
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_UserMenu = new System.Windows.Forms.Button();
            this.btn_DriversLog_Menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UserMenu
            // 
            this.btn_UserMenu.Location = new System.Drawing.Point(12, 40);
            this.btn_UserMenu.Name = "btn_UserMenu";
            this.btn_UserMenu.Size = new System.Drawing.Size(109, 52);
            this.btn_UserMenu.TabIndex = 0;
            this.btn_UserMenu.Text = "User Menu";
            this.btn_UserMenu.UseVisualStyleBackColor = true;
            this.btn_UserMenu.Click += new System.EventHandler(this.btn_UserMenu_Click);
            // 
            // btn_DriversLog_Menu
            // 
            this.btn_DriversLog_Menu.Location = new System.Drawing.Point(12, 98);
            this.btn_DriversLog_Menu.Name = "btn_DriversLog_Menu";
            this.btn_DriversLog_Menu.Size = new System.Drawing.Size(109, 52);
            this.btn_DriversLog_Menu.TabIndex = 0;
            this.btn_DriversLog_Menu.Text = "Order Menu";
            this.btn_DriversLog_Menu.UseVisualStyleBackColor = true;
            this.btn_DriversLog_Menu.Click += new System.EventHandler(this.btn_DriversLog_Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(673, 455);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(92, 37);
            this.btn_.TabIndex = 2;
            this.btn_.Text = "Exit";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DriversLog_Menu);
            this.Controls.Add(this.btn_UserMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UserMenu;
        private System.Windows.Forms.Button btn_DriversLog_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_;
    }
}