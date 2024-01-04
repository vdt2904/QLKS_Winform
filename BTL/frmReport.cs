using BTL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
    public partial class frmReport : Form
    {
        DataBaseProcess data = new DataBaseProcess();
        public frmReport()
        {
            InitializeComponent();
        }
        public void Loaddothi()
        {
            string kn = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            string cl = "select *from Thongkenam(" + int.Parse(comboBox3.Text) + ")";
            SqlConnection con = new SqlConnection(kn);
            SqlCommand cmd = new SqlCommand(cl, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            con.Open();
            chart1.DataSource = ds;

            chart1.Series["Tháng 1"].YValueMembers = "Thang1";
            chart1.Series["Tháng 2"].YValueMembers = "Thang2";
            chart1.Series["Tháng 3"].YValueMembers = "Thang3";
            chart1.Series["Tháng 4"].YValueMembers = "Thang4";
            chart1.Series["Tháng 5"].YValueMembers = "Thang5";
            chart1.Series["Tháng 6"].YValueMembers = "Thang6";
            chart1.Series["Tháng 7"].YValueMembers = "Thang7";
            chart1.Series["Tháng 8"].YValueMembers = "Thang8";
            chart1.Series["Tháng 9"].YValueMembers = "Thang9";
            chart1.Series["Tháng 10"].YValueMembers = "Thang10";
            chart1.Series["Tháng 11"].YValueMembers = "Thang11";
            chart1.Series["Tháng 12"].YValueMembers = "Thang12";


            chart1.Titles.Add("Bảng Doanh Thu");
            

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            for(int i = DateTime.Now.Year - 5;i<= DateTime.Now.Year;i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseProcess da = new DataBaseProcess();
            DataTable ds = new DataTable();
            if (comboBox2.Text.Trim() == "" && comboBox3.Text.Trim() == "")
                MessageBox.Show("Chua co  thong tin tong ke");
            else if (comboBox2.Text.Trim() == "" && comboBox3.Text != "")
            {
                chart1.Titles.Clear();
                ds = da.DataReader("select isnull(dbo.Tongtiennam(" + int.Parse(comboBox3.Text) + "), 0)");
                label9.Text = ds.Rows[0][0].ToString();
                chart1.Visible = true;
                Loaddothi();
                
            }
            else if (comboBox2.Text.Trim() != "" && comboBox3.Text != "")

            {
                chart1.Titles.Clear();
                ds = da.DataReader("select Thang" + comboBox2.Text + " from Thongkenam(" + int.Parse(comboBox3.Text) + ")");
                label9.Text = ds.Rows[0][0].ToString();
                chart1.Visible = true;
                Loaddothi();
            }
            else
            {
                MessageBox.Show("Chua co thong tin nam");
            }
        }
    }
}
