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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        #region Biến Toàn Cục
        int[] mangGia = { 20000, 25000, 27000, 30000, 25000, 27000 ,15000,35000 , 45000,40000 };
        #endregion

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int a = int.Parse(tbTraDao.Text) * mangGia[0];
            //    int b = int.Parse(tbSLCFD.Text) * mangGia[1];
            //    int c = int.Parse(tbCFS.Text) * mangGia[2];
            //    int d = int.Parse(tbCFT.Text) * mangGia[3];
            //    int v = int.Parse(tbS.Text) * mangGia[4];
            //    int f = int.Parse(tbBacXiu.Text) * mangGia[5];
            //    int g = int.Parse(txtBF.Text) * mangGia[6];
            //    int h = int.Parse(txtKemDua.Text) * mangGia[7];
            //    int j = int.Parse(txtPho.Text) * mangGia[8];
            //    int n = int.Parse(txtHuTieu.Text) * mangGia[9];
            //    txtTongTien.Text = String.Format("{0:N}", a + b + c + d + v + f + g + h + j + n);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            if (tbTraDao.Text == "" || tbSLCFD.Text == "" || tbCFS.Text == "")
            {
                MessageBox.Show("Phai nhap so luong");
            }
            else
            {
                int a = int.Parse(tbTraDao.Text) * mangGia[0];
                int b = int.Parse(tbSLCFD.Text) * mangGia[1];
                int c = int.Parse(tbCFS.Text) * mangGia[2];
                int d = int.Parse(tbCFT.Text) * mangGia[3];
                int v = int.Parse(tbS.Text) * mangGia[4];
                int f = int.Parse(tbBacXiu.Text) * mangGia[5];
                int g = int.Parse(txtBF.Text) * mangGia[6];
                int h = int.Parse(txtKemDua.Text) * mangGia[7];
                int j = int.Parse(txtPho.Text) * mangGia[8];
                int n = int.Parse(txtHuTieu.Text) * mangGia[9];
                lbTongTien.Text = String.Format("{0:N}", a + b + c + d + v + f + g + h + j + n);
            }

        }

        private void Oder_Load(object sender, EventArgs e)
        {
            // xuất hiện giá của từng món.
            lbTraDao.Text = String.Format("{0:N}", mangGia[0]);//String format la dung de lam dau phay
            lbCaPheD.Text = String.Format("{0:N}", mangGia[1]);
            lbCaPheS.Text = String.Format("{0:N}", mangGia[2]);
            lbCaPheT.Text = String.Format("{0:N}", mangGia[3]);
            lbTS.Text = String.Format("{0:N}", mangGia[4]);
            lbBacXiu.Text = String.Format("{0:N}", mangGia[5]);
            lbBF.Text= String.Format("{0:N}", mangGia[6]);
            lbKemDua.Text= String.Format("{0:N}", mangGia[7]);
            lbPho.Text= String.Format("{0:N}", mangGia[8]);
            lbHuTieu.Text = String.Format("{0:N}", mangGia[9]);

        }

        
    }
}
