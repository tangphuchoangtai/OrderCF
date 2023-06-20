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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            Login login = new Login();
            login.ShowDialog();
            InitializeComponent();
        }

        private Form currentFromChild;

        public static string tenDN = "";

        private void OpenChildForm(Form childForm)// chuyền 1 biến số vào
        {
            if (currentFromChild != null) // Nếu đã khởi tạo r thì đóng vào
            {
                currentFromChild.Close();
            }
            currentFromChild = childForm;
            childForm.TopLevel = false;     
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;// truyền dữ liệu
            childForm.BringToFront(); // mang nó về đằng trước nhưng vẫn chưa thực hiện.
            childForm.Show();

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThanhToan());
            lbHome.Text = btThanhToan.Text;
        }
         
        private void pbQuayLai_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null) // Nếu đã khởi tạo r thì đóng vào
            {
                currentFromChild.Close();
                lbHome.Text = "WELCOME";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
            lbHome.Text = btQuanLi.Text;
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOders_Click(object sender, EventArgs e)
        {
            OpenChildForm(childForm: new Oders());
            lbHome.Text = btOders.Text;
        }
    }
}
