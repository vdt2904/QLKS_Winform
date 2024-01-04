namespace BTL
{
    partial class frmRoomManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomManager));
            this.dgvDSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbGia1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbMax1 = new System.Windows.Forms.ComboBox();
            this.cbbLP1 = new System.Windows.Forms.ComboBox();
            this.txtTP1 = new System.Windows.Forms.TextBox();
            this.txtMP1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy2 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbGia2 = new System.Windows.Forms.ComboBox();
            this.cbbSNTD2 = new System.Windows.Forms.ComboBox();
            this.cbbLP2 = new System.Windows.Forms.ComboBox();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.cbbMP2 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTSP = new System.Windows.Forms.Label();
            this.lbPT = new System.Windows.Forms.Label();
            this.lbAll = new System.Windows.Forms.Label();
            this.lbSPDSD = new System.Windows.Forms.Label();
            this.lbDBT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnit = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taotk = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bcdt = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSP
            // 
            this.dgvDSP.AllowUserToAddRows = false;
            this.dgvDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSP.Location = new System.Drawing.Point(0, 300);
            this.dgvDSP.Name = "dgvDSP";
            this.dgvDSP.Size = new System.Drawing.Size(718, 195);
            this.dgvDSP.TabIndex = 0;
            this.dgvDSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSP_CellClick);
            this.dgvDSP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSP_CellFormatting);
            this.dgvDSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDSP_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cbbGia1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbbMax1);
            this.groupBox1.Controls.Add(this.cbbLP1);
            this.groupBox1.Controls.Add(this.txtTP1);
            this.groupBox1.Controls.Add(this.txtMP1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(348, 63);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbGia1
            // 
            this.cbbGia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGia1.Enabled = false;
            this.cbbGia1.FormattingEnabled = true;
            this.cbbGia1.Items.AddRange(new object[] {
            "",
            "150000",
            "200000",
            "250000",
            "300000"});
            this.cbbGia1.Location = new System.Drawing.Point(90, 145);
            this.cbbGia1.Name = "cbbGia1";
            this.cbbGia1.Size = new System.Drawing.Size(167, 21);
            this.cbbGia1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số người tối đa:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(348, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbMax1
            // 
            this.cbbMax1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMax1.Enabled = false;
            this.cbbMax1.FormattingEnabled = true;
            this.cbbMax1.Items.AddRange(new object[] {
            "",
            "2",
            "3",
            "4",
            "5"});
            this.cbbMax1.Location = new System.Drawing.Point(90, 115);
            this.cbbMax1.Name = "cbbMax1";
            this.cbbMax1.Size = new System.Drawing.Size(167, 21);
            this.cbbMax1.TabIndex = 7;
            // 
            // cbbLP1
            // 
            this.cbbLP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLP1.FormattingEnabled = true;
            this.cbbLP1.Items.AddRange(new object[] {
            "",
            "Phòng Standard",
            "Phòng Superior",
            "Phòng Deluxe",
            "Phòng Suite"});
            this.cbbLP1.Location = new System.Drawing.Point(90, 85);
            this.cbbLP1.Name = "cbbLP1";
            this.cbbLP1.Size = new System.Drawing.Size(167, 21);
            this.cbbLP1.TabIndex = 6;
            this.cbbLP1.SelectedIndexChanged += new System.EventHandler(this.cbbLP1_SelectedIndexChanged);
            // 
            // txtTP1
            // 
            this.txtTP1.Location = new System.Drawing.Point(90, 55);
            this.txtTP1.Name = "txtTP1";
            this.txtTP1.Size = new System.Drawing.Size(167, 20);
            this.txtTP1.TabIndex = 5;
            // 
            // txtMP1
            // 
            this.txtMP1.Enabled = false;
            this.txtMP1.Location = new System.Drawing.Point(90, 25);
            this.txtMP1.Name = "txtMP1";
            this.txtMP1.Size = new System.Drawing.Size(167, 20);
            this.txtMP1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá Phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(367, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(367, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbbTT);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnHuy2);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.cbbGia2);
            this.groupBox2.Controls.Add(this.cbbSNTD2);
            this.groupBox2.Controls.Add(this.cbbLP2);
            this.groupBox2.Controls.Add(this.cbbTP);
            this.groupBox2.Controls.Add(this.cbbMP2);
            this.groupBox2.Location = new System.Drawing.Point(498, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 206);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cập Nhập Tình Trạng Phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Items.AddRange(new object[] {
            "Chưa Sử Dụng",
            "Đang Sử Dụng",
            "Đang Bảo Trì"});
            this.cbbTT.Location = new System.Drawing.Point(125, 174);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(180, 21);
            this.cbbTT.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Tình Trạng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Giá Phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số người tối đa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Loại Phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tên Phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã Phòng:";
            // 
            // btnHuy2
            // 
            this.btnHuy2.Location = new System.Drawing.Point(367, 123);
            this.btnHuy2.Name = "btnHuy2";
            this.btnHuy2.Size = new System.Drawing.Size(75, 23);
            this.btnHuy2.TabIndex = 6;
            this.btnHuy2.Text = "Huỷ";
            this.btnHuy2.UseVisualStyleBackColor = true;
            this.btnHuy2.Click += new System.EventHandler(this.btnHuy2_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(367, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbGia2
            // 
            this.cbbGia2.FormattingEnabled = true;
            this.cbbGia2.Items.AddRange(new object[] {
            "150000",
            "200000",
            "250000",
            "300000"});
            this.cbbGia2.Location = new System.Drawing.Point(125, 145);
            this.cbbGia2.Name = "cbbGia2";
            this.cbbGia2.Size = new System.Drawing.Size(180, 21);
            this.cbbGia2.TabIndex = 4;
            // 
            // cbbSNTD2
            // 
            this.cbbSNTD2.FormattingEnabled = true;
            this.cbbSNTD2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cbbSNTD2.Location = new System.Drawing.Point(125, 115);
            this.cbbSNTD2.Name = "cbbSNTD2";
            this.cbbSNTD2.Size = new System.Drawing.Size(180, 21);
            this.cbbSNTD2.TabIndex = 3;
            // 
            // cbbLP2
            // 
            this.cbbLP2.FormattingEnabled = true;
            this.cbbLP2.Items.AddRange(new object[] {
            "Phòng Standard",
            "Phòng Superior",
            "Phòng Deluxe",
            "Phòng Suite"});
            this.cbbLP2.Location = new System.Drawing.Point(125, 85);
            this.cbbLP2.Name = "cbbLP2";
            this.cbbLP2.Size = new System.Drawing.Size(180, 21);
            this.cbbLP2.TabIndex = 2;
            // 
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(125, 55);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(180, 21);
            this.cbbTP.TabIndex = 1;
            // 
            // cbbMP2
            // 
            this.cbbMP2.FormattingEnabled = true;
            this.cbbMP2.Location = new System.Drawing.Point(125, 25);
            this.cbbMP2.Name = "cbbMP2";
            this.cbbMP2.Size = new System.Drawing.Size(180, 21);
            this.cbbMP2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(842, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Danh Sách Phòng:";
            // 
            // lbTSP
            // 
            this.lbTSP.AutoSize = true;
            this.lbTSP.Location = new System.Drawing.Point(725, 420);
            this.lbTSP.Name = "lbTSP";
            this.lbTSP.Size = new System.Drawing.Size(85, 13);
            this.lbTSP.TabIndex = 7;
            this.lbTSP.Text = "Tổng Số Phòng:";
            // 
            // lbPT
            // 
            this.lbPT.AutoSize = true;
            this.lbPT.Location = new System.Drawing.Point(725, 390);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(88, 13);
            this.lbPT.TabIndex = 8;
            this.lbPT.Text = "Số Phòng Trống:";
            // 
            // lbAll
            // 
            this.lbAll.AutoSize = true;
            this.lbAll.Location = new System.Drawing.Point(725, 300);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(42, 13);
            this.lbAll.TabIndex = 9;
            this.lbAll.Text = "Tất Cả:";
            // 
            // lbSPDSD
            // 
            this.lbSPDSD.AutoSize = true;
            this.lbSPDSD.Location = new System.Drawing.Point(725, 360);
            this.lbSPDSD.Name = "lbSPDSD";
            this.lbSPDSD.Size = new System.Drawing.Size(131, 13);
            this.lbSPDSD.TabIndex = 10;
            this.lbSPDSD.Text = "Số Phòng Đang Sử Dụng:";
            // 
            // lbDBT
            // 
            this.lbDBT.AutoSize = true;
            this.lbDBT.Location = new System.Drawing.Point(725, 330);
            this.lbDBT.Name = "lbDBT";
            this.lbDBT.Size = new System.Drawing.Size(136, 13);
            this.lbDBT.TabIndex = 11;
            this.lbDBT.Text = "Số Phòng Đang Sửa Chữa:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnit,
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnit
            // 
            this.mnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.taotk,
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mnit.Name = "mnit";
            this.mnit.Size = new System.Drawing.Size(71, 20);
            this.mnit.Text = "Hệ Thống";
            this.mnit.TextChanged += new System.EventHandler(this.mnit_TextChanged);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // taotk
            // 
            this.taotk.Name = "taotk";
            this.taotk.Size = new System.Drawing.Size(147, 22);
            this.taotk.Text = "Tạo Tài Khoản";
            this.taotk.Click += new System.EventHandler(this.taotk_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuêPhòngToolStripMenuItem,
            this.dịchVụToolStripMenuItem});
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản Lý Phòng";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thuêPhòngToolStripMenuItem.Text = "Thuê Phòng";
            this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.dịchVụToolStripMenuItem.Text = "Dịch Vụ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.dịchVụToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem});
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem1,
            this.hoáĐơnToolStripMenuItem});
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            // 
            // thanhToánToolStripMenuItem1
            // 
            this.thanhToánToolStripMenuItem1.Name = "thanhToánToolStripMenuItem1";
            this.thanhToánToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.thanhToánToolStripMenuItem1.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem1.Click += new System.EventHandler(this.thanhToánToolStripMenuItem1_Click);
            // 
            // hoáĐơnToolStripMenuItem
            // 
            this.hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            this.hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hoáĐơnToolStripMenuItem.Text = "Hoá Đơn";
            this.hoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.hoáĐơnToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bcdt});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // bcdt
            // 
            this.bcdt.Name = "bcdt";
            this.bcdt.Size = new System.Drawing.Size(180, 22);
            this.bcdt.Text = "Báo Cáo Doanh Thu";
            this.bcdt.Click += new System.EventHandler(this.bcdt_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            this.hỗTrợToolStripMenuItem.Click += new System.EventHandler(this.hỗTrợToolStripMenuItem_Click);
            // 
            // frmRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 507);
            this.Controls.Add(this.lbDBT);
            this.Controls.Add(this.lbSPDSD);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.lbPT);
            this.Controls.Add(this.lbTSP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSP);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRoomManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.frmRoomManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbGia1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbMax1;
        private System.Windows.Forms.ComboBox cbbLP1;
        private System.Windows.Forms.TextBox txtTP1;
        private System.Windows.Forms.TextBox txtMP1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHuy2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbGia2;
        private System.Windows.Forms.ComboBox cbbSNTD2;
        private System.Windows.Forms.ComboBox cbbLP2;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.ComboBox cbbMP2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTSP;
        private System.Windows.Forms.Label lbPT;
        private System.Windows.Forms.Label lbAll;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbbTT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbSPDSD;
        private System.Windows.Forms.Label lbDBT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnit;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taotk;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bcdt;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
    }
}