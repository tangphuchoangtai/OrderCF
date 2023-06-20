using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTlon
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if (txtTen.Text != "")
            {
                item = new ListViewItem(txtTen.Text);
                item.SubItems.Add(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
                item.SubItems.Add(txtSDT.Text);

                lvNhanVien.Items.Add(item);
                txtTen.Text = "";
                txtTen.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lvNhanVien.SelectedItems[0].SubItems[0].Text = txtTen.Text;
            lvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            lvNhanVien.SelectedItems[0].SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
            lvNhanVien.SelectedItems[0].SubItems[3].Text = txtSDT.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
           
            
                if (lvNhanVien.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvNhanVien.SelectedItems)
                    {
                        lvNhanVien.Items.Remove(item);
                    }
                }
            
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                txtTen.Text = lvNhanVien.SelectedItems[0].SubItems[0].Text;
                //dtpNgaySinh.Text = lvNhanVien.SelectedItems[0].SubItems[1].Text;
                gioiTinh = lvNhanVien.SelectedItems[0].SubItems[2].Text;
                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                    radNu.Checked = true;
                txtSDT.Text = lvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }

      

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            lvNhanVien.Columns[0].Width = (int)(lvNhanVien.Width * 0.25);
            lvNhanVien.Columns[1].Width = (int)(lvNhanVien.Width * 0.25);
            lvNhanVien.Columns[2].Width = (int)(lvNhanVien.Width * 0.25);
            lvNhanVien.Columns[3].Width = (int)(lvNhanVien.Width * 0.25);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Bạn Chưa Lựa chọn thông tin để sửa");
            }
            else
            {
                lvNhanVien.SelectedItems[0].SubItems[0].Text = txtTen.Text;
                lvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                lvNhanVien.SelectedItems[0].SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
                lvNhanVien.SelectedItems[0].SubItems[3].Text = txtSDT.Text;
            }
        }

        private void lvNhanVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                txtTen.Text = lvNhanVien.SelectedItems[0].SubItems[0].Text;
                //dtpNgaySinh.Text = lvNhanVien.SelectedItems[0].SubItems[1].Text;
                gioiTinh = lvNhanVien.SelectedItems[0].SubItems[2].Text;
                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                    radNu.Checked = true;
                txtSDT.Text = lvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSDT.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtSDT.Text = "";
            }
        }
    }
}
