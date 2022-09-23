using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversLog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_UserMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            User x = new User();
            x.Show();
        }

        private void btn__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DriversLog_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order x = new Order();
            x.Show();
        }
    }
}
