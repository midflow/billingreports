using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

public partial class Report3 : System.Web.UI.Page
{
    private string HanBc;
    private string TuNgay;
    private string DenNgay;
    public string thisConnectionString =
       ConfigurationManager.ConnectionStrings[
       "ConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Han_BC"] != null)
        {
            HanBc = Request.QueryString["han_bc"];
            TuNgay = Request.QueryString["tu_ngay"];
            DenNgay = Request.QueryString["deb_ngay"];
        }

        GetData();
    }

    private void GetData()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;

        string cmdQuery = "SELECT * from tblTest";

        // Create the OracleCommand object
        SqlCommand cmd = new SqlCommand(cmdQuery);
        cmd.Connection = con;        
        cmd.CommandType = CommandType.Text;
        con.Open();
        SqlDataReader oda = cmd.ExecuteReader(CommandBehavior.CloseConnection); 
        DataTable dt = new DataTable();
        dt.Load(oda);
        //DataTable dt = oda.
        ReportDataSource dts = new ReportDataSource("BRDataSet_DS_TinhHinhTC", dt);
        
        ReportViewer1.LocalReport.DataSources.Clear();
        ReportViewer1.LocalReport.DataSources.Add(dts);

        ReportViewer1.LocalReport.Refresh();
    }
}
