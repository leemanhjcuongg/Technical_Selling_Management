using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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

namespace Thuchanh
{
    public partial class BaoCaoSanPham : Form
    {
        static String constr = @"
            Data Source=CUONG\CUONG;
            Integrated Security=True;
            Initial Catalog=KinhDoanhMayTinh";
        rptSanPham rptSanPham = new rptSanPham();

        public BaoCaoSanPham()
        {
            InitializeComponent();
        }

        private void BaoCaoSanPham_Load(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(constr))
            //{
            //    conn.Open();
            //    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vvSP_KhongBan_2021", conn))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            //        {
            //            DataTable dt = new DataTable();
            //            adapter.Fill(dt);

            //            rptSanPham.SetDataSource(dt);
            //            crystalReportViewer1.ReportSource = rptSanPham;
            //            crystalReportViewer1.Refresh();
            //        }
            //    }
            //}
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"D:\C_SHARP\QLKDMT_BTL_CSHARP\Thuchanh\rptSanPham.rpt");
            rpt.SetParameterValue("NguoiLap", "Lê Mạnh Cường");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnSetNguoiLap_Click(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"D:\C_SHARP\QLKDMT_BTL_CSHARP\Thuchanh\rptSanPham.rpt");
            

            ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["NguoiLap"];
            ParameterValues pv = new ParameterValues();

            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = tbNguoiLap.Text;

            pv.Add(pdv);

            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            rptSanPham rpt = new rptSanPham();
            rpt.Load(@"D:\C_SHARP\QLKDMT_BTL_CSHARP\Thuchanh\rptSanPham.rpt");

            rpt.SetParameterValue("NguoiLap", "Lê Mạnh Cường");
            crystalReportViewer1.SelectionFormula = "{tblSanPham.iNamSX} = "+tbLoc.Text;
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
