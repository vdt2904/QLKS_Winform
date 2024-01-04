using BTL.Classes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Print
{
    public partial class frmPrint : Form
    {
        DataSet dset;
        SqlConnection conn;
        SqlDataAdapter da;

        DataSet ReadDataSet(string sql)
        {
            dset = new DataSet();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dset);


            return dset;
        }
        public frmPrint()
        {
            InitializeComponent();
        }
        public static string a = "";
        public static string b ="";
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            if (a == "a")
            {
                string sql = "select * from tb_KhachHang";

                DataSet ds;
                ds = ReadDataSet(sql);

 
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\Admin\\Documents\\Nam_3\\ky_1\\LTTQ\\BTL_Nhom\\BTL\\BTL\\BTL\\Print\\Report1.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rp = new ReportDataSource();
                    rp.Name = "tb_KhachHang";

                    rp.Value = ds.Tables[0];

                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.LocalReport.DataSources.Add(rp);

                    reportViewer1.RefreshReport();
                }

            }
            if(a == "b")
            {
                string sql = "select * from tb_nhanvien";
                DataSet ds;
                ds = ReadDataSet(sql);


                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\Admin\\Documents\\Nam_3\\ky_1\\LTTQ\\BTL_Nhom\\BTL\\BTL\\BTL\\Print\\Report2.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rp = new ReportDataSource();
                    rp.Name = "tb_NhanVien";

                    rp.Value = ds.Tables[0];

                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.LocalReport.DataSources.Add(rp);

                    reportViewer1.RefreshReport();
                }
            }
            if (a == "c")
            {
                string sql = "select * from tb_DichVu";
                DataSet ds;
                ds = ReadDataSet(sql);


                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\Admin\\Documents\\Nam_3\\ky_1\\LTTQ\\BTL_Nhom\\BTL\\BTL\\BTL\\Print\\Report3.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rp = new ReportDataSource();
                    rp.Name = "tb_DichVu";

                    rp.Value = ds.Tables[0];

                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.LocalReport.DataSources.Add(rp);

                    reportViewer1.RefreshReport();
                }
            }
            if (a == "d")
            {

                DataSet ds;
                ds = ReadDataSet(b);


                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\Admin\\Documents\\Nam_3\\ky_1\\LTTQ\\BTL_Nhom\\BTL\\BTL\\BTL\\Print\\Report4.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rp = new ReportDataSource();
                    rp.Name = "tb_HoaDon";

                    rp.Value = ds.Tables[0];

                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.LocalReport.DataSources.Add(rp);

                    reportViewer1.RefreshReport();
                }
            }


        }
    }
}
