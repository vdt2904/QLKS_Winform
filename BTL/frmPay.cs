using BTL.Classes;
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

namespace BTL
{
    public partial class frmPay : Form
    {
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        DataBaseProcess dtBase = new DataBaseProcess();
        public frmPay()
        {
            InitializeComponent();
        }
        private void LoadcbbMaKH()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select distinct MaKH from tb_DatPhong where TinhTrang = N'Chưa Thanh Toán'", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMKH.DataSource = dt;
            cbbMKH.ValueMember = "MaKH";
        }
        private void LoadcbbCCCD()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select distinct CCCD from tb_DatPhong dp inner join tb_KhachHang kh on dp.MaKH = kh.MaKH where TinhTrang = N'Chưa Thanh Toán'", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCCCD.DataSource = dt;
            cbbCCCD.ValueMember = "CCCD";
        }

        private void Reset()
        {
            cbbMKH.Text = "";
            cbbCCCD.Text = "";
            txtTenKH.Text = "";
            labMaKH.Text = "-";
            labTenKH.Text = "-";
            labSoPhong.Text = "-";
            labNgayO.Text = "-";
            labNgayTT.Text = "-";
            labTienDV.Text = "-";
            labTongTien.Text = "-";
            labKhuyenMai.Text = "-";
            dgvTTKH.DataSource = dtBase.DataReader("select MaPhieu,tb_Datphong.MaPhong,TenPhong,NgayDen,NgayDi from tb_datphong join tb_phong on tb_phong.maphong = tb_DatPhong.maphong where makh = N'" + cbbMKH.Text + "' and tb_DatPhong.tinhtrang = N'Chưa Thanh Toán'");
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            LoadcbbMaKH();
            LoadcbbCCCD();
            Reset();

        }



        private void cbbMKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select CCCD,TenKh from tb_Khachhang where makh = N'" + cbbMKH.Text + "'";
            DataTable dt = dtBase.DataReader(sql);
            if(dt.Rows.Count > 0)
            {
                cbbCCCD.Text = dt.Rows[0]["CCCD"].ToString().Trim();
                txtTenKH.Text = dt.Rows[0]["TenKH"].ToString().Trim();

                labMaKH.Text = cbbMKH.Text;
                labTenKH.Text = txtTenKH.Text;
                //so phong
                sql = "select count(maphong) from tb_datphong where makh = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt2 = dtBase.DataReader(sql);
                labSoPhong.Text = dt2.Rows[0][0].ToString().Trim();
                //so ngay o
                sql = "select DATEDIFF(DD,NgayDen,NgayDi) " +
                    "from tb_DatPhong where MaKH = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt3 = dtBase.DataReader(sql);
                labNgayO.Text = dt3.Rows[0][0].ToString().Trim();
                //tong tien dv
                sql = "select SUM(dv.DonGia * sddv.SoLuong) from tb_DichVu dv join tb_SuDungDV sddv on dv.MaDV = sddv.MaDV join tb_DatPhong dp on sddv.MaPhieu = dp.MaPhieu where dp.MaKH = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt4 = dtBase.DataReader(sql);
                labTienDV.Text = dt4.Rows[0][0].ToString().Trim();
                //khuyen mai
                khuyenMai();
                //TongTienPhong
                sql = "select sum(gia*" + labNgayO.Text + ") from tb_phong join tb_loaiphong on tb_loaiPhong.malp = tb_phong.malp join tb_datphong on tb_datphong.maphong = tb_phong.maphong where makh = N'" + labMaKH.Text + "' and tb_Datphong.tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt5 = dtBase.DataReader(sql);
                string a = ""; 
                a = dt5.Rows[0][0].ToString().Trim();

                //TongTien
                double b = 0;
                if(labTienDV.Text != "")
                {
                   b = (Convert.ToDouble(a)+Convert.ToDouble(labTienDV.Text))*(1-Convert.ToDouble(labKhuyenMai.Text)/100);
                    labTongTien.Text = Convert.ToString(b);

                }
                else
                {
                    b = (Convert.ToDouble(a)) * (1 - Convert.ToDouble(labKhuyenMai.Text) / 100);
                    labTongTien.Text = Convert.ToString(b);
                }
                //loadDGV
                dgvTTKH.DataSource = dtBase.DataReader("select MaPhieu,tb_Datphong.MaPhong,TenPhong,NgayDen,NgayDi from tb_datphong join tb_phong on tb_phong.maphong = tb_DatPhong.maphong where makh = N'"+cbbMKH.Text+"' and tb_DatPhong.tinhtrang = N'Chưa Thanh Toán'");
            }
        }

        private void cbbCCCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select MaKH,TenKh from tb_Khachhang where CCCD = N'" + cbbCCCD.Text + "'";
            DataTable dt = dtBase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                cbbMKH.Text = dt.Rows[0]["MaKH"].ToString().Trim();
                txtTenKH.Text = dt.Rows[0]["TenKH"].ToString().Trim();

                labMaKH.Text = cbbMKH.Text;
                labTenKH.Text = txtTenKH.Text;
                //so phong
                sql = "select count(maphong) from tb_datphong where makh = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt2 = dtBase.DataReader(sql);
                labSoPhong.Text = dt2.Rows[0][0].ToString().Trim();
                //so ngay o
                sql = "select DATEDIFF(DD,NgayDen,NgayDi) " +
                    "from tb_DatPhong where MaKH = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt3 = dtBase.DataReader(sql);
                labNgayO.Text = dt3.Rows[0][0].ToString().Trim();
                //tong tien dv
                sql = "select SUM(dv.DonGia * sddv.SoLuong) from tb_DichVu dv join tb_SuDungDV sddv on dv.MaDV = sddv.MaDV join tb_DatPhong dp on sddv.MaPhieu = dp.MaPhieu where dp.MaKH = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt4 = dtBase.DataReader(sql);
                labTienDV.Text = dt4.Rows[0][0].ToString().Trim();
                //khuyen mai
                khuyenMai();
                //TongTienPhong
                sql = "select sum(gia*" + labNgayO.Text + ") from tb_phong join tb_loaiphong on tb_loaiPhong.malp = tb_phong.malp join tb_datphong on tb_datphong.maphong = tb_phong.maphong where makh = N'" + labMaKH.Text + "' and tb_Datphong.tinhtrang = N'Chưa Thanh Toán'";
                DataTable dt5 = dtBase.DataReader(sql);
                string a = "";
                a = dt5.Rows[0][0].ToString().Trim();

                //TongTien
                double b = 0;
                if (labTienDV.Text != "")
                {
                    b = (Convert.ToDouble(a) + Convert.ToDouble(labTienDV.Text)) * (1 - Convert.ToDouble(labKhuyenMai.Text) / 100);
                    labTongTien.Text = Convert.ToString(b);

                }
                else
                {
                    b = (Convert.ToDouble(a)) * (1 - Convert.ToDouble(labKhuyenMai.Text) / 100);
                    labTongTien.Text = Convert.ToString(b);
                }
                //loadDGV
                dgvTTKH.DataSource = dtBase.DataReader("select MaPhieu,tb_Datphong.MaPhong,TenPhong,NgayDen,NgayDi from tb_datphong join tb_phong on tb_phong.maphong = tb_DatPhong.maphong where makh = N'" + cbbMKH.Text + "' and tb_DatPhong.tinhtrang = N'Chưa Thanh Toán'");
            }
        }
        string dp = "";
        private void dgvTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dp = dgvTTKH.CurrentRow.Cells[0].Value.ToString();
        }
        private void khuyenMai()
        {
            string sql = "select Note from tb_KhachHang where MaKH = N'" + labMaKH.Text + "'";
            DataTable dt2 = dtBase.DataReader(sql);
            dt2 = dtBase.DataReader(sql);
            if (dt2.Rows[0][0].ToString() == "VIP")
            {
                labKhuyenMai.Text = "20";
                return;
            }
            if (dt2.Rows[0][0].ToString() == "Chủ đầu tư")
            {
                labKhuyenMai.Text = "15";
                return;
            }
            if (dt2.Rows[0][0].ToString() == "Nhà thầu")
            {
                labKhuyenMai.Text = "10";
                return;
            }
            if (dt2.Rows[0][0].ToString() == "Ban quản lý")
            {
                labKhuyenMai.Text = "5";
                return;
            }
            labKhuyenMai.Text = "0";
        }



        private double tongTien()
        {
            //Tinh tiền phòng
            string sql = "select lp.gia * DATEDIFF(DD,dp.NgayDen,dp.NgayDi) " +
                "from tb_DatPhong dp inner join tb_Phong p on dp.MaPhong = p.MaPhong " +
                "inner join tb_LoaiPhong lp on p.MaLP = lp.MaLP " +
                "where dp.MaKH = N'" + labMaKH.Text + "' and dp.MaPhong = N'" + labSoPhong.Text + "'";
            DataTable dt2 = dtBase.DataReader(sql);

            double tong = float.Parse(dt2.Rows[0][0].ToString());
            //Cộng thêm tiền dịch vụ
/*            tong += tienDV();*/
            //Tiền khuyến mại với từng loại KH
            sql = "select Note from tb_KhachHang where MaKH = N'" + labMaKH.Text + "'";
            dt2 = dtBase.DataReader(sql);

            if (dt2.Rows[0][0].ToString() == "VIP")
            {
                tong -= tong * 0.2;
            }
            if (dt2.Rows[0][0].ToString() == "Chủ đầu tư")
            {
                tong -= tong * 0.15;
            }
            if (dt2.Rows[0][0].ToString() == "Nhà thầu")
            {
                tong -= tong * 0.1;
            }
            if (dt2.Rows[0][0].ToString() == "Ban quản lý")
            {
                tong -= tong * 0.05;
            }
            return tong;
        }

        private void btnSDDV_Click(object sender, EventArgs e)
        {
            if(cbbMKH.Text != "")
            {
                if(btnSDDV.Text == "DSDV Sử Dụng")
                {
                    btnSDDV.Text = "DS Phòng Đặt";
                    dgvTTKH.DataSource = dtBase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'" + dp + "' order by stt asc");

                }
                else
                {
                    btnSDDV.Text = "DSDV Sử Dụng";
                    dgvTTKH.DataSource = dtBase.DataReader("select MaPhieu,tb_Datphong.MaPhong,TenPhong,NgayDen,NgayDi from tb_datphong join tb_phong on tb_phong.maphong = tb_DatPhong.maphong where makh = N'" + cbbMKH.Text + "' and tb_DatPhong.tinhtrang = N'Chưa Thanh Toán'");
                }
            }
        }
        private string addSHD()
        {
            string SHD = "";
            int count = 0;
            string sql = "select SoHD from tb_HoaDon";
            DataTable dttb = dtBase.DataReader(sql);
            count = dttb.Rows.Count;
            if (count == 0)
            {
                return SHD = "HD000" + (1).ToString();
            }
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dttb.Rows[count - 1][0]);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));
            if (chuoi2 + 1 < 10)
            {
                SHD = "HD000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                SHD = "HD00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                SHD = "HD0" + (chuoi2 + 1).ToString();
            }
            return SHD;
        }

        private string getUID()
        {
            string UID = "";
            string sql = "select UID from tb_Accout " +
                "where userName = N'" + frmLogin.user + "' and passWord = N'" + frmLogin.pass + "' and userss = N'" + frmLogin.userss + "'";
            DataTable dttb = dtBase.DataReader(sql);
            return UID = dttb.Rows[0][0].ToString();
        }

        private string getMaNV()
        {
            string MaNV = "";
            string sql = "select nv.MaNV " +
                "from tb_NhanVien nv inner join tb_Accout tk on nv.manv = tk.manv " +
                "where tk.UID  = N'" + getUID()+"'";
            DataTable dttb = dtBase.DataReader(sql);
            return MaNV = dttb.Rows[0][0].ToString();
        }
        //tạo 2 biến dùng cho form InHDTT
        public static string MaKH;
        public static string MaPhong;

        private void btnThemHD_Click(object sender, EventArgs e)
        {
 
           if (labMaKH.Text != "-")
            {
                try
                {
                    labNgayTT.Text = DateTime.Now.ToString();
                    //Thêm hóa đơn
                    string sql = "insert into tb_HoaDon (SoHD, MaKH, MaNV, NgayThanhToan,TongTien) values ( N'" + addSHD() + "', N'" + labMaKH.Text + "', N'" + getMaNV() +
                    "',getdate(),N'" + labTongTien.Text + "' )";
                    dtBase.DataChange(sql);
                    // sửa TinhTrang bảng Phong
                    sql = "update tb_Phong set TinhTrang = N'Chưa Sử Dụng' " +
                         "where MaPhong in (" +
                            "select dp.MaPhong " +
                            "from tb_Phong p join tb_DatPhong dp " +
                            "on p.MaPhong = dp.MaPhong " +
                            "where dp.MaKH = N'" + labMaKH.Text + "' and dp.tinhtrang = N'Chưa Thanh Toán' and  (getdate() = ngaydi or getdate() not between ngayden and ngaydi))";
                    dtBase.DataChange(sql);
                    //sửa TinhTrang bảng DatPhong
                    sql = "update tb_DatPhong set TinhTrang = N'Đã Thanh Toán' " +
                        "where MaKH = N'" + labMaKH.Text + "' and tinhtrang = N'Chưa Thanh Toán'";
                    dtBase.DataChange(sql);



                    MessageBox.Show("Bạn đã thêm thành công", "Thông báo");

                    //gán gtri cho 2 biến
                    MaKH = labMaKH.Text;
                    MaPhong = labSoPhong.Text;

                    //Mở form In hóa đơn
/*                   InHD.InHDTT inHDTT = new InHD.InHDTT();
                    inHDTT.ShowDialog();*/


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn đã thêm thất bại", "Thông báo");
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Thông Tin Chưa Đầy Đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
