using BTL.Print;
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
    public partial class frmService : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmService()
        {
            InitializeComponent();
        }
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void LoadMP()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaPhieu from tb_DatPhong where tinhtrang = N'Chưa Thanh Toán'", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMP.DataSource = dt;
            cbbMP.ValueMember = "MaPhieu";
        }
        public void LoadMDV()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaDV from tb_DichVu ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMDV.DataSource = dt;
            cbbMDV.ValueMember = "MaDV";
        }
        public void LoadDV()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select TenDV from tb_DichVu ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbDV.DataSource = dt;
            cbbDV.ValueMember = "TenDV";
        }
        public void LoadDG()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select distinct DonGia from tb_DichVu ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbDg.DataSource = dt;
            cbbDg.ValueMember = "DonGia";
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            LoadMP();
            LoadMDV();
            LoadDV();
            LoadDG();
            dgvDv.DataSource = dtbase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'0'");
            cbbMP.Text = "";
            cbbMDV.Text = "";
            cbbDV.Text = "";
            cbbDg.Text = "";
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
            txtMKH.Text = "";
            txtNS.Text = "";
            txtSDT.Text = "";
            txtTKH.Text = "";
            txtTT.Text = "";
        }

        private void cbbMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select kh.MaKH,TenKH,NgaySinh,CCCD,DiaChi,SoDienThoai from tb_KhachHang kh join tb_DatPhong dp on kh.MaKH = dp.MaKH where MaPhieu = N'" + cbbMP.Text + "'";

            DataTable dt = dtbase.DataReader(sql);

            if (dt.Rows.Count > 0)
            {
                string a = dt.Rows[0]["NgaySinh"].ToString().Trim();

                txtMKH.Text = dt.Rows[0]["MaKH"].ToString().Trim();
                txtTKH.Text = dt.Rows[0]["TenKH"].ToString().Trim();
                txtNS.Text = a.Substring(0, 10);
                txtCCCD.Text = dt.Rows[0]["CCCD"].ToString().Trim();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString().Trim();
                txtSDT.Text = dt.Rows[0]["SoDienThoai"].ToString().Trim();
                dgvDv.DataSource = dtbase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'" + cbbMP.Text + "'order by stt asc");
            }

        }

        private void cbbMDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from tb_DichVu where MaDV = N'"+cbbMDV.Text+"'";
            DataTable dt = dtbase.DataReader(sql);
            
            if(dt.Rows.Count > 0)
            {
                cbbDV.Text = dt.Rows[0]["TenDV"].ToString().Trim();
                cbbDg.Text = dt.Rows[0]["DonGia"].ToString().Trim();
                txtTT.Text = (nudSL.Value * Convert.ToInt32(cbbDg.Text)).ToString();
            }
        }

        private void nudSL_ValueChanged(object sender, EventArgs e)
        {
            if(cbbDg.Text != "")
            {

            txtTT.Text = (nudSL.Value * Convert.ToInt32(cbbDg.Text)).ToString();
            }
        }

        private void cbbDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from tb_DichVu where TenDV = N'" + cbbDV.Text + "'";
            DataTable dt = dtbase.DataReader(sql);

            if (dt.Rows.Count > 0)
            {
                cbbMDV.Text = dt.Rows[0]["MaDV"].ToString().Trim();
                cbbDg.Text = dt.Rows[0]["DonGia"].ToString().Trim();
                txtTT.Text = (nudSL.Value * Convert.ToInt32(cbbDg.Text)).ToString();
            }
        }
            int count = 0;
        public void tang()
        {
            count = dgvDv.Rows.Count + 1;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "";
            if(cbbMP.Text == ""||cbbMDV.Text ==""|| cbbDV.Text ==""||cbbDg.Text ==""||nudSL.Value == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!");
            }
            else
            {
                sql = "select tb_dichvu.madv from tb_dichvu join tb_sudungdv on tb_sudungdv.madv = tb_dichvu.madv where MaPhieu = N'" + cbbMP.Text + "' and tb_sudungdv.madv = N'"+cbbMDV.Text+"' and ngaymua = N'"+ String.Format("{0:u}", dtDay.Value.Date) + "'";
                DataTable dt = dtbase.DataReader(sql);
                if(dt.Rows.Count > 0)
                {
                    sql = "update tb_sudungdv set soluong = soluong + N'" + nudSL.Value.ToString() + "' where madv = N'" + cbbMDV.Text + "' and maphieu = N'" + cbbMP.Text + "'";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Thêm Thành Công!");
                    dgvDv.DataSource = dtbase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'" + cbbMP.Text + "' order by stt asc");
                }
                else
                {

                    tang();
                    sql = "Insert into tb_SuDungDV values(";
                    sql += "N'"+count.ToString()+"',";
                    sql += "N'" + cbbMP.Text + "',";
                    sql += "N'"+cbbMDV.Text+"',";
                    sql += "N'" + nudSL.Value.ToString() + "',";
                    sql += "N'"+ String.Format("{0:u}", dtDay.Value.Date) + "')";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Thêm Thành Công!");
                    dgvDv.DataSource = dtbase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'" + cbbMP.Text + "' order by stt asc");
                }
            }
        }
        string a = "";
        private void dgvDv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dgvDv.CurrentRow.Cells[0].Value.ToString();
            cbbMDV.Text = dgvDv.CurrentRow.Cells[1].Value.ToString();
            cbbDV.Text = dgvDv.CurrentRow.Cells[2].Value.ToString();
            nudSL.Value = Convert.ToInt32(dgvDv.CurrentRow.Cells[3].Value);
            cbbDg.Text = dgvDv.CurrentRow.Cells[4].Value.ToString();
            dtDay.Value = (DateTime)dgvDv.CurrentRow.Cells[6].Value;
            txtTT.Text = dgvDv.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbbMP.Text == "" || cbbMDV.Text == "" || cbbDV.Text == "" || cbbDg.Text == "" || nudSL.Value == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!");
            }
            else
            {

                sql = "Update tb_SuDungDV set ";
                sql += "MaDV = N'" + cbbMDV.Text + "',";
                sql += "SoLuong = N'" + nudSL.Value.ToString() + "'";
                sql += "Where MaPhieu = N'" + cbbMP.Text + "' and STT = N'"+a+"'";
                dtbase.DataChange(sql);
                MessageBox.Show("Đã Sửa Thành Công");
                dgvDv.DataSource = dtbase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'" + cbbMP.Text + "' order by stt asc");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

                string sql = "";
                sql = "delete from tb_SuDungDV where maphieu = N'" + cbbMP.Text + "' and STT = N'"+a+"' ";
                dtbase.DataChange(sql);
                MessageBox.Show("Đã xoá Thành công!");
                for(int i = 1; i< count - 1; i++)
                {
                    int c = (Int32)dgvDv.Rows[i].Cells[0].Value;
                        if ( c > Convert.ToInt32(a))
                        {
                        sql = "Update tb_SuDungDV set ";
                        sql += "MaDV = N'" + cbbMDV.Text + "',";
                        sql += "SoLuong = N'" + nudSL.Value.ToString() + "'";
                        sql += "Where MaPhieu = N'" + cbbMP.Text + "' and STT = N'" + (c-1).ToString() + "'";
                        dtbase.DataChange(sql);
                    }
                }
                dgvDv.DataSource = dtbase.DataReader("Select STT,dv.MaDV,TenDV,SoLuong,DonGia,(DonGia * soLuong) as ThanhTien,NgayMua from tb_DichVu dv join tb_SuDungDV sd on dv.MaDV = sd.MaDV join tb_DatPhong dp on dp.maphieu = sd.maphieu where sd.maphieu = N'" + cbbMP.Text + "' order by stt asc");
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            cbbMP.Text = "";
            cbbMDV.Text = "";
            cbbDV.Text = "";
            cbbDg.Text = "";
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
            txtMKH.Text = "";
            txtNS.Text = "";
            txtSDT.Text = "";
            txtTKH.Text = "";
            txtTT.Text = "";
            nudSL.Value = 0;
        }

        private void dSDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrint pr = new frmPrint();
            frmPrint.a = "c";
            pr.ShowDialog();
        }
    }
}
