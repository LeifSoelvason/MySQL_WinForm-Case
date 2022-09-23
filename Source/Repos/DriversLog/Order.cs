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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        void Clear()
        {
           txt_UserID.Text = txt_Km.Text = txt_Licenseplatenumber.Text = txt_Search.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess_Order db = new DataAccess_Order();
            var output = db.GetOrderByUserID(txt_Search.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataAccess_Order db = new DataAccess_Order();
            var output = db.Add_New_Order(txt_UserID.Text, txt_Km.Text, txt_Licenseplatenumber.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
