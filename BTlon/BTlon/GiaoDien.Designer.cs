namespace BTlon
{
    partial class GiaoDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btOut = new System.Windows.Forms.Button();
            this.btQuanLi = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btOders = new System.Windows.Forms.Button();
            this.pbQuayLai = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbHome = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuayLai)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_Left.Controls.Add(this.btOut);
            this.panel_Left.Controls.Add(this.btQuanLi);
            this.panel_Left.Controls.Add(this.btThanhToan);
            this.panel_Left.Controls.Add(this.btOders);
            this.panel_Left.Controls.Add(this.pbQuayLai);
            this.panel_Left.Controls.Add(this.panel1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(221, 643);
            this.panel_Left.TabIndex = 0;
            // 
            // btOut
            // 
            this.btOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btOut.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.Location = new System.Drawing.Point(37, 500);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(130, 41);
            this.btOut.TabIndex = 4;
            this.btOut.Text = "Thoát";
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btQuanLi
            // 
            this.btQuanLi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuanLi.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLi.Location = new System.Drawing.Point(0, 314);
            this.btQuanLi.Name = "btQuanLi";
            this.btQuanLi.Size = new System.Drawing.Size(221, 47);
            this.btQuanLi.TabIndex = 3;
            this.btQuanLi.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btQuanLi.UseVisualStyleBackColor = false;
            this.btQuanLi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btThanhToan.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.Location = new System.Drawing.Point(-3, 248);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(224, 47);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.Text = "THANH TOÁN";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btOders
            // 
            this.btOders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btOders.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOders.Location = new System.Drawing.Point(0, 182);
            this.btOders.Name = "btOders";
            this.btOders.Size = new System.Drawing.Size(221, 47);
            this.btOders.TabIndex = 3;
            this.btOders.Text = "GỌI MÓN";
            this.btOders.UseVisualStyleBackColor = false;
            this.btOders.Click += new System.EventHandler(this.btOders_Click);
            // 
            // pbQuayLai
            // 
            this.pbQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("pbQuayLai.Image")));
            this.pbQuayLai.Location = new System.Drawing.Point(0, 3);
            this.pbQuayLai.Name = "pbQuayLai";
            this.pbQuayLai.Size = new System.Drawing.Size(221, 99);
            this.pbQuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuayLai.TabIndex = 2;
            this.pbQuayLai.TabStop = false;
            this.pbQuayLai.Click += new System.EventHandler(this.pbQuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(219, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 128);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lbHome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(221, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1053, 93);
            this.panel4.TabIndex = 1;
            // 
            // lbHome
            // 
            this.lbHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHome.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.Location = new System.Drawing.Point(0, 0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(1053, 90);
            this.lbHome.TabIndex = 0;
            this.lbHome.Text = "WELCOME";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_body.Controls.Add(this.pictureBox1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(221, 93);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1053, 550);
            this.panel_body.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 643);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_Left);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GiaoDien";
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuayLai)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button btQuanLi;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btOders;
        private System.Windows.Forms.PictureBox pbQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btOut;
    }
}