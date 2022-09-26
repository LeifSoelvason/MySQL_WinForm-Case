namespace DriversLog
{
    partial class User
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Firstname1 = new System.Windows.Forms.TextBox();
            this.txt_Lastname1 = new System.Windows.Forms.TextBox();
            this.txt_Licenseplatenumber1 = new System.Windows.Forms.TextBox();
            this.txt_Lastname3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UserID1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Firstname2 = new System.Windows.Forms.TextBox();
            this.txt_Lastname2 = new System.Windows.Forms.TextBox();
            this.txt_Licenseplatenumber2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UserID2 = new System.Windows.Forms.TextBox();
            this.btn_ListAll = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 175);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Licenseplate number";
            // 
            // txt_Firstname1
            // 
            this.txt_Firstname1.Location = new System.Drawing.Point(157, 17);
            this.txt_Firstname1.Name = "txt_Firstname1";
            this.txt_Firstname1.Size = new System.Drawing.Size(134, 20);
            this.txt_Firstname1.TabIndex = 0;
            // 
            // txt_Lastname1
            // 
            this.txt_Lastname1.Location = new System.Drawing.Point(157, 46);
            this.txt_Lastname1.Name = "txt_Lastname1";
            this.txt_Lastname1.Size = new System.Drawing.Size(134, 20);
            this.txt_Lastname1.TabIndex = 1;
            // 
            // txt_Licenseplatenumber1
            // 
            this.txt_Licenseplatenumber1.Location = new System.Drawing.Point(157, 75);
            this.txt_Licenseplatenumber1.Name = "txt_Licenseplatenumber1";
            this.txt_Licenseplatenumber1.Size = new System.Drawing.Size(134, 20);
            this.txt_Licenseplatenumber1.TabIndex = 2;
            // 
            // txt_Lastname3
            // 
            this.txt_Lastname3.Location = new System.Drawing.Point(494, 235);
            this.txt_Lastname3.Name = "txt_Lastname3";
            this.txt_Lastname3.Size = new System.Drawing.Size(150, 20);
            this.txt_Lastname3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lastname";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(656, 228);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(69, 33);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(222, 103);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(69, 33);
            this.btn_Insert.TabIndex = 3;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(547, 136);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(69, 33);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(826, 51);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 33);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "UserID";
            // 
            // txt_UserID1
            // 
            this.txt_UserID1.Location = new System.Drawing.Point(490, 20);
            this.txt_UserID1.Name = "txt_UserID1";
            this.txt_UserID1.Size = new System.Drawing.Size(126, 20);
            this.txt_UserID1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Firstname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lastname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Licenseplate number";
            // 
            // txt_Firstname2
            // 
            this.txt_Firstname2.Location = new System.Drawing.Point(490, 48);
            this.txt_Firstname2.Name = "txt_Firstname2";
            this.txt_Firstname2.Size = new System.Drawing.Size(126, 20);
            this.txt_Firstname2.TabIndex = 5;
            // 
            // txt_Lastname2
            // 
            this.txt_Lastname2.Location = new System.Drawing.Point(490, 79);
            this.txt_Lastname2.Name = "txt_Lastname2";
            this.txt_Lastname2.Size = new System.Drawing.Size(126, 20);
            this.txt_Lastname2.TabIndex = 6;
            // 
            // txt_Licenseplatenumber2
            // 
            this.txt_Licenseplatenumber2.Location = new System.Drawing.Point(490, 110);
            this.txt_Licenseplatenumber2.Name = "txt_Licenseplatenumber2";
            this.txt_Licenseplatenumber2.Size = new System.Drawing.Size(126, 20);
            this.txt_Licenseplatenumber2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(714, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "UserID";
            // 
            // txt_UserID2
            // 
            this.txt_UserID2.Location = new System.Drawing.Point(769, 20);
            this.txt_UserID2.Name = "txt_UserID2";
            this.txt_UserID2.Size = new System.Drawing.Size(126, 20);
            this.txt_UserID2.TabIndex = 9;
            // 
            // btn_ListAll
            // 
            this.btn_ListAll.Location = new System.Drawing.Point(656, 263);
            this.btn_ListAll.Name = "btn_ListAll";
            this.btn_ListAll.Size = new System.Drawing.Size(69, 33);
            this.btn_ListAll.TabIndex = 13;
            this.btn_ListAll.Text = "List All";
            this.btn_ListAll.UseVisualStyleBackColor = true;
            this.btn_ListAll.Click += new System.EventHandler(this.btn_ListAll_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(808, 392);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(87, 29);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(921, 443);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_ListAll);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Lastname3);
            this.Controls.Add(this.txt_Licenseplatenumber2);
            this.Controls.Add(this.txt_Licenseplatenumber1);
            this.Controls.Add(this.txt_Lastname2);
            this.Controls.Add(this.txt_Lastname1);
            this.Controls.Add(this.txt_UserID2);
            this.Controls.Add(this.txt_UserID1);
            this.Controls.Add(this.txt_Firstname2);
            this.Controls.Add(this.txt_Firstname1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Firstname1;
        private System.Windows.Forms.TextBox txt_Lastname1;
        private System.Windows.Forms.TextBox txt_Licenseplatenumber1;
        private System.Windows.Forms.TextBox txt_Lastname3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UserID1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Firstname2;
        private System.Windows.Forms.TextBox txt_Lastname2;
        private System.Windows.Forms.TextBox txt_Licenseplatenumber2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UserID2;
        private System.Windows.Forms.Button btn_ListAll;
        private System.Windows.Forms.Button btn_Close;
    }
}