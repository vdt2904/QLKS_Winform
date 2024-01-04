using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmPass : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmPass()
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
            string sql = "";
            if(txtTk.Text == "" || txtmkc.Text == ""|| txtmkm.Text == "" || txtmkmm.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!");
            }else if(txtmkm.Text.Length <8 && txtmkmm.Text.Length < 8)
            {
                MessageBox.Show("Mật Khẩu Phải Có 8 ký tự trở lên!");
            }
            else if(txtmkmm.Text != txtmkm.Text)
            {
                MessageBox.Show("Mật Khẩu không trùng khớp!");
            }else if(txtmkc.Text == txtmkm.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!");
            }
            else
            {

                if(MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                        sql = "select * from tb_Accout where userName = '" + txtTk.Text + "' and passWord = '" + MaHoa(txtmkc.Text) + "'";
                        DataTable dn = dtbase.DataReader(sql);
                        if(dn.Rows.Count > 0) {
                            sql = "update tb_Accout set ";
                            sql += "passWord = N'" + MaHoa(txtmkm.Text) + " ' ";
                            sql += "where userName = N'" + txtTk.Text + "' and ";
                            sql += "passWord = N'" + MaHoa(txtmkc.Text) + "'";
                            dtbase.DataChange(sql);
                            MessageBox.Show("Đổi mật khẩu thành công!");
                        }

                }
            }

        }

        private void frmPass_Load(object sender, EventArgs e)
        {
            txtTk.Text = frmRoomManager.userName;
        }

        private void btnHuy3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
