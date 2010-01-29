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

public partial class rptKiemke1 : System.Web.UI.Page
{
    public string thisConnectionString =
       ConfigurationManager.ConnectionStrings[
       "ConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindReport();
    }
    private void BindReport()
    {
        CultureInfo vn = new CultureInfo("vi-VN");   
        //int iThang = Convert.ToInt32(Request.Params["NgayThang"].ToString().Substring(3, 2));
       // int iNam = Convert.ToInt32(Request.Params["NgayThang"].ToString().Substring(6, 4));
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;

        //string cmdQuery = "Select LoaiThueBao As DoiTuong, TenThueBao, MCQ As MaSo, Status As TinhTrang " +
        //                  "From tblThueBao_temp A,tblLoaiThueBao B Where A.LoaiThueBaoID = B.ID Order By A.TenThueBao";
        string type = Request.Params["id"];
        string huyen = Request.Params["huyen"];
        string cmdQuery;
        SqlCommand cmd;
        if (type == "0" && huyen == "0")
        {
            cmdQuery = "select * from tblbckk1 where tongtoanbo<>0 or tongso<> 0 and ngaythang = '" + Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy") + "'";
            //cmdQuery = "BaoCaoKiemKe1";           
            cmd = new SqlCommand(cmdQuery);
            //cmd.Parameters.Add("@ngaybaocao", SqlDbType.DateTime).Value = Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy");
            //cmd.Parameters.Add("@doituong", SqlDbType.Int).Value = int.Parse(Request.Params["id"].ToString());
            //cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = int.Parse(Request.Params["huyen"].ToString());
        }
        else if (type== "0")
        {
            cmdQuery = "select * from tblbckk1 where donviid=" + huyen + " and ngaythang = '" + Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy") + "'";
            //cmdQuery = "BaoCaoKiemKe1";           
            cmd = new SqlCommand(cmdQuery);
            //cmdQuery = "BaoCaoKiemKe1_huyen";
            //cmd = new SqlCommand(cmdQuery);
            //cmd.Parameters.Add("@ngaybaocao", SqlDbType.DateTime).Value = Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy");
            ////cmd.Parameters.Add("@doituong", SqlDbType.Int).Value = int.Parse(Request.Params["id"].ToString());
            //cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = int.Parse(Request.Params["huyen"].ToString());

        }
        else if (huyen == "0")
        {
            cmdQuery = "select * from tblbckk1 where khid=" + type + " and ngaythang = '" + Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy") + "'";
            //cmdQuery = "BaoCaoKiemKe1";           
            cmd = new SqlCommand(cmdQuery);
            //cmdQuery = "BaoCaoKiemKe_doituong";
            //cmd = new SqlCommand(cmdQuery);
            //cmd.Parameters.Add("@ngaybaocao", SqlDbType.DateTime).Value = Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy");
            //cmd.Parameters.Add("@doituong", SqlDbType.Int).Value = int.Parse(Request.Params["id"].ToString());
            //cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = int.Parse(Request.Params["huyen"].ToString());
        }
        else
        {
            cmdQuery = "select * from tblbckk1 where donviid=" + huyen + " and khid = " + type + " and ngaythang='" + Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy") + "'";
            //cmdQuery = "BaoCaoKiemKe1";           
            cmd = new SqlCommand(cmdQuery);
            //cmdQuery = "BaoCaoKiemKe_huyen_doituong";
            //cmd = new SqlCommand(cmdQuery);
            //cmd.Parameters.Add("@ngaybaocao", SqlDbType.DateTime).Value = Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy");
            //cmd.Parameters.Add("@doituong", SqlDbType.Int).Value = int.Parse(Request.Params["id"].ToString());
            //cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = int.Parse(Request.Params["huyen"].ToString()); 
        }
        
        //cmd.Parameters.Add("@nam", SqlDbType.Int).Value = iNam - 1;
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        con.Open();
        SqlDataReader oda = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        DataSet ds = new BRDataSet();
        ds.Tables["dsKiemKeNo1"].Load(oda);
        ReportDataSource rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsKiemKeNo1";
        rds.Value = ds.Tables["dsKiemKeNo1"];
        ReportParameter[] rppDate = new ReportParameter[1];
        rppDate[0] = new ReportParameter("NgayLap", Convert.ToDateTime(Request.Params["NgayThang"]).ToString("dd/MM/yyyy"));
        rptKiemKeNo1.LocalReport.ReportPath = "rptKiemKe1.rdlc";
        rptKiemKeNo1.LocalReport.DataSources.Clear();
        rptKiemKeNo1.LocalReport.DataSources.Add(rds);
        rptKiemKeNo1.LocalReport.SetParameters(rppDate);
        rptKiemKeNo1.LocalReport.Refresh();
    }
}
