using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace DriversLog
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataAccess_User db = new DataAccess_User();

            var output = db.PasswordValidation(txt_UserName.Text, txt_Password.Text);          

            if (output.Count == 1)
            {
                this.Hide();
                Main x = new Main();
                x.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect. Try again");
            }
        }

        private void btn_CLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
