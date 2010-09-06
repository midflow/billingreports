using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.Reporting.WebForms;

public partial class rptKiemke2_30062010 : System.Web.UI.Page
{
    public string thisConnectionString =
       ConfigurationManager.ConnectionStrings[
       "ConnectionString"].ConnectionString;
    DataTable dtToChuc = new BRDataSet.dsKiemKeNo2DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        BindReport();
    }
    private void BindReport()
    {
        CultureInfo vn = new CultureInfo("vi-VN");  
        //int iThang = Convert.ToInt32(Request.Params["NgayThang"].ToString().Substring(3, 2));
        //int iNam = Convert.ToInt32(Request.Params["NgayThang"].ToString().Substring(6, 4));
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;

        //string cmdQuery = "Select LoaiThueBao As DoiTuong, TenThueBao, MCQ As MaSo, Status As TinhTrang " +
        //                  "From tblThueBao_temp A,tblLoaiThueBao B Where A.LoaiThueBaoID = B.ID Order By A.TenThueBao";
        int huyen = int.Parse(Request.Params["huyen"]);
        string cmdQuery;
        SqlCommand cmd;
        if (huyen == 0)
        {
            cmdQuery = "BaoCaoKiemKe2New_30062010";
            cmd = new SqlCommand(cmdQuery);
        }           
        else
        {
            cmdQuery = "BaoCaoKiemKe2_HuyenNew_30062010";
            cmd = new SqlCommand(cmdQuery);
            cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = int.Parse(Request.Params["huyen"].ToString());
        }


        cmd.Parameters.Add("@ngaythang", SqlDbType.NVarChar).Value = Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy");
        //cmd.Parameters.Add("@nam", SqlDbType.Int).Value = iNam;
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandTimeout = 0;
        con.Open();
        SqlDataReader oda = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        DataSet ds = new BRDataSet();
        ds.Tables["dsKiemKeNo21"].Load(oda);
        ReportDataSource rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsKiemKeNo21";
        rds.Value = ds.Tables["dsKiemKeNo21"];
        ReportParameter[] rppDate = new ReportParameter[1];
        rppDate[0] = new ReportParameter("NgayLap", Convert.ToDateTime(Request.Params["NgayThang"]).ToString("dd/MM/yyyy"));
        rptKiemKeNo1.LocalReport.ReportPath = "rptKiemKe2_30062010.rdlc";
        rptKiemKeNo1.LocalReport.DataSources.Clear();
        rptKiemKeNo1.LocalReport.DataSources.Add(rds);
        rptKiemKeNo1.LocalReport.SetParameters(rppDate);
        rptKiemKeNo1.LocalReport.Refresh();
    }  
}
