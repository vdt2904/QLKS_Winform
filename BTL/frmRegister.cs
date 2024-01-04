using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmRegister : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmRegister()
        {
            InitializeComponent();
        }
        private string MaHoa(string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] data = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashpass = "";
            foreach (byte it in data)
            {
                hashpass += it;
            }
            return hashpass;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if(txtTk.Text == ""|| txtMk.Text == "" || txtNMK.Text == "") {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!");
            }else if(txtTk.Text.Length < 6)
            {
                MessageBox.Show("Tài Khoản Phải Có từ 6 ký tự trở lên!");
            }
            else if (txtMk.Text.Length < 8 && txtNMK.Text.Length <8)
            {
                MessageBox.Show("Mật Khẩu Phải Có từ 8 ký tự trở lên!");
            }else if(txtNMK.Text != txtMk.Text)
            {
                MessageBox.Show("Mật Khẩu không trùng khớp!");
            }else if(cbbMNV.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {

                DataTable dt = dtbase.DataReader("select manv from tb_nhanvien where manv = N'" + cbbMNV.Text + "'");
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại nhân viên có mã nhân viên là  " + cbbMNV.Text);
                }
                else
                {
                    string sql = "";
                
                    sql = "insert into tb_Accout values(";
                    sql += "N'" + txtTk.Text + "',N'" + MaHoa(txtMk.Text) + "',N'user',N'"+cbbMNV.Text+"')";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Tạo Tài Khoản Thành Công!");
                    txtTk.Text = "";
                    txtMk.Text = "";
                    txtNMK.Text = "";
                    cbbMNV.Text = "";

                }
            }
        }
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void LoadMNV()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaNV from tb_NhanVien ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMNV.DataSource = dt;
            cbbMNV.ValueMember = "MaNV";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadMNV();
            cbbMNV.Text = "";
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.ShowDialog();
            LoadMNV();
            cbbMNV.Text = "";
        }
    }
}
