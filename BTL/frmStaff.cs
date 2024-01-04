using BTL.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmStaff : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmStaff()
        {
            InitializeComponent();
        }
        public void tangma()
        {
            int count = 0;
            count = dtg_ThongTin.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtg_ThongTin.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));
            if (chuoi2 + 1 < 10)
            {
                txt_MaNV.Text = "NV000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaNV.Text = "NV00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                txt_MaNV.Text = "NV0" + (chuoi2 + 1).ToString();
            }
        }
        public void add_TT()
        {
            cbb_MaNV.DataSource = dtbase.DataReader("select MaNV from tb_NhanVien");
            cbb_MaNV.ValueMember = "MaNV";
            cbb_TenNV.DataSource = dtbase.DataReader("select TenNV from tb_NhanVien");
            cbb_TenNV.ValueMember = "TenNV";
        }
        public void xoa()
        {
            cbb_MaNV.Text = "";
            cbb_TenNV.Text = "";
        }
        bool kt()
        {
            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã nhân viên!");
                txt_MaNV.Focus();
                return false;
            }
            if (txt_TenNV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên nhân viên!");
                txt_TenNV.Focus();
                return false;
            }
            if (txt_CCCD.Text == "")
            {
                MessageBox.Show("Bạn không được để trống CCCD!");
                txt_CCCD.Focus();
                return false;
            }
            if (txt_CCCD.Text.Length != 12)
            {
                MessageBox.Show("Sai định dạng CCCD!");
                txt_CCCD.Focus();
                return false;
            }
            return true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kt())
            {
                string sql = "insert into tb_NhanVien(MaNV,TenNV,CCCD,NgaySinh) values(N'";
                sql += txt_MaNV.Text + "',N'" + txt_TenNV.Text + "',N'" + txt_CCCD.Text + "',N'" + String.Format("{0:u}", dateTime_NS.Value.Date) + "')";
                dtbase.DataChange(sql);
                MessageBox.Show("Thêm thành công!");
                dtg_ThongTin.DataSource = dtbase.DataReader("select * from tb_NhanVien");
                add_TT();
                xoa();
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            dtg_ThongTin.DataSource = dtbase.DataReader("Select * from tb_NhanVien");
            tangma();
            add_TT();
            xoa();
        }

        private void dtg_ThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dtg_ThongTin.CurrentRow.Cells[0].Value.ToString();
            txt_TenNV.Text = dtg_ThongTin.CurrentRow.Cells[1].Value.ToString();
            txt_CCCD.Text = dtg_ThongTin.CurrentRow.Cells[2].Value.ToString();
            dateTime_NS.Value = (DateTime)dtg_ThongTin.CurrentRow.Cells[3].Value;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kt())
            {
                string sql = "update tb_NhanVien set TenNV =N'" + txt_TenNV.Text + "',CCCD ='" + txt_CCCD.Text + "',NgaySinh ='";
                sql += dateTime_NS.Value.ToString() + "' where MaNV = N'" + txt_MaNV.Text + "'";
                dtbase.DataChange(sql);
                MessageBox.Show("Sửa thành công!");
                dtg_ThongTin.DataSource = dtbase.DataReader("Select * from tb_NhanVien");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kt())
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete tb_NhanVien where MaNV= N'" + txt_MaNV.Text + "'";
                    dtbase.DataChange(sql);
                    dtg_ThongTin.DataSource = dtbase.DataReader("select * from tb_NhanVien");
                }
            }
        }

        private void btnLamMoi1_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_CCCD.Text = "";
            dtg_ThongTin.DataSource = dtbase.DataReader("select * from tb_NhanVien");
            tangma();
        }

        private void btnLamMoi2_Click(object sender, EventArgs e)
        {
            xoa();
            dtg_ThongTin.DataSource = dtbase.DataReader("select * from tb_NhanVien");
            tangma();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from tb_NhanVien where  ";
            if (cbb_MaNV.Text != "")
            {
                sql += " MaNV = N'" + cbb_MaNV.Text + "'";
            }
            if (cbb_TenNV.Text != "" && cbb_MaNV.Text != "")
            {
                sql += "and TenNV = N'" + cbb_TenNV.Text + "'";
            }
            else if (cbb_TenNV.Text != "" && cbb_MaNV.Text == "")
            {
                sql += "TenNV = N'" + cbb_TenNV.Text + "'";
            }
            dtg_ThongTin.DataSource = dtbase.DataReader(sql);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrint pr = new frmPrint();
            frmPrint.a = "b";
            pr.ShowDialog();
        }
    }
}
