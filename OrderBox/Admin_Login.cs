using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderBox
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_info.Text += 1.ToString();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_info.Text += 2.ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_info.Text += 3.ToString();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_info.Text += 4.ToString();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_info.Text += 5.ToString();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_info.Text += 6.ToString();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_info.Text += 7.ToString();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            txt_info.Text += 8.ToString();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_info.Text += 9.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_info.Text += "*".ToString();
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            txt_info.Text += 0.ToString();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            txt_info.Text = txt_info.Text.Substring(0, txt_info.Text.Length - 1);
        }

        private void btn_後台_Click(object sender, EventArgs e)
        {
            if (txt_info.Text == "123")
            {
                Admin_Manage adminOpen = new Admin_Manage();

                adminOpen.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤");
            }
        }
    }
}
