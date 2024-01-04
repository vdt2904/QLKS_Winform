using BTL.Classes;
using BTL.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
    public partial class frmBill : Form
    {
        DataBaseProcess data = new DataBaseProcess();
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public frmBill()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            btnXoa.Enabled = false;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            string sql = "select SoHD,tb_NhanVien.MANV,TenNV,tb_KhachHang.MAKH,TenKH," +
                "tb_KhachHang.CCCD,tb_KhachHang.NgaySinh,DiaChi,NgayThanhToan, " +
                "   SoDienThoai,Tongtien from Tb_Hoadon join tb_KhachHang on tb_KhachHang.MaKH=tb_HoaDon.MaKH " +
                "    join tb_NhanVien on Tb_NhanVien.MaNV=Tb_HoaDon.MaNV ";
            dataGridView1.DataSource = data.DataReader(sql);
            frmPrint.b = "select * from tb_HoaDon";
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            LoadMaNV();
            LoadSoHD();
            LoadCCCD();
        }
        public void LoadMaNV()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select * from tb_Nhanvien ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMNV.DataSource = dt;
            cbbMNV.ValueMember = "MaNV";
            cbbMNV.Text = "";
        }
        public void LoadSoHD()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select * from tb_HoaDon", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMHD.DataSource = dt;
            cbbMHD.ValueMember = "SoHD";
            cbbMHD.Text = "";

        }
        public void LoadCCCD()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select * from tb_Khachhang", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCCCD.DataSource = dt;
            cbbCCCD.ValueMember = "CCCD";
            cbbCCCD.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            txtSHD.Text = dataGridView1.CurrentRow.Cells["SoHD"].Value.ToString();
            txtMKH.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTKH.Text = dataGridView1.CurrentRow.Cells["TenKH"].Value.ToString();
            txtMNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTNV.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            txtNTT.Text = dataGridView1.CurrentRow.Cells["NgayThanhToan"].Value.ToString();
            txtTT.Text = dataGridView1.CurrentRow.Cells["Tongtien"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime a = DateTime.Parse(dtpFrom.Text), b = DateTime.Parse(dtpTo.Text);
            if (cbbCCCD.Text == "" && radioButton1.Checked == false && cbbMHD.Text == "" && cbbMNV.Text == "")
            {
                MessageBox.Show("Chưa có TT!");
            }
            else
            {
                string sql = "";
                sql = "select SoHD,tb_hoadon.makh,TenKH,tb_hoadon.manv,TenNV,NgayThanhToan,TongTien from tb_HoaDon join tb_khachhang on tb_hoadon.makh = tb_khachhang.makh join tb_nhanvien on tb_nhanvien.manv = tb_hoadon.manv where ";
                if(cbbCCCD.Text != "")
                {
                    sql += "tb_KhachHang.CCCD = N'"+cbbCCCD.Text+"' ";
                }

                if (cbbCCCD.Text != "" && radioButton1.Checked == true && DateTime.Compare(a, b) <= 0)
                {
                    sql += "and (ngaythanhtoan >= N'" + String.Format("{0:u}", dtpFrom.Value.Date) + "' and ngaythanhtoan <= N'" + String.Format("{0:u}", dtpTo.Value.Date) + "' ) ";
                }
                else if (cbbCCCD.Text == "" && radioButton1.Checked == true && DateTime.Compare(a, b) <= 0)
                {
                    sql += "(ngaythanhtoan >= N'" + String.Format("{0:u}", dtpFrom.Value.Date) + "' and ngaythanhtoan <= N'" + String.Format("{0:u}", dtpTo.Value.Date) + "' ) ";
                }
                if((cbbCCCD.Text != "" ||( radioButton1.Checked == true && DateTime.Compare(a, b) <= 0)) && cbbMHD.Text != "")
                {
                    sql += "and SoHD = N'" + cbbMHD.Text + "' ";
                }else if(cbbCCCD.Text == "" && radioButton1.Checked == false && cbbMHD.Text != "")
                {
                    sql += " SoHD = N'" + cbbMHD.Text + "' ";
                }
                if((cbbCCCD.Text != "" || (radioButton1.Checked == true && DateTime.Compare(a, b) <= 0) || cbbMHD.Text != "") && cbbMNV.Text != "")
                {
                    sql += "and tb_HoaDon.Manv = N'" + cbbMNV.Text + "' ";
                }else if(cbbCCCD.Text == "" && radioButton1.Checked == false && cbbMHD.Text == "" && cbbMNV.Text != "")
                {
                    sql += "tb_HoaDon.Manv = N'" + cbbMNV.Text + "' ";
                }
                dataGridView1.DataSource = data.DataReader(sql);
                sql = "select SoHD,tb_hoadon.makh,tb_hoadon.manv,NgayThanhToan,TongTien from tb_HoaDon join tb_khachhang on tb_hoadon.makh = tb_khachhang.makh join tb_nhanvien on tb_nhanvien.manv = tb_hoadon.manv where ";
                if (cbbCCCD.Text != "")
                {
                    sql += "tb_KhachHang.CCCD = N'" + cbbCCCD.Text + "' ";
                }

                if (cbbCCCD.Text != "" && radioButton1.Checked == true && DateTime.Compare(a, b) <= 0)
                {
                    sql += "and (ngaythanhtoan >= N'" + String.Format("{0:u}", dtpFrom.Value.Date) + "' and ngaythanhtoan <= N'" + String.Format("{0:u}", dtpTo.Value.Date) + "' ) ";
                }
                else if (cbbCCCD.Text == "" && radioButton1.Checked == true && DateTime.Compare(a, b) <= 0)
                {
                    sql += "(ngaythanhtoan >= N'" + String.Format("{0:u}", dtpFrom.Value.Date) + "' and ngaythanhtoan <= N'" + String.Format("{0:u}", dtpTo.Value.Date) + "' ) ";
                }
                if ((cbbCCCD.Text != "" || (radioButton1.Checked == true && DateTime.Compare(a, b) <= 0)) && cbbMHD.Text != "")
                {
                    sql += "and SoHD = N'" + cbbMHD.Text + "' ";
                }
                else if (cbbCCCD.Text == "" && radioButton1.Checked == false && cbbMHD.Text != "")
                {
                    sql += " SoHD = N'" + cbbMHD.Text + "' ";
                }
                if ((cbbCCCD.Text != "" || (radioButton1.Checked == true && DateTime.Compare(a, b) <= 0) || cbbMHD.Text != "") && cbbMNV.Text != "")
                {
                    sql += "and tb_HoaDon.Manv = N'" + cbbMNV.Text + "' ";
                }
                else if (cbbCCCD.Text == "" && radioButton1.Checked == false && cbbMHD.Text == "" && cbbMNV.Text != "")
                {
                    sql += "tb_HoaDon.Manv = N'" + cbbMNV.Text + "' ";
                }
                frmPrint.b = sql;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void btnLM2_Click(object sender, EventArgs e)
        {
            cbbCCCD.Text = "";
            cbbMHD.Text = "";
            cbbMNV.Text = "";
            radioButton1.Checked = false;
            string sql = "select SoHD,tb_NhanVien.MANV,TenNV,tb_KhachHang.MAKH,TenKH," +
    "tb_KhachHang.CCCD,tb_KhachHang.NgaySinh,DiaChi,NgayThanhToan, " +
    "   SoDienThoai,Tongtien from Tb_Hoadon join tb_KhachHang on tb_KhachHang.MaKH=tb_HoaDon.MaKH " +
    "    join tb_NhanVien on Tb_NhanVien.MaNV=Tb_HoaDon.MaNV ";
            dataGridView1.DataSource = data.DataReader(sql);
            frmPrint.b = sql;

        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            txtMKH.Text = "";
            txtMNV.Text = "";
            txtNTT.Text = "";
            txtSHD.Text = "";
            txtTKH.Text = "";
            txtTNV.Text = "";
            txtTT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chan muốn xóa ", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes
             )
            {
                string sql = "delete from tb_Hoadon where SoHD=N'" + txtSHD.Text + "'";
                data.DataChange(sql);
            }
            
             frmBill_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frmPrint pr = new frmPrint();
            frmPrint.a = "d";
            pr.ShowDialog();
        }
    }
}
