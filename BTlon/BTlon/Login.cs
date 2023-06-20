using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTlon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int soLan = 3;
        bool co = true;
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!co)
            {
                Application.Exit();
            }
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "" || txtMatKhau.Text != "1234567")
            {
                MessageBox.Show("Sai thông tin đăng nhập");

                // Nhập quá 3 lần -> thoát 
                soLan--;
                co = false;
                if (soLan == 0)
                {
                    Application.Exit();
                }
            }
            else
            {
                GiaoDien.tenDN = txtDangNhap.Text;
                this.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
