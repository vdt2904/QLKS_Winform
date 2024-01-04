namespace BTL
{
    partial class frmPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbCCCD = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbbMKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTTKH = new System.Windows.Forms.DataGridView();
            this.labKhuyenMai = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labDVSD = new System.Windows.Forms.Label();
            this.labTienDV = new System.Windows.Forms.Label();
            this.labNgayO = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSDDV = new System.Windows.Forms.Button();
            this.labTongTien = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.labNgayTT = new System.Windows.Forms.Label();
            this.labSoPhong = new System.Windows.Forms.Label();
            this.labTenKH = new System.Windows.Forms.Label();
            this.labMaKH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cbbCCCD);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.cbbMKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(439, 49);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 34);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbCCCD
            // 
            this.cbbCCCD.FormattingEnabled = true;
            this.cbbCCCD.Location = new System.Drawing.Point(150, 85);
            this.cbbCCCD.Name = "cbbCCCD";
            this.cbbCCCD.Size = new System.Drawing.Size(136, 21);
            this.cbbCCCD.TabIndex = 7;
            this.cbbCCCD.SelectedIndexChanged += new System.EventHandler(this.cbbCCCD_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Mã Khách Hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(150, 55);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(136, 20);
            this.txtTenKH.TabIndex = 5;
            // 
            // cbbMKH
            // 
            this.cbbMKH.FormattingEnabled = true;
            this.cbbMKH.Location = new System.Drawing.Point(150, 25);
            this.cbbMKH.Name = "cbbMKH";
            this.cbbMKH.Size = new System.Drawing.Size(136, 21);
            this.cbbMKH.TabIndex = 2;
            this.cbbMKH.SelectedIndexChanged += new System.EventHandler(this.cbbMKH_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CCCD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh Toán";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvTTKH);
            this.groupBox2.Controls.Add(this.labKhuyenMai);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.labDVSD);
            this.groupBox2.Controls.Add(this.labTienDV);
            this.groupBox2.Controls.Add(this.labNgayO);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnSDDV);
            this.groupBox2.Controls.Add(this.labTongTien);
            this.groupBox2.Controls.Add(this.a);
            this.groupBox2.Controls.Add(this.labNgayTT);
            this.groupBox2.Controls.Add(this.labSoPhong);
            this.groupBox2.Controls.Add(this.labTenKH);
            this.groupBox2.Controls.Add(this.labMaKH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(25, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 405);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán:";
            // 
            // dgvTTKH
            // 
            this.dgvTTKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTKH.Location = new System.Drawing.Point(6, 169);
            this.dgvTTKH.Name = "dgvTTKH";
            this.dgvTTKH.Size = new System.Drawing.Size(568, 150);
            this.dgvTTKH.TabIndex = 22;
            this.dgvTTKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTKH_CellClick);
            // 
            // labKhuyenMai
            // 
            this.labKhuyenMai.AutoSize = true;
            this.labKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKhuyenMai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labKhuyenMai.Location = new System.Drawing.Point(400, 150);
            this.labKhuyenMai.Name = "labKhuyenMai";
            this.labKhuyenMai.Size = new System.Drawing.Size(11, 13);
            this.labKhuyenMai.TabIndex = 20;
            this.labKhuyenMai.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(310, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Khuyễn Mại:";
            // 
            // labDVSD
            // 
            this.labDVSD.AutoSize = true;
            this.labDVSD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDVSD.Location = new System.Drawing.Point(23, 149);
            this.labDVSD.Name = "labDVSD";
            this.labDVSD.Size = new System.Drawing.Size(125, 15);
            this.labDVSD.TabIndex = 18;
            this.labDVSD.Text = "Thông Tin Phòng Đặt:";
            // 
            // labTienDV
            // 
            this.labTienDV.AutoSize = true;
            this.labTienDV.Location = new System.Drawing.Point(400, 90);
            this.labTienDV.Name = "labTienDV";
            this.labTienDV.Size = new System.Drawing.Size(10, 13);
            this.labTienDV.TabIndex = 17;
            this.labTienDV.Text = "-";
            // 
            // labNgayO
            // 
            this.labNgayO.AutoSize = true;
            this.labNgayO.Location = new System.Drawing.Point(400, 60);
            this.labNgayO.Name = "labNgayO";
            this.labNgayO.Size = new System.Drawing.Size(10, 13);
            this.labNgayO.TabIndex = 16;
            this.labNgayO.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Tiền Dịch Vụ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(310, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Số Ngày Ở:";
            // 
            // btnSDDV
            // 
            this.btnSDDV.AutoSize = true;
            this.btnSDDV.Location = new System.Drawing.Point(439, 358);
            this.btnSDDV.Name = "btnSDDV";
            this.btnSDDV.Size = new System.Drawing.Size(102, 23);
            this.btnSDDV.TabIndex = 13;
            this.btnSDDV.Text = "DSDV Sử Dụng";
            this.btnSDDV.UseVisualStyleBackColor = true;
            this.btnSDDV.Click += new System.EventHandler(this.btnSDDV_Click);
            // 
            // labTongTien
            // 
            this.labTongTien.AutoSize = true;
            this.labTongTien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTongTien.ForeColor = System.Drawing.Color.Red;
            this.labTongTien.Location = new System.Drawing.Point(102, 333);
            this.labTongTien.Name = "labTongTien";
            this.labTongTien.Size = new System.Drawing.Size(13, 17);
            this.labTongTien.TabIndex = 11;
            this.labTongTien.Text = "-";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.Red;
            this.a.Location = new System.Drawing.Point(15, 333);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(81, 17);
            this.a.TabIndex = 10;
            this.a.Text = "Tổng Tiền:";
            // 
            // labNgayTT
            // 
            this.labNgayTT.AutoSize = true;
            this.labNgayTT.Location = new System.Drawing.Point(135, 90);
            this.labNgayTT.Name = "labNgayTT";
            this.labNgayTT.Size = new System.Drawing.Size(10, 13);
            this.labNgayTT.TabIndex = 7;
            this.labNgayTT.Text = "-";
            // 
            // labSoPhong
            // 
            this.labSoPhong.AutoSize = true;
            this.labSoPhong.Location = new System.Drawing.Point(400, 30);
            this.labSoPhong.Name = "labSoPhong";
            this.labSoPhong.Size = new System.Drawing.Size(10, 13);
            this.labSoPhong.TabIndex = 6;
            this.labSoPhong.Text = "-";
            // 
            // labTenKH
            // 
            this.labTenKH.AutoSize = true;
            this.labTenKH.Location = new System.Drawing.Point(135, 60);
            this.labTenKH.Name = "labTenKH";
            this.labTenKH.Size = new System.Drawing.Size(10, 13);
            this.labTenKH.TabIndex = 5;
            this.labTenKH.Text = "-";
            // 
            // labMaKH
            // 
            this.labMaKH.AutoSize = true;
            this.labMaKH.Location = new System.Drawing.Point(135, 30);
            this.labMaKH.Name = "labMaKH";
            this.labMaKH.Size = new System.Drawing.Size(10, 13);
            this.labMaKH.TabIndex = 4;
            this.labMaKH.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Thanh Toán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Phòng Thuê:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Khách Hàng:";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(492, 617);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.AutoSize = true;
            this.btnThemHD.Location = new System.Drawing.Point(338, 617);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(97, 23);
            this.btnThemHD.TabIndex = 21;
            this.btnThemHD.Text = " Lập HD";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(426, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "%";
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmPay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbMKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSDDV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labTongTien;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label labNgayTT;
        private System.Windows.Forms.Label labSoPhong;
        private System.Windows.Forms.Label labTenKH;
        private System.Windows.Forms.Label labMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbbCCCD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvTTKH;
        private System.Windows.Forms.Label labKhuyenMai;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labDVSD;
        private System.Windows.Forms.Label labTienDV;
        private System.Windows.Forms.Label labNgayO;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Label label8;
    }
}