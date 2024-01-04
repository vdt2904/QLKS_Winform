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

namespace BTL
{
    public partial class frmCustomer : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void tdma()
        {
            int count = 0;
            count = dgvKh.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvKh.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));
            if (chuoi2 + 1 < 10)
            {
               txtMKH.Text = "KH000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtMKH.Text = "KH00" + (chuoi2 + 1).ToString();
            }else if(chuoi2 +1 < 1000)
            {
                txtMKH.Text = "KH0" + (chuoi2 + 1).ToString();
            }
            LoadcbbMKH();
            LoadcbbTKH();
            LoadcbbCCCD();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTKH.Text == "" || cbbgt.Text == "" || txtCCCD.Text == "" || cbbDC1.Text == "" || txtSDT.Text == "" || cbbNote.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else if(txtCCCD.Text.Length !=12)
            {
                MessageBox.Show("Sai định dạng CCCD!");
            }else if(txtSDT.Text.Length <9 || txtSDT.Text.Length > 10)
            {
                MessageBox.Show("Sai định dạng Số điện thoại!");
            }
            else
            {
                string sql = "";
                sql = "select * from tb_KhachHang where CCCD = '";
                sql += txtCCCD.Text + "'";
                DataTable dt = dtbase.DataReader(sql);
                if (dt.Rows.Count == 0)
                {
                    sql = "insert into tb_KhachHang values(";
                    sql += "N'"+txtMKH.Text+ "',N'" + txtTKH.Text + "',N'" + cbbgt.Text + "',N'" + txtCCCD.Text + "',N'"+ String.Format("{0:u}", dtNS.Value.Date) + "',N'" + cbbDC1.Text + "',N'" + txtSDT.Text + "',N'" + cbbNote.Text + "')";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Thêm Khách Hàng Thành Công!");
                    dgvKh.DataSource = dtbase.DataReader("Select * from tb_KhachHang");
                    xoad();
                   
                }
                else
                {
                    sql = "select * from tb_KhachHang where CCCD = '";
                    sql += txtCCCD.Text + "' and TenKH NOT LIKE N'%" + txtTKH.Text + "%'";
                    DataTable dt1 = dtbase.DataReader(sql);
                    if(dt1.Rows.Count > 0)
                    {
                        MessageBox.Show("CCCD đã trùng!");
                        dgvKh.DataSource = dtbase.DataReader(sql);

                    }
                    else
                    {
                        sql = "insert into tb_KhachHang values(";
                        sql += "N'" + txtMKH.Text + "',N'" + txtTKH.Text + "',N'" + cbbgt.Text + "',N'" + txtCCCD.Text + "',N'" + String.Format("{0:u}", dtNS.Value.Date) + "',N'" + cbbDC1.Text + "',N'" + txtSDT.Text + "',N'" + cbbNote.Text + "')";
                        dtbase.DataChange(sql);
                        MessageBox.Show("Thêm Khách Hàng Thành Công!");
                        dgvKh.DataSource = dtbase.DataReader("Select * from tb_KhachHang");
                        xoad();
                    }
                }

            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvKh.DataSource = dtbase.DataReader("select * from tb_KhachHang");

            xoad();
            xoap();
        }

        private void dgvKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMKH.Text = dgvKh.CurrentRow.Cells[0].Value.ToString();
            txtTKH.Text = dgvKh.CurrentRow.Cells[1].Value.ToString();
            cbbgt.Text = dgvKh.CurrentRow.Cells[2].Value.ToString();
            txtCCCD.Text = dgvKh.CurrentRow.Cells[3].Value.ToString();
            dtNS.Value = (DateTime)dgvKh.CurrentRow.Cells[4].Value;
            cbbDC1.Text = dgvKh.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = dgvKh.CurrentRow.Cells[6].Value.ToString();
            cbbNote.Text = dgvKh.CurrentRow.Cells[7].Value.ToString();
            cccd = txtCCCD.Text;
        }
        private void xoad()
        {
            tdma();
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtTKH.Text = "";
            cbbDC1.Text = "";
            cbbgt.Text = "";
            cbbNote.Text = "";
            dgvKh.DataSource = dtbase.DataReader("select * from tb_KhachHang");
            xoap();
        }
        private void xoap()
        {
            tdma();
            cbbTenKH.Text = "";
            cbbMKH.Text = "";
            cbbCCCD.Text = "";
            cbbNote2.Text = "";
        }
        string cccd = "";
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select * from tb_KhachHang where makh = '";
            sql += txtMKH.Text + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count == 1)
            {
                if (txtTKH.Text == "" || cbbgt.Text == "" || txtCCCD.Text == "" || cbbDC1.Text == "" || txtSDT.Text == ""|| cbbNote.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else if (txtCCCD.Text.Length != 12)
                {
                    MessageBox.Show("Sai định dạng CCCD!");
                }
                else if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 10)
                {
                    MessageBox.Show("Sai định dạng Số điện thoại!");
                }
                else
                {
                    sql = "select * from tb_KhachHang where cccd = '";
                    sql += txtCCCD.Text + "'";
                    DataTable dta = dtbase.DataReader(sql);
                    if(dta.Rows.Count == 0)
                    {
                        sql = "update tb_KhachHang set ";
                        sql += "TenKH = N'" + txtTKH.Text + "', ";
                        sql += "GioiTinh = N'" + cbbgt.Text + "', ";
                        sql += "CCCD = N'" + txtCCCD.Text + "', ";
                        sql += "NgaySinh = N'"+ String.Format("{0:u}", dtNS.Value.Date) + "',";
                        sql += "DiaChi = N'" + cbbDC1.Text + "', ";
                        sql += "SoDienThoai = N'" + txtSDT.Text + "', ";
                        sql += "Note = N'" + cbbNote.Text + "'";
                        sql += "Where MaKh = N'" + txtMKH.Text + "'";
                        dtbase.DataChange(sql);
                        MessageBox.Show("Đã sửa thành công!");
                        dgvKh.DataSource = dtbase.DataReader("select * from tb_Khachhang");
                        cccd = txtCCCD.Text;
                        xoad();
                    }else if (dta.Rows.Count == 1)
                    {
                        sql = "update tb_KhachHang set ";
                        sql += "TenKH = N'" + txtTKH.Text + "', ";
                        sql += "GioiTinh = N'" + cbbgt.Text + "', ";
                        sql += "CCCD = N'" + txtCCCD.Text + "', ";
                        sql += "NgaySinh = N'" + String.Format("{0:u}", dtNS.Value.Date) + "',";
                        sql += "DiaChi = N'" + cbbDC1.Text + "', ";
                        sql += "SoDienThoai = N'" + txtSDT.Text + "', ";
                        sql += "Note = N'" + cbbNote.Text + "'";
                        sql += "Where MaKh = N'" + txtMKH.Text + "'";
                        dtbase.DataChange(sql);
                        MessageBox.Show("Đã sửa thành công!");
                        dgvKh.DataSource = dtbase.DataReader("select * from tb_Khachhang");
                        cccd = txtCCCD.Text;
                        xoad();
                    }
                    else
                    {
                        MessageBox.Show("CCCD đã trùng!");
                        dgvKh.DataSource = dtbase.DataReader("select * from tb_khachhang where cccd = N'" + txtCCCD.Text + "'");
                    }
                }
            }
            else
            {
                MessageBox.Show("CCCD đã trùng!");
                dgvKh.DataSource = dtbase.DataReader(sql);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá Khách Hàng " + txtTKH.Text + " này ra khỏi danh sách không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "";
                sql = "delete from tb_KhachHang where makh = N'" + txtMKH.Text + "' ";
                dtbase.DataChange(sql);
                MessageBox.Show("Đã xoá Thành công!");
                dgvKh.DataSource = dtbase.DataReader("select *from tb_KhachHang");
                xoad();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xoad();
        }
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void LoadcbbMKH()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaKh from tb_KhachHang ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMKH.DataSource = dt;
            cbbMKH.ValueMember = "MaKH";
        }
        private void LoadcbbTKH()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select TenKH from tb_KhachHang ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTenKH.DataSource = dt;
            cbbTenKH.ValueMember = "TenKH";
        }
        private void LoadcbbCCCD()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select CCCD from tb_KhachHang ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCCCD.DataSource = dt;
            cbbCCCD.ValueMember = "CCCD";
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            string sql = "";
            
            sql = "select * from tb_Khachhang where ";
            if(cbbMKH.Text != "")
            {
                sql += "MaKH = N'" + cbbMKH.Text + "' ";
            }
            if(cbbTenKH.Text != "" && cbbMKH.Text != "")
            { 
                sql += "And TenKh = N'" + cbbTenKH.Text + "' ";
            }
            else if(cbbTenKH.Text != "" && cbbMKH.Text == "")
            {
                sql += "TenKh = N'" + cbbTenKH.Text + "' ";
            }
            if(cbbCCCD.Text != "" && (cbbTenKH.Text != "" || cbbMKH.Text != ""))
            {
                sql += "And CCCD = N'" + cbbCCCD.Text + "' ";
            }else if (cbbCCCD.Text != "" && cbbTenKH.Text == "" && cbbMKH.Text == "")
            {
                sql += " CCCD = N'" + cbbCCCD.Text + "' ";
            }
            if(cbbNote2.Text != "" && (cbbCCCD.Text != "" ||cbbTenKH.Text != "" || cbbMKH.Text != ""))
            {
                sql += "And note = N'" + cbbNote2.Text + "' ";
            }else if(cbbNote2.Text != "" && cbbCCCD.Text == "" && cbbTenKH.Text == "" && cbbMKH.Text == "")
            {
                sql += " note = N'" + cbbNote2.Text + "' ";
            }
            dgvKh.DataSource =dtbase.DataReader(sql);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            dgvKh.DataSource = dtbase.DataReader("select *from tb_KhachHang");
            xoap();
        }

        private void dgvKh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row2 in dgvKh.Rows)
            {
                string row1 = Convert.ToString(row2.Cells[7].Value);
                if(row1 != "none")
                {
                    row2.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmPrint pr = new frmPrint();
            frmPrint.a = "a";
            pr.ShowDialog();
        }
    }
}
