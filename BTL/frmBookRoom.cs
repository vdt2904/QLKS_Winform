using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmBookRoom : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmBookRoom()
        {
            InitializeComponent();
        }
        private void tdma()
        {
            int count = 0;
            count = dgvDP.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDP.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));
            if (chuoi2 + 1 < 10)
            {
                txtMPhieu.Text = "DP000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMPhieu.Text = "DP00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txtMPhieu.Text = "DP0" + (chuoi2 + 1).ToString();
            }
        }

        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;



        private void LoadcbbMaKH2()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaKh from tb_KhachHang ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMaKH1.DataSource = dt;
            cbbMaKH1.ValueMember = "MaKH";
        }

        private void LoadcbbTenKH2()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select TenKH from tb_KhachHang ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTenKh2.DataSource = dt;
            cbbTenKh2.ValueMember = "TenKH";
        }
        private void LoadcbbTP1()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select TenPhong from tb_Phong where tinhtrang = N'Chưa Sử dụng' ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTP1.DataSource = dt;
            cbbTP1.ValueMember = "TenPhong";
        }
        private void LoadcbbTP2()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select TenPhong from tb_Phong where tinhtrang = N'Đang Sử Dụng'", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTP2.DataSource = dt;
            cbbTP2.ValueMember = "TenPhong";
        }
        private void LoadcbbMP()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaPhieu from tb_datPhong ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMP.DataSource = dt;
            cbbMP.ValueMember = "MaPhieu";
        }


        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            string sql = "";
/*            dtbase.DataChange("update tb_phong set tinhtrang = N'Chưa Sử Dụng' where tinhtrang = N'Đang Sử Dụng' and maphong not in (select maphong from tb_datphong where getdate() between ngayden and ngaydi) ");*/
            dtbase.DataChange("update tb_phong set tinhtrang = N'Chưa Sử Dụng' where tinhtrang = N'Đang Sử Dụng' and maphong in (select maphong from tb_datphong where tinhtrang = N'Đã Thanh Toán' and getdate() not between ngayden and ngaydi) ");
            dgvPCT.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP where tinhtrang = N'Chưa Sử Dụng' order by tenphong asc");
            dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi,tb_datphong.tinhtrang from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp");
            if (dgvDP.Rows.Count > 0)
            {
                tdma();

            }
            else
            {
                txtMPhieu.Text = "DP0001";
            }
            LoadcbbMaKH2();
            LoadcbbTenKH2();

            LoadcbbTP2();
            LoadcbbMP();
            cbbMaKH2.Text = "";
            cbbMP.Text = "";
            cbbTenKh2.Text = "";
            cbbTP2.Text = "";
            cbbMaKH1.Text = "";

            cbbTP1.Text = "";
        }
        public class lp
        {
            public string TenP { get; set; }
            public double GiaP { get; set; }
        }
        List<lp> lps = new List<lp>();


        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "";
            if(txtsn.Text ==""|| comboBox3.Text ==""||cbbMaKH1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }else if(dpNgayden.Value >= dpNgaydi.Value)
            {
                MessageBox.Show("vui lòng chọn thời gian!");
            }
            else
            {
                sql = "select * from tb_DatPhong where MaPhong = N'"+cbbTP1.Text+"' " +
                    "and" +
                    "((NgayDen >= N'"+ String.Format("{0:u}", dpNgayden.Value.Date) + "' and NgayDen <= N'"+ String.Format("{0:u}", dpNgaydi.Value.Date) + "' and NgayDi >= N'"+ String.Format("{0:u}", dpNgaydi.Value.Date) + "' )" +
                    "or (NgayDen <= N'"+ String.Format("{0:u}", dpNgayden.Value.Date) + "' and NgayDi >= N'"+ String.Format("{0:u}", dpNgaydi.Value.Date) + "' )" +
                    "or (NgayDen <= N'"+ String.Format("{0:u}", dpNgayden.Value.Date) + "' and NgayDi >= N'"+ String.Format("{0:u}", dpNgayden.Value.Date) + "' and NgayDi <= N'"+ String.Format("{0:u}", dpNgaydi.Value.Date) + "' )" +
                    "or (NgayDen >= N'"+ String.Format("{0:u}", dpNgayden.Value.Date) + "' and NgayDi <= N'"+ String.Format("{0:u}", dpNgaydi.Value.Date) + "'))  ";
                DataTable dt = dtbase.DataReader(sql);
                if(dt.Rows.Count == 0)
                {
                    sql = "insert into tb_DatPhong values(";
                    sql += " N'" + txtMPhieu.Text + "',";
                    sql += "N'" + cbbMaKH1.Text + "',";
                    sql += " N'" + cbbTP1.Text + "',";
                    sql += " N'" + txtsn.Text + "',";
                    sql += " N'" + String.Format("{0:u}", dpNgayden.Value.Date) + "',";
                    sql += " N'" + String.Format("{0:u}", dpNgaydi.Value.Date) + "',N'Chưa Thanh Toán')";
                    dtbase.DataChange(sql);
                    dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi,tb_datphong.tinhtrang from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp");
                    MessageBox.Show("Đã thêm thành công");
                    sql = "update tb_Phong set tinhtrang = N'Đang Sử Dụng' where TinhTrang = N'Chưa Sử Dụng' and maphong in (select maphong from tb_datphong where tinhtrang = N'Chưa Thanh Toán' and (N'"+ String.Format("{0:u}", DateTime.Now.Date) + "' between ngayden and ngaydi) )";
                    dtbase.DataChange(sql);
                    dgvPCT.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP where tinhtrang = N'Chưa Sử Dụng' order by tenphong asc");

                }
                else
                {
                    MessageBox.Show("Phòng đã có người đặt trùng vài ngày với thời gian bạn đặt!");
                    dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_datPhong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi,tb_datphong.tinhtrang from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp where tb_datphong.maphong = N'"+cbbTP1.Text+"'");
                }



            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lps = new List<lp>()
            {
                new lp(){TenP = "Phòng Standard"  , GiaP = 150000},
                new lp(){TenP = "Phòng Superior"  , GiaP = 200000},
                new lp(){TenP = "Phòng Deluxe" , GiaP = 250000},
                new lp(){TenP = "Phòng Suite"  , GiaP = 300000}

            };
            foreach (lp i in lps)
            {
                if (i.TenP == comboBox3.Text)
                {
                    cbbgia.Text = i.GiaP.ToString();
                }
            }
            if (comboBox3.Text == "")
            {
                LoadcbbTP1();
            }
            else
            {
                foreach (lp i in lps)
                {
                    if (i.TenP == comboBox3.Text)
                    {
                        conn = cn.OpenDB();
                        conn.Open();
                        cmd = new SqlCommand("select TenPhong from tb_Phong join tb_LoaiPhong on tb_loaiphong.malp = tb_phong.malp where tinhtrang = N'Chưa Sử dụng' and LoaiPhong = N'"+i.TenP+"' ", conn);
                        da = new SqlDataAdapter(cmd);
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cbbTP1.DataSource = dt;
                        cbbTP1.ValueMember = "TenPhong";
                    }
                }

            }
        }

        private void cbbgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lps = new List<lp>()
            {
                new lp(){TenP = "Phòng Standard"  , GiaP = 150000},
                new lp(){TenP = "Phòng Superior"  , GiaP = 200000},
                new lp(){TenP = "Phòng Deluxe" , GiaP = 250000},
                new lp(){TenP = "Phòng Suite"  , GiaP = 300000}

            };
            foreach (lp i in lps)
            {
                if (i.GiaP == Convert.ToDouble(cbbgia.Text))
                {
                    comboBox3.Text = i.TenP.ToString();
                }
            }
            if (comboBox3.Text == "")
            {
                LoadcbbTP1();
            }
            else
            {
                foreach (lp i in lps)
                {
                    if (i.TenP == comboBox3.Text)
                    {
                        conn = cn.OpenDB();
                        conn.Open();
                        cmd = new SqlCommand("select TenPhong from tb_Phong join tb_LoaiPhong on tb_loaiphong.malp = tb_phong.malp where tinhtrang = N'Chưa Sử dụng' and LoaiPhong = N'" + i.TenP + "' ", conn);
                        da = new SqlDataAdapter(cmd);
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cbbTP1.DataSource = dt;
                        cbbTP1.ValueMember = "TenPhong";
                    }
                }

            }
        }

        private void dgvPCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox3.Text = dgvPCT.CurrentRow.Cells[3].Value.ToString();
            cbbgia.Text = dgvPCT.CurrentRow.Cells[5].Value.ToString();
            cbbTP1.Text = dgvPCT.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMPhieu.Text = dgvDP.CurrentRow.Cells[0].Value.ToString();
            txtsn.Text = dgvDP.CurrentRow.Cells[3].Value.ToString();
            cbbMaKH1.Text = dgvDP.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text = dgvDP.CurrentRow.Cells[6].Value.ToString();
            cbbTP1.Text = dgvDP.CurrentRow.Cells[4].Value.ToString();
            dpNgayden.Value = (DateTime)dgvDP.CurrentRow.Cells[8].Value;
            dpNgaydi.Value = (DateTime)dgvDP.CurrentRow.Cells[9].Value;
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            if(cbbMaKH2.Text != "")
            {
                dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp where LoaiPhong = N'" + cbbMaKH2.Text+"'");
            }else if (cbbTP2.Text != "")
            {
                dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp where TenPhong = N'" + cbbTP2.Text + "'");
            }else if (cbbTenKh2.Text != "")
            {
                dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp where TenKH = N'" + cbbTenKh2.Text + "'");
            }else if (cbbMP.Text != "")
            {
                dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp where MaPhieu = N'" + cbbMP.Text + "'");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbTenKh2.Text = "";
            cbbMP.Text = "";
            cbbMaKH2.Text = "";
            cbbTP2.Text = "";
            dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp");
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaKH1.Text = "";
            cbbTP1.Text = "";
            txtsn.Text = "";
            comboBox3.Text = "";
            cbbgia.Text = "";
            dpNgayden.Value = DateTime.Now;
            dpNgaydi.Value = DateTime.Now;
            tdma();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá Phiếu đặt phòng " + txtMPhieu.Text + " này ra khỏi danh sách không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "";
                sql = "delete from tb_SuDungDV where maphieu = N'" + txtMPhieu.Text + "' ";
                dtbase.DataChange(sql);
                sql = "update tb_phong set tinhtrang = N'Chưa Sử Dụng' where maphong = (select maphong from tb_datphong where maphieu = N'" + txtMPhieu.Text + "')";
                dtbase.DataChange(sql);
                sql = "delete from tb_DatPhong where maphieu = N'" + txtMPhieu.Text + "' ";
                dtbase.DataChange(sql);
                MessageBox.Show("Đã xoá Thành công!");
                dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp");
                dgvPCT.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP where tinhtrang = N'Chưa Sử Dụng' order by tenphong asc");
                cbbMaKH1.Text = "";
                cbbTP1.Text = "";
                txtsn.Text = "";
                comboBox3.Text = "";
                cbbgia.Text = "";
                dpNgayden.Value = DateTime.Now;
                dpNgaydi.Value = DateTime.Now;
                if (dgvDP.Rows.Count > 0)
                {
                    tdma();

                }
                else
                {
                    txtMPhieu.Text = "DP0001";
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select maphieu from tb_datphong where tinhtrang = N'Chưa Thanh Toán' and maphieu = N'"+txtMPhieu.Text+"'";
            DataTable dt = dtbase.DataReader(sql);
            if(dt.Rows.Count > 0)
            {
                sql = "update tb_datphong set ";
                sql += "MaKH = N'" + cbbMaKH1.Text + "',";
                sql += "MaPhong = N'" + cbbTP1.Text + "',";
                sql += "Songuoi = N'" + txtsn.Text + "',";
                sql += "Ngayden = N'" + String.Format("{0:u}", dpNgayden.Value.Date) + "',";
                sql += "Ngaydi = N'" + String.Format("{0:u}", dpNgaydi.Value.Date) + "'";
                sql += "where maphieu = N'" + txtMPhieu.Text + "'";
                dtbase.DataChange(sql);
                dgvDP.DataSource = dtbase.DataReader("select maphieu,tb_datphong.makh,tenkh,songuoi,tb_Phong.maphong,TenPhong,loaiphong,Gia,ngayden,ngaydi from tb_DatPhong join tb_Phong on tb_Phong.maphong = tb_datphong.maphong join tb_khachhang on tb_khachhang.makh = tb_datphong.makh join tb_LoaiPhong on tb_loaiPhong.malp = tb_phong.malp");
                dgvPCT.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP where tinhtrang = N'Chưa Sử Dụng' order by tenphong asc");
            }
            else
            {
                MessageBox.Show("Không thể sửa phiếu");
            }


        }

        private void txtsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            LoadcbbMaKH2();
            LoadcbbMP();
            LoadcbbTenKH2();
            LoadcbbTP1();
            LoadcbbTP2();
        }
    }
}
