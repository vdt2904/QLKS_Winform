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
    public partial class frmLogin : Form
    {
        public static string user;
        public static string pass;
        public static string userss;

        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {

            if (txtTK.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập");

            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");

            }
            else if (rdoAdmin.Checked == false && rdoUser.Checked == false)
            {
                MessageBox.Show("Chưa chọn kiểu đăng nhập");
            }
            else
            {
                
                if (rdoAdmin.Checked == true)
                {
                    
                    string sql = "";
                    try
                    {
                        byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtMK.Text);
                        byte[] data = new MD5CryptoServiceProvider().ComputeHash(temp);
                        string hashpass = "";
                        foreach(byte it in data)
                        {
                            hashpass += it;
                        }
                        sql = "select * from tb_Accout where userName = '" + txtTK.Text + "' and passWord = '" + hashpass + "' and userss = '" + rdoAdmin.Text + "'";
                        DataTable dn = dtbase.DataReader(sql);
                        if (dn.Rows.Count > 0)
                        {
                            userss = "admin";
                            user = txtTK.Text;
                            pass = hashpass;
                            frmRoomManager.userName = txtTK.Text;
                            frmRoomManager.userss = rdoAdmin.Text;
                            
                            this.Close();
                        }
                        else {
                            MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {

                    string sql = "";
                    try
                    {
                        byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtMK.Text);
                        byte[] data = new MD5CryptoServiceProvider().ComputeHash(temp);
                        string hashpass = "";
                        foreach (byte it in data)
                        {
                            hashpass += it;
                        }
                        sql = "select * from tb_Accout where userName = '" + txtTK.Text + "' and passWord = '" + hashpass + "' and userss = '" + rdoUser.Text + "'";
                        DataTable dn = dtbase.DataReader(sql);
                        if (dn.Rows.Count > 0)
                        {
                            userss = "user";
                            user = txtTK.Text;
                            pass = hashpass;
                            frmRoomManager.userName = txtTK.Text;
                            frmRoomManager.userss = rdoUser.Text;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmRoomManager.userName = "";
            frmRoomManager.userss = "";
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
