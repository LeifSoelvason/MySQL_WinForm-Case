using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace DriversLog
{
    public partial class User : Form
    {
        
        public User()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txt_Firstname1.Text = txt_Firstname2.Text = txt_Lastname1.Text = txt_Lastname2.Text = txt_Lastname3.Text = txt_Licenseplatenumber1.Text = txt_Licenseplatenumber2.Text = txt_UserID1.Text = txt_UserID2.Text = "";

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataAccess_User db = new DataAccess_User();

            var output = db.GetUsersByLastname(txt_Lastname3.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            DataAccess_User db = new DataAccess_User();

            var output = db.Add_New_User(txt_Firstname1.Text,txt_Lastname1.Text,txt_Licenseplatenumber1.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataAccess_User db = new DataAccess_User();

            var output = db.Update(txt_UserID1.Text, txt_Firstname2.Text, txt_Lastname2.Text, txt_Licenseplatenumber2.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataAccess_User db = new DataAccess_User();

            var output = db.Delete(txt_UserID2.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_ListAll_Click(object sender, EventArgs e)
        {
            DataAccess_User db = new DataAccess_User();

            var output = db.GetUserList(txt_UserID2.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
