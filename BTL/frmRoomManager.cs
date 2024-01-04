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

    public partial class frmRoomManager : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public static string userName = "";
        public static string userss = "";
        public frmRoomManager()
        {
            InitializeComponent();
        }
        Classes.Connectt cn = new Classes.Connectt();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void LoadcbbMP()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select MaPhong from tb_Phong ",conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);


            cbbMP2.DataSource = dt;
            cbbMP2.ValueMember = "MaPhong";
        }
        private void LoadcbbTP()
        {
            conn = cn.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select TenPhong from tb_Phong order by tenphong asc ", conn);
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);


            cbbTP.DataSource = dt;
/*            cbbTP.DisplayMember = "MaPhong";*/
            cbbTP.ValueMember = "TenPhong";
        }

        private void frmRoomManager_Load(object sender, EventArgs e)
        {
            frmLogin frmDN = new frmLogin();
            frmDN.ShowDialog();
            đăngNhậpToolStripMenuItem.Enabled = false;
            mnit.Text = userName;
            if(userss == "User")
            {
                taotk.Enabled = false;
                bcdt.Enabled = false;
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbLP1.Enabled = false;
                cbbMax1.Enabled = false;
                btnThem.Enabled = false;
                btnLamMoi.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }if(userss == "")
            {
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbGia2.Enabled = false;
                cbbLP1.Enabled = false;
                cbbLP2.Enabled = false;
                cbbMax1.Enabled = false;
                cbbMP2.Enabled = false;
                cbbSNTD2.Enabled = false;
                cbbTP.Enabled = false;
                cbbTT.Enabled = false;
                btnHuy2.Enabled = false;
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnThoat.Enabled = false; 
                btnTimKiem.Enabled = false;
                btnXoa.Enabled = false;
                đổiMậtKhẩuToolStripMenuItem.Enabled = false;
                taotk.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                quảnLýKháchHàngToolStripMenuItem.Enabled = false;
                quảnLýPhòngToolStripMenuItem.Enabled = false;
                thanhToánToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                button1.Enabled = false;
       
            }
            dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP ");
            tdma();
            LoadcbbMP();
            cbbMP2.Text = "";
            LoadcbbTP();
            cbbTP.Text = "";
            LoadCT();
            string sql = "update tb_phong set tinhtrang = N'Đang Sử Dụng' where maphong in (select maphong from tb_datphong where tinhtrang = N'Chưa Thanh Toán' and getdate() between ngayden and ngaydi)";
            dtbase.DataChange(sql);

        }
        private void tdma()
        {
            int count = 0;
            count = dgvDSP.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvDSP.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2));
            if(chuoi2 + 1 < 10)
            {
                txtMP1.Text = "MP000" + (chuoi2 + 1).ToString();
            }else if(chuoi2 + 1 < 100)
            {
                txtMP1.Text = "MP00" + (chuoi2 + 1).ToString();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPass fp = new frmPass();
            fp.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmDN = new frmLogin();
            frmDN.ShowDialog();
            đăngNhậpToolStripMenuItem.Enabled = false;
            mnit.Text = userName;
            if (userss == "User")
            {
                taotk.Enabled = false;
                bcdt.Enabled = false;
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbLP1.Enabled = false;
                cbbMax1.Enabled = false;
                btnThem.Enabled = false;
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            if (userss == "")
            {
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbGia2.Enabled = false;
                cbbLP1.Enabled = false;
                cbbLP2.Enabled = false;
                cbbMax1.Enabled = false;
                cbbMP2.Enabled = false;
                cbbSNTD2.Enabled = false;
                cbbTP.Enabled = false;
                cbbTT.Enabled = false;
                btnHuy2.Enabled = false;
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnThoat.Enabled = false;
                btnTimKiem.Enabled = false;
                btnXoa.Enabled = false;
                đổiMậtKhẩuToolStripMenuItem.Enabled = false;
                taotk.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                quảnLýKháchHàngToolStripMenuItem.Enabled = false;
                quảnLýPhòngToolStripMenuItem.Enabled = false;
                thanhToánToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                button1.Enabled = false;
            }
            if(userss == "Admin")
            {
                hienct();
            }
            this.Show();
        }
        void hienct()
        {
            txtMP1.Enabled = true;
            txtTP1.Enabled = true;
            cbbGia1.Enabled = true;
            cbbGia2.Enabled = true;
            cbbLP1.Enabled = true;
            cbbLP2.Enabled = true;
            cbbMax1.Enabled = true;
            cbbMP2.Enabled = true;
            cbbSNTD2.Enabled = true;
            cbbTP.Enabled = true;
            cbbTT.Enabled = true;
            btnHuy2.Enabled = true;
            btnLamMoi.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnTimKiem.Enabled = true;
            btnXoa.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            taotk.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
            quảnLýKháchHàngToolStripMenuItem.Enabled = true;
            quảnLýPhòngToolStripMenuItem.Enabled = true;
            thanhToánToolStripMenuItem.Enabled = true;
            báoCáoToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            button1.Enabled = true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMP1.Text == "" || txtTP1.Text == "" || cbbLP1.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đủ thông tin!");
            }else if(txtMP1.Text.Length < 6 && txtMP1.Text.Length>6)
            {
                MessageBox.Show("Mã phòng phải có 6 ký tự!");
            }
            else
            {
                string sql = "";
                DataTable dt = dtbase.DataReader("select * from tb_phong where tenphong = N'" + txtTP1.Text + "'");
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã có phòng!");
                }
                else
                {

                    if(cbbLP1.Text == "Phòng Suite")
                    {
                        sql = "insert into tb_Phong values(";
                        sql += "N'" + txtMP1.Text + "',N'" + txtTP1.Text + "',N'SUT',N'Chưa Sử Dụng')";
                        dtbase.DataChange(sql);
                        dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                        tdma();
                        LoadCT();
                    }else if (cbbLP1.Text == "Phòng Deluxe")
                    {
                        sql = "insert into tb_Phong values(";
                        sql += "N'" + txtMP1.Text + "',N'" + txtTP1.Text + "',N'DLX',N'Chưa Sử Dụng')";
                        dtbase.DataChange(sql);
                        dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                        tdma();
                        LoadCT();
                    }
                    else if (cbbLP1.Text == "Phòng Superior")
                    {
                        sql = "insert into tb_Phong values(";
                        sql += "N'" + txtMP1.Text + "',N'" + txtTP1.Text + "',N'SUP',N'Chưa Sử Dụng')";
                        dtbase.DataChange(sql);
                        dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                        tdma();
                        LoadCT();
                    }
                    else
                    {
                        sql = "insert into tb_Phong values(";
                        sql += "N'" + txtMP1.Text + "',N'" + txtTP1.Text + "',N'STD',N'Chưa Sử Dụng')";
                        dtbase.DataChange(sql);
                        dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                        tdma();
                        LoadCT();
                    }
                    LoadcbbMP();
                    LoadcbbTP();
                    cbbTP.Text = "";
                    cbbMP2.Text = "";
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            txtTP1.Text = "";
            cbbGia1.Text = "";
            cbbLP1.Text = "";
            cbbMax1.Text = "";
            dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
            tdma();
            LoadCT();
        }

        private void taotk_Click(object sender, EventArgs e)
        {
            frmRegister frmDK = new frmRegister();
            frmDK.ShowDialog();
        }
        public class LP
        {
            public string lp1 { get; set; }
            public int SNTD { get; set; }
            public float gia { get; set; }
        }
        List<LP> lPs = new List<LP>();

        private void cbbLP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lPs = new List<LP>()
            {
                new LP(){lp1 = "Phòng Standard" ,SNTD = 2 , gia = 150000},
                new LP(){lp1 = "Phòng Superior" ,SNTD = 3 , gia = 200000},
                new LP(){lp1 = "Phòng Deluxe" ,SNTD = 4 , gia = 250000},
                new LP(){lp1 = "Phòng Suite" ,SNTD = 5 , gia = 300000}

            };
            foreach(LP i in lPs)
            {
                if(i.lp1 == cbbLP1.Text)
                {
                    cbbMax1.Text = i.SNTD.ToString();
                    cbbGia1.Text = i.gia.ToString();
                }
            }
        }

        private void dgvDSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            cbbMP2.Text = dgvDSP.CurrentRow.Cells[0].Value.ToString();
            cbbTP.Text = dgvDSP.CurrentRow.Cells[1].Value.ToString();
            cbbLP2.Text = dgvDSP.CurrentRow.Cells[3].Value.ToString();
            cbbSNTD2.Text = dgvDSP.CurrentRow.Cells[4].Value.ToString();
            cbbGia2.Text = dgvDSP.CurrentRow.Cells[5].Value.ToString();
            cbbTT.Text = dgvDSP.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP where ";
            if(cbbMP2.Text != "")
            {
                sql += "MaPhong = N'" + cbbMP2.Text + "'";            
            }
            if (cbbTP.Text != "" && cbbMP2.Text != "") 
            {
                sql += "and TenPhong = N'" + cbbTP.Text + "'";
            }
            else if(cbbTP.Text != "" && cbbMP2.Text == "")
            {
                sql += "TenPhong =N'" + cbbTP.Text + "'";
            }
            if(cbbLP2.Text != "" && (cbbTP.Text != "" || cbbMP2.Text != ""))
            {
                sql += "and LoaiPhong = N'" + cbbLP2.Text + "'";
            }else if(cbbLP2.Text != "" && cbbTP.Text == "" && cbbMP2.Text == "")
            {
                sql += " LoaiPhong = N'" + cbbLP2.Text + "'";
            }
            if(cbbSNTD2.Text != "" &&(cbbLP2.Text != "" || cbbTP.Text != "" || cbbMP2.Text != ""))
            {
                sql += "and SoNguoiToiDa = N'" + cbbSNTD2.Text + "'";
            }else if (cbbSNTD2.Text != "" && cbbLP2.Text == "" && cbbTP.Text == "" && cbbMP2.Text == "")
            {
                sql += " SoNguoiToiDa = N'" + cbbSNTD2.Text + "'";
            }
            if(cbbGia2.Text != "" && (cbbSNTD2.Text != "" || cbbLP2.Text != "" || cbbTP.Text != "" || cbbMP2.Text != ""))
            {
                sql += "and Gia = N'" + cbbGia2.Text + "'";
            }else if (cbbGia2.Text != "" && cbbSNTD2.Text == "" && cbbLP2.Text == "" && cbbTP.Text == "" && cbbMP2.Text == "")
            {
                sql += " Gia = N'" + cbbGia2.Text + "'";
            }
            if(cbbTT.Text != "" &&(cbbGia2.Text != "" || cbbSNTD2.Text != "" || cbbLP2.Text != "" || cbbTP.Text != "" || cbbMP2.Text != ""))
            {
                sql += "and TinhTrang = N'" + cbbTT.Text + "'";
            }else if(cbbTT.Text != "" && cbbGia2.Text == "" && cbbSNTD2.Text == "" && cbbLP2.Text == "" && cbbTP.Text == "" && cbbMP2.Text == "")
            {
                sql += " TinhTrang = N'" + cbbTT.Text + "'";
            }
            dgvDSP.DataSource = dtbase.DataReader(sql);
            if (cbbLP2.Text == "Phòng Standard")
            {
                LoadCT();
                lbAll.Text = "Phòng Standard";
            }
            else if (cbbLP2.Text == "Phòng Superior")
            {
                LoadCT();
                lbAll.Text = "Phòng Superior";
            }
            else if (cbbLP2.Text == "Phòng Deluxe")
            {
                LoadCT();
                lbAll.Text = "Phòng Deluxe";
            }
            else if (cbbLP2.Text == "Phòng Suite")
            {
                LoadCT();
                lbAll.Text = "Phòng Suite";
            }
            dgvDSP.DataSource = dtbase.DataReader(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select * from tb_Phong where MaPhong = '";
            sql += cbbMP2.Text + "'";
            DataTable dt = dtbase.DataReader(sql);
            if(dt.Rows.Count > 0)
            {
                sql = "update tb_Phong set ";
                sql += "TinhTrang = N'" + cbbTT.Text + "' ";
                sql += "where MaPhong = N'" + cbbMP2.Text + "' ";
                dtbase.DataChange(sql);
                dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                LoadCT();
            }
        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {
            cbbMP2.Text = "";
            cbbTP.Text = "";
            cbbLP2.Text = "";
            cbbSNTD2.Text = "";
            cbbGia2.Text = "";
            cbbTT.Text = "";
            dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá Phòng "+cbbTP.Text+" này không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "";
                if(cbbMP2.Text != "")
                {
                    sql = "delete from tb_Phong where maphong = N'" + cbbMP2.Text + "' ";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Đã xoá Thành công!");
                    dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                    LoadcbbTP();
                    LoadcbbMP();
                }else if (cbbTP.Text != "")
                {
                    sql = "delete from tb_Phong where tenphong = N'" + cbbTP.Text + "' ";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Đã xoá Thành công!");
                    dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                    LoadcbbTP();
                    LoadcbbMP();
                }
                else
                {
                    MessageBox.Show("Vui Lòng nhập đủ!");
                }
                cbbTP.Text = "";
                cbbMP2.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "select * from tb_Phong where MaPhong = '";
            sql += cbbMP2.Text + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {

                if (cbbMP2.Text == "" || cbbTP.Text == "" || cbbLP2.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập đủ thông tin!");
                }
                else if (txtMP1.Text.Length < 6 && txtMP1.Text.Length > 6)
                {
                    MessageBox.Show("Mã phòng phải có 6 ký tự!");
                }
                else
                {
                    sql = "select * from tb_Phong where TenPhong = '";
                    sql += cbbTP.Text + "'";
                    DataTable ds = dtbase.DataReader(sql);
                    if (ds.Rows.Count > 0)
                    {
                        MessageBox.Show("Đã có phòng!");
                    }
                    else
                    {

                        if (cbbLP2.Text == "Phòng Standard")
                        {
                            sql = "update tb_Phong set ";
                            sql += "TinhTrang = N'" + cbbTT.Text + "', ";
                            sql += "TenPhong = N'" + cbbTP.Text + "', ";
                            sql += "MaLP = N'STD' ";
                            sql += "where MaPhong = N'" + cbbMP2.Text + "' ";
                            dtbase.DataChange(sql);
                            dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                            LoadCT();
                        }
                        else if (cbbLP2.Text == "Phòng Superior")
                        {
                            sql = "update tb_Phong set ";
                            sql += "TinhTrang = N'" + cbbTT.Text + "', ";
                            sql += "TenPhong = N'" + cbbTP.Text + "', ";
                            sql += "MaLP = N'SUP' ";
                            sql += "where MaPhong = N'" + cbbMP2.Text + "' ";
                            dtbase.DataChange(sql);
                            dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                            LoadCT();
                        }
                        else if (cbbLP2.Text == "Phòng Suite")
                        {
                            sql = "update tb_Phong set ";
                            sql += "TinhTrang = N'" + cbbTT.Text + "', ";
                            sql += "TenPhong = N'" + cbbTP.Text + "', ";
                            sql += "MaLP = N'SUT' ";
                            sql += "where MaPhong = N'" + cbbMP2.Text + "' ";
                            dtbase.DataChange(sql);
                            dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                            LoadCT();
                        }
                        else if (cbbLP2.Text == "Phòng Deluxe")
                        {
                            sql = "update tb_Phong set ";
                            sql += "TinhTrang = N'" + cbbTT.Text + "', ";
                            sql += "TenPhong = N'" + cbbTP.Text + "', ";
                            sql += "MaLP = N'DLX' ";
                            sql += "where MaPhong = N'" + cbbMP2.Text + "' ";
                            dtbase.DataChange(sql);
                            dgvDSP.DataSource = dtbase.DataReader("select MaPhong, TenPhong, tb_Phong.MaLP, LoaiPhong, SoNguoiToiDa, Gia, TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP");
                            LoadCT();
                        }
                        cbbMP2.Text = "";
                        cbbTP.Text = "";
                        cbbLP2.Text = "";
                        cbbSNTD2.Text = "";
                        cbbGia2.Text = "";
                        cbbTT.Text = "";
                    }
                }
            }
        }

        private void dgvDSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row2 in dgvDSP.Rows)
            {
                string row1 = Convert.ToString(row2.Cells[6].Value);
                if (row1 == "Đang Sử Dụng")
                {
                    row2.DefaultCellStyle.BackColor = Color.Red;
                }
                else if(row1 == "Đang Bảo Trì")
                {
                    row2.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void LoadCT()
        {
            int a=0,b=0,c=0;
            foreach(DataGridViewRow row2 in dgvDSP.Rows)
            {
                string row1 = Convert.ToString(row2.Cells[6].Value);
                if (row1 == "Đang Sử Dụng")
                {
                    a++;

                }else if(row1 == "Đang Bảo Trì")
                {
                    b++;
                }else
                {
                    c++;
                }
            }
            lbDBT.Text = "Số Phòng Đang Bảo Trì: " + b.ToString();
            lbSPDSD.Text = "Số Phòng Đang Sử Dụng: " + a.ToString();
            lbPT.Text = "Số Phòng Chưa Sử Dụng: " + c.ToString();
            lbTSP.Text = "Tổng Số Phòng: " + (a + b + c).ToString();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frc = new frmCustomer();
            frc.ShowDialog();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSP sp = new frmSP();
            sp.ShowDialog();
                
        }

        private void mnit_TextChanged(object sender, EventArgs e)
        {
            if(mnit.Text == "Admin" || mnit.Text == "admin")
            {
                taotk.Enabled = true;
                bcdt.Enabled = true;
                txtMP1.Enabled = true;
                txtTP1.Enabled = true;
                cbbGia1.Enabled = true;
                cbbLP1.Enabled = true;
                cbbMax1.Enabled = true;
                btnThem.Enabled = true;
                btnLamMoi.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }else
            {
                taotk.Enabled = false;
                bcdt.Enabled = false;
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbLP1.Enabled = false;
                cbbMax1.Enabled = false;
                btnThem.Enabled = false;
                btnLamMoi.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookRoom frmBook = new frmBookRoom();
            frmBook.ShowDialog();
            dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP ");

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmService frmsv = new frmService();
            frmsv.ShowDialog();
        }

        private void dgvDSP_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmDN = new frmLogin();
            frmDN.ShowDialog();
            đăngNhậpToolStripMenuItem.Enabled = false;
            mnit.Text = userName;
            if (userss == "User")
            {
                taotk.Enabled = false;
                bcdt.Enabled = false;
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbLP1.Enabled = false;
                cbbMax1.Enabled = false;
                btnThem.Enabled = false;
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            if (userss == "")
            {
                txtMP1.Enabled = false;
                txtTP1.Enabled = false;
                cbbGia1.Enabled = false;
                cbbGia2.Enabled = false;
                cbbLP1.Enabled = false;
                cbbLP2.Enabled = false;
                cbbMax1.Enabled = false;
                cbbMP2.Enabled = false;
                cbbSNTD2.Enabled = false;
                cbbTP.Enabled = false;
                cbbTT.Enabled = false;
                btnHuy2.Enabled = false;
                btnLamMoi.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnThoat.Enabled = false;
                btnTimKiem.Enabled = false;
                btnXoa.Enabled = false;
                đổiMậtKhẩuToolStripMenuItem.Enabled = false;
                taotk.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                quảnLýKháchHàngToolStripMenuItem.Enabled = false;
                quảnLýPhòngToolStripMenuItem.Enabled = false;
                thanhToánToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                button1.Enabled = false;
            }
            if (userss == "Admin")
            {
                hienct();
            }
            this.Show();
        }

        private void thanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPay frm = new frmPay();
            frm.ShowDialog();
            dgvDSP.DataSource = dtbase.DataReader("select MaPhong,TenPhong,tb_Phong.MaLP,LoaiPhong,SoNguoiToiDa,Gia,TinhTrang from tb_Phong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP ");
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill bill = new frmBill();
            bill.Show();
        }

        private void bcdt_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
        }
    }
}
