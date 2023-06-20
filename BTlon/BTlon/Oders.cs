using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTlon
{
    public partial class Oders : Form
    {
        public Oders()
        {
            InitializeComponent();
        }

        #region Biến Toàn Cục
        int[] mangGia = { 20000, 25000, 27000, 30000, 25000, 27000, 15000, 35000, 45000, 40000 };
        string[] ban = new string[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4", "Bàn 5", "Bàn 6" , "Bàn 7", "Bàn 8", "Bàn 9", "Bàn 10" };
        DataTable tbOder; 
        #endregion
        private void TinhTienQuanCaPhe_Load(object sender, EventArgs e)
        {
            tbOder = new DataTable();
            // xuất hiện giá của từng món.
            lbTraDao.Text = String.Format("{0:N}", mangGia[0]);//String format la dung de lam dau phay
            lbCaPheD.Text = String.Format("{0:N}", mangGia[1]);
            lbCaPheS.Text = String.Format("{0:N}", mangGia[2]);
            lbCaPheT.Text = String.Format("{0:N}", mangGia[3]);
            lbTS.Text = String.Format("{0:N}", mangGia[4]);
            lbBacXiu.Text = String.Format("{0:N}", mangGia[5]);
            lbBF.Text = String.Format("{0:N}", mangGia[6]);
            lbKemDua.Text = String.Format("{0:N}", mangGia[7]);
            lbPho.Text = String.Format("{0:N}", mangGia[8]);
            lbHuTieu.Text = String.Format("{0:N}", mangGia[9]);

            cbbBan.Items.AddRange(ban);

            //tạo 3 cột ở bảng
            tbOder.Columns.Add("Bàn Số");
            tbOder.Columns.Add("Tên Món");
            tbOder.Columns.Add("Số Lượng");

            //thêm vào dtG
            gvOder.DataSource = tbOder;
            //đinh dạng 3 bản
            gvOder.Columns[0].Width = (int)(gvOder.Width * 0.33);
            gvOder.Columns[1].Width = (int)(gvOder.Width * 0.33);
            gvOder.Columns[2].Width = (int)(gvOder.Width * 0.33);

        }

        private void cbbBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbBan.SelectedItem.ToString());
        }


        private void btXoa_Click(object sender, EventArgs e)
        {
            tbOder.Rows.Clear();
        }

        private void btOder_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;

            string file = ""; // khai báo tên file

            //chọn file lưu
            saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // nếu có file
            {
                file = saveFileDialog.FileName;  
            }    
            else
            {
                file = @"D:\GoiMon.txt"; //( nếu ko có)
            }

            //Lưu
            if (File.Exists(file)) // nếu có r thì thoát
            {
                streamWriter = new StreamWriter(file);
                // thêm tiêu đề vô file
                streamWriter.WriteLine( String.Format("{0,-10}", gvOder.Columns[0].HeaderText)
                    + String.Format("{0,-50}", gvOder.Columns[1].HeaderText)
                    + String.Format("{0,-20}", gvOder.Columns[2].HeaderText));

                for (int i = 0; i < gvOder.Rows.Count - 1; i++) // đi từ 0 đến dòng cuối
                {
                    streamWriter.WriteLine(String.Format("{0,-10}", gvOder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-50}", gvOder.Rows[i].Cells[1].Value)
                    + String.Format("{0,-20}", gvOder.Rows[i].Cells[2].Value));
                    //---

                }
                streamWriter.Close();// phải đóng nó sẽ ghi tiếp . 
            }
            else
            {
                streamWriter = File.AppendText(file);// Nếu 0 có thì tạo. 
                for (int i = 0; i < gvOder.Rows.Count - 1; i++) // đi từ 0 đến dòng cuối
                {
                    streamWriter.WriteLine(String.Format("{0,-10}", gvOder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-50}", gvOder.Rows[i].Cells[1].Value)
                    + String.Format("{0,-20}", gvOder.Rows[i].Cells[2].Value));
                }
                streamWriter.Close();
            }    

        }

       
        private void btTraDao_Click(object sender, EventArgs e)
        {
            DataRow row; // Thêm 1 dòng mới
            bool kt = true; //ktr nếu đúng
            Button b = (Button)sender;
            row = tbOder.NewRow(); // tạo 1 dòng mới

            foreach (DataRow items in tbOder.Rows) // Duyệt từng dòng trong Datatable 
            {
                if (items[1].ToString() == b.Text)
                {
                    kt = false;
                    // nếu có sẽ tăng số lượng , ko xuất hiện thêm dòng.
                    items[2] = int.Parse(items[2].ToString()) + 1;
                    break;
                }

            }

            // nếu duyệt hết mà không có thì ta sẽ thêm 1 dòng mới.
            if (kt)// nếu chưa có
            {
                row[0] = cbbBan.Text;//gán gtri
                row[1] = b.Text;
                row[2] = 1;

                tbOder.Rows.Add(row);//thêm 1 dòng mới 
            }

        }
    }
}
