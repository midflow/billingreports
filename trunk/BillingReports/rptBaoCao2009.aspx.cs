using System;
using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;
public partial class rptBaoCao2009 : System.Web.UI.Page
{
    public string thisConnectionString =
        ConfigurationManager.ConnectionStrings[
        "ConnectionString"].ConnectionString;
    DataTable dtBaocaotuan = new BRDataSet.dsBaocaoDataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        //string tuantruoc = getTuanTruoc("01/01/2007");
        BindReport();
    }
    private void BindReport()
    {
        CultureInfo vn = new CultureInfo("vi-VN");   
  
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;        
        //lay du lieu co trong bang stt       
        //string strphanloaiCT = "tinhtheotuoinocacnam";
        //string strNam2009 = "TinhTheoTuoiNoCacThang2009";
        //string strDoituong = "TinhTheoDoiTuong";
        //string strTinhTong = "TinhTongTheoTuoiNo";
        string strphanloaiCT;
        string strNam2009;
        string strDoituong;
        string strTinhTong;
        string strnam2010;
        
        if (Request.QueryString["id"] == "1")
        {
            strphanloaiCT = "select * from tblbctuan where type=1 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Dec 2009'";
            strNam2009 = "select * from tblbctuan where type=2 and nam=2009 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Dec 2009'";
            strDoituong = "select * from tblbctuan where type=3 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Dec 2009'";
            strTinhTong = "select * from tblbctuan where type=0 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Dec 2009'";
            strnam2010 = "select * from tblbctuan where type=2 and nam=2010 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Dec 2010'";
            rptBaoCaoTuan1.LocalReport.ReportPath = "rptTinhHinhTC2009.rdlc";
        }
        else if (Request.QueryString["id"] == "2")
        {
            strphanloaiCT = "select * from tblbctuan where type=1 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='10 Feb 2010'";
            strNam2009 = "select * from tblbctuan where type=2 and nam=2009 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='10 Feb 2010'";
            strDoituong = "select * from tblbctuan where type=3 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='10 Feb 2010'";
            strTinhTong = "select * from tblbctuan where type=0 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='10 Feb 2010'";
            strnam2010 = "select * from tblbctuan where type=2 and nam=2010 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='10 Feb 2010'";
            rptBaoCaoTuan1.LocalReport.ReportPath = "rptTinhHinhTC20092.rdlc";
        }
        else if (Request.QueryString["id"] == "3")
        {
            strphanloaiCT = "select * from tblbctuan where type=1 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Mar 2010'";
            strNam2009 = "select * from tblbctuan where type=2 and nam=2009 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Mar 2010'";
            strDoituong = "select * from tblbctuan where type=3 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Mar 2010'";
            strTinhTong = "select * from tblbctuan where type=0 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Mar 2010'";
            strnam2010 = "select * from tblbctuan where type=2 and nam=2010 and cast(tungay as datetime)='01 Jan 2009' and cast(denngay as datetime)='31 Mar 2010'";
            rptBaoCaoTuan1.LocalReport.ReportPath = "rptTinhHinhTC20092.rdlc";
        }
        else
        {
            return;
        }

       
        SqlCommand cmdPLCT = new SqlCommand(strphanloaiCT);
        cmdPLCT.Connection = con;
        cmdPLCT.CommandType = CommandType.Text;
        //cmdPLCT.Parameters.Add("@hanbc", SqlDbType.DateTime).Value =
        //    Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd/MMM/yyyy");
        //cmdPLCT.Parameters.Add("@tungay", SqlDbType.DateTime).Value =
        //   Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd MMM yyyy");
        //cmdPLCT.Parameters.Add("@denngay", SqlDbType.DateTime).Value =
        //   Convert.ToDateTime(Request.Params["toingay"].ToString(), vn).ToString("dd MMM yyyy");
        cmdPLCT.CommandTimeout = 0;
        con.Open();
        SqlDataReader odPLCT = cmdPLCT.ExecuteReader(CommandBehavior.CloseConnection);
        DataTable dtPLCT = new DataTable();
        dtPLCT.Load(odPLCT);                
        
        ReportDataSource rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsBaoCaoTuan";
        rds.Value = dtPLCT;
        
        rptBaoCaoTuan1.LocalReport.DataSources.Clear();
        rptBaoCaoTuan1.LocalReport.DataSources.Add(rds);

        cmdPLCT.CommandText= strNam2009;
        //cmdPLCT.Parameters.Add("@tungay", SqlDbType.DateTime).Value =
        //   Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).ToString("dd/MMM/yyyy");
        //cmdPLCT.Parameters.Add("@denngay", SqlDbType.DateTime).Value =
        //   Convert.ToDateTime(Request.Params["toingay"].ToString(), vn).ToString("dd/MMM/yyyy");
        if (con.State == ConnectionState.Closed) con.Open();
        //cmdPLCT.Connection = con;
        
        odPLCT = cmdPLCT.ExecuteReader(CommandBehavior.CloseConnection);
        dtPLCT = new DataTable();
        dtPLCT.Load(odPLCT);
        rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsBaoCaoTuan1";
        rds.Value = dtPLCT;        
        rptBaoCaoTuan1.LocalReport.DataSources.Add(rds);
        odPLCT.Close();
        // tinh tong doi tuong 
        cmdPLCT.CommandText = strTinhTong;
        if (con.State == ConnectionState.Closed) con.Open();
        

        odPLCT = cmdPLCT.ExecuteReader(CommandBehavior.CloseConnection);
        dtPLCT = new DataTable();
        dtPLCT.Load(odPLCT);
        rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsBaoCaoTuan_Tong";
        rds.Value = dtPLCT;
        rptBaoCaoTuan1.LocalReport.DataSources.Add(rds);
        odPLCT.Close();
        
        // 2010         
        cmdPLCT.CommandText = strnam2010;
        if (con.State == ConnectionState.Closed) con.Open();
        //cmdPLCT.Parameters.Add("@thangnam", SqlDbType.DateTime).Value =
        //  Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).AddMonths(-1).ToString("MMyyyy");

        odPLCT = cmdPLCT.ExecuteReader(CommandBehavior.CloseConnection);
        dtPLCT = new DataTable();
        dtPLCT.Load(odPLCT);
        rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsBaoCaoTuan12010";
        rds.Value = dtPLCT;
        rptBaoCaoTuan1.LocalReport.DataSources.Add(rds);
        odPLCT.Close();


        // tinh theo doi tuong 
        cmdPLCT.CommandText = strDoituong;
        if (con.State == ConnectionState.Closed) con.Open();
        //cmdPLCT.Parameters.Add("@thangnam", SqlDbType.DateTime).Value =
         //  Convert.ToDateTime(Request.Params["NgayThang"].ToString(), vn).AddMonths(-1).ToString("MMyyyy");

        odPLCT = cmdPLCT.ExecuteReader(CommandBehavior.CloseConnection);
        dtPLCT = new DataTable();
        dtPLCT.Load(odPLCT);
        rds = new ReportDataSource();
        rds.Name = "BRDataSet_dsBaoCaoTuan11";
        rds.Value = dtPLCT;
        rptBaoCaoTuan1.LocalReport.DataSources.Add(rds);
        odPLCT.Close();

        ReportParameter[] rppDate = new ReportParameter[2];
        rppDate[0] = new ReportParameter("tungay", "01/01/2009");
        if (Request.QueryString["id"]=="1") 
            rppDate[1] = new ReportParameter("denngay", "31/12/2009");
        else if (Request.QueryString["id"]=="2") 
            rppDate[1] = new ReportParameter("denngay", "10/02/2010");
         else
            rppDate[1] = new ReportParameter("denngay", "31/03/2010");
        //rppDate[0] = new ReportParameter("Thang", Convert.ToDateTime(Request.Params["ToiNgay"].ToString(), vn).AddMonths(-1).ToString("MM"));
        
        rptBaoCaoTuan1.LocalReport.SetParameters(rppDate);
        rptBaoCaoTuan1.LocalReport.Refresh();

    }
    private DataTable GetdtTrongTuan(string strdtTTFrom, string strdtTTTo)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;
        string strTrongTuan = "select (SELECT SUM(dbo.tblctct.Tien) FROM dbo.tblstt INNER JOIN " +
                     " dbo.tblct ON dbo.tblstt.ID = dbo.tblct.ThueBaoID INNER JOIN " +
                     " dbo.tblctct ON dbo.tblct.ID = dbo.tblctct.CTID " +
                     " WHERE     (dbo.tblstt.TuoiNo >= 32) AND (dbo.tblct.NgayCT between '" + strdtTTFrom + "' and '" + strdtTTTo + "' )) as tt1," +
                     " (SELECT     SUM(dbo.tblctct.Tien) FROM dbo.tblstt INNER JOIN " +
                     " dbo.tblct ON dbo.tblstt.ID = dbo.tblct.ThueBaoID INNER JOIN " +
                     " dbo.tblctct ON dbo.tblct.ID = dbo.tblctct.CTID " +
                     " WHERE     (dbo.tblstt.TuoiNo between 20 and 31)" +
                     " AND (dbo.tblct.NgayCT between '" + strdtTTFrom + "' and '" + strdtTTTo + "')) as tt2,(SELECT     SUM(dbo.tblctct.Tien) " +
                     " FROM dbo.tblstt INNER JOIN dbo.tblct ON dbo.tblstt.ID = dbo.tblct.ThueBaoID " + " INNER JOIN  dbo.tblctct ON dbo.tblct.ID = dbo.tblctct.CTID " +
                     " WHERE     (dbo.tblstt.TuoiNo between 8 and 19) AND " +
                     " (dbo.tblct.NgayCT between '" + strdtTTFrom + "' and '" + strdtTTTo + "')) as tt3,(SELECT SUM(dbo.tblctct.Tien) " +
                     " FROM         dbo.tblstt INNER JOIN " +
                     " dbo.tblct ON dbo.tblstt.ID = dbo.tblct.ThueBaoID INNER JOIN " +
                     " dbo.tblctct ON dbo.tblct.ID = dbo.tblctct.CTID " +
                     " WHERE     (dbo.tblstt.TuoiNo between 1 and 7) AND (dbo.tblct.NgayCT between '" + strdtTTFrom + "' and '" + strdtTTTo + "')) as tt4";

        SqlCommand cmdTrongtuan = new SqlCommand(strTrongTuan);
        cmdTrongtuan.Connection = con;
        con.Open();
        cmdTrongtuan.CommandTimeout = 120000;
        cmdTrongtuan.CommandType = CommandType.Text;
        SqlDataReader odTrongtuan = cmdTrongtuan.ExecuteReader(CommandBehavior.CloseConnection);
        DataTable dtTrongTuan = new DataTable();
        dtTrongTuan.Load(odTrongtuan);
        return dtTrongTuan;
    }
    private DataTable GetdtTrongTuan_Thang(string strdtTTFrom, string strdtTTTo, int tuoino)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;
        string strTrongTuan_Thang = "SELECT SUM(dbo.tblctct.Tien) as TrongTuan FROM dbo.tblstt INNER JOIN " +
                                    " dbo.tblct ON dbo.tblstt.ID = dbo.tblct.ThueBaoID INNER JOIN " +
                                    " dbo.tblctct ON dbo.tblct.ID = dbo.tblctct.CTID " +
                                    " WHERE (tblct.NgayCT between '" + strdtTTFrom + "' and '" + strdtTTFrom + "') and tblstt.tuoino = tuoino ";
        SqlCommand cmdTrongtuan_Thang = new SqlCommand(strTrongTuan_Thang);
        cmdTrongtuan_Thang.Connection = con;
        con.Open();
        cmdTrongtuan_Thang.CommandType = CommandType.Text;
        SqlDataReader odTrongtuan_Thang = cmdTrongtuan_Thang.ExecuteReader(CommandBehavior.CloseConnection);
        DataTable dtTrongTuan_Thang = new DataTable();
        dtTrongTuan_Thang.Load(odTrongtuan_Thang);
        return dtTrongTuan_Thang;
    }
    private DataTable GetDoiTuongNo()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;
        string strTrongTuanDTNo = "SELECT DISTINCT dbo.tblloaikh.KHTD, SUM(dbo.tblstt.NODK) AS DauKy, SUM(dbo.tblstt.PS) AS PhatSinh, SUM(dbo.tblstt.DT) AS DaTra, SUM(dbo.tblstt.CONNO) as ConNo,dbo.tblloaikh.KHTDID AS KHID FROM dbo.tblstt INNER JOIN dbo.tblloaikh ON dbo.tblstt.KHID = dbo.tblloaikh.KHTDID GROUP BY dbo.tblloaikh.KHTD, dbo.tblloaikh.KHTDID";
        SqlCommand cmdDTNoTT = new SqlCommand(strTrongTuanDTNo);
        cmdDTNoTT.Connection = con;
        con.Open();
        cmdDTNoTT.CommandType = CommandType.Text;
        SqlDataReader odDTNoTT = cmdDTNoTT.ExecuteReader(CommandBehavior.CloseConnection);
        DataTable dtDTNoTT = new DataTable();
        dtDTNoTT.Load(odDTNoTT);
        return dtDTNoTT;
    }
    private DataTable GetDTNoTrongTuan(int KHID, string tungay, string dengay)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;
        string strDTNoTT = "select (SELECT     SUM(dbo.tblctct.Tien) FROM         dbo.tblstt INNER JOIN " +
                      " dbo.tblloaikh ON dbo.tblstt.KHID = dbo.tblloaikh.KHTDID INNER JOIN " +
                      " dbo.tblct ON dbo.tblstt.ID = dbo.tblct.ThueBaoID INNER JOIN " +
                      " dbo.tblctct ON dbo.tblct.ID = dbo.tblctct.CTID " +
"WHERE     (dbo.tblloaikh.KHTDID = '" + KHID + "') AND (dbo.tblct.NgayCT BETWEEN '" + tungay + "' AND '" + dengay + "'))as DTNoTT";
        SqlCommand cmdDTNoTT = new SqlCommand(strDTNoTT);
        cmdDTNoTT.Connection = con;
        con.Open();
        cmdDTNoTT.CommandType = CommandType.Text;
        SqlDataReader odDTNoTT = cmdDTNoTT.ExecuteReader(CommandBehavior.CloseConnection);
        DataTable dtDTNoTT = new DataTable();
        dtDTNoTT.Load(odDTNoTT);
        return dtDTNoTT;
    }
    private int getMonth(string strNgaythang) // voi ngay thang dinh dang dd/MM/yyyy
    {
        return Convert.ToInt16(strNgaythang.Substring(3, 2));
    }
    private DataTable dtThang(int tuoino)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = thisConnectionString;
        string strThang = "select sum(NoDK) as DauKy,sum(PS)as PhatSinh,sum(DT)as DaTra, sum(ConNo) As ConNo from tblstt where tuoino = '" + tuoino + "'";
        SqlCommand cmdThang = new SqlCommand(strThang);
        cmdThang.Connection = con;
        con.Open();
        cmdThang.CommandType = CommandType.Text;
        SqlDataReader odThang = cmdThang.ExecuteReader(CommandBehavior.CloseConnection);
        DataTable dtThang = new DataTable();
        dtThang.Load(odThang);
        return dtThang;
    }
    private string getTuanTruoc(string strCurrentTime)
    {
        char splitter = '/';
        string[] arrinfo = new string[3];
        arrinfo = strCurrentTime.Split(splitter);
        string[] arrkq = new string[3];
        string kqtt = "";
        if (Convert.ToInt16(arrinfo[0]) > 7)
        {
            arrkq[0] = (Convert.ToInt16(arrinfo[0]) - 7).ToString();
            arrkq[1] = arrinfo[1];
            arrkq[2] = arrinfo[2];
        }
        else
            if (Convert.ToInt16(arrinfo[0]) < 7)
            {
                if (Convert.ToInt16(arrinfo[1]) > 1)
                {
                    arrkq[1] = (Convert.ToInt16(arrinfo[1]) - 1).ToString();
                    arrkq[2] = arrinfo[2];
                    arrkq[0] = (Convert.ToInt16(arrinfo[0]) + 30 - 7).ToString();
                }
                else
                {
                    arrkq[2] = (Convert.ToInt32(arrinfo[2]) - 1).ToString();
                    arrkq[1] = (12).ToString();
                    arrkq[0] = (Convert.ToInt16(arrinfo[0]) + 30 - 7).ToString();
                }
            }
        return kqtt = arrkq[0] + "/" + arrkq[1] + "/" + arrkq[2];
    }

}
