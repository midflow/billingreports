using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BRDataSetTableAdapters;
using Microsoft.Reporting.WebForms;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    
    protected void btnChonBaoCao_Click(object sender, EventArgs e)
    {

        if (rbBaoCaoTuan2011.Checked)
        {
            Response.Redirect("rptdkBaoCaoTuan2011.aspx");
        }
        if (rbBaoCaoTuan2011_1.Checked)
        {
            Response.Redirect("rptBaoCaoTuan2011.aspx?id=1");
        }
        if (rbBaoCaoTuan2010.Checked)
        {
            Response.Redirect("rptdkBaoCaoTuan2010.aspx");
        }
        if (rbBaoCaoTuan2010_gphone.Checked)
        {
            Response.Redirect("rptdkBaoCaoTuan2010_gphone.aspx");
        }
        if (rbBaoCaoTuan2009.Checked)
        {
            Response.Redirect("rptdkBaoCaoTuan.aspx");
        }
        if (rbBaoCao2009.Checked)
        {
            Response.Redirect("rptBaoCao2009.aspx?id=1");
        }
        if (rbBaoCao2009_2.Checked)
        {
            Response.Redirect("rptBaoCao2009.aspx?id=2");
        }
        if (rbBaoCao2009_3.Checked)
        {
            Response.Redirect("rptBaoCao2009.aspx?id=3");
        }
        if (rbKiemke1.Checked)
        {
            Response.Redirect("rptdkKiemke1.aspx");
        }
        if (rbKiemke2.Checked)
        {
            Response.Redirect("rptdkKiemke2.aspx");
        }
        if (rbKiemke2_30062010.Checked)
        {
            Response.Redirect("rptdkKiemke2_30062010.aspx");
        }

    }
}
