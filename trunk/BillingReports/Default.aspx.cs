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
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void btnChonBaoCao_Click(object sender, EventArgs e)
    {
        if (rbBaoCaoTuan2010.Checked)
        {
            Response.Redirect("rptdkBaoCaoTuan2010.aspx");
        }
        if (rbBaoCaoTuan2009.Checked)
        {
            Response.Redirect("rptdkBaoCaoTuan.aspx");
        }
        if (rbBaoCao2009.Checked)
        {
            Response.Redirect("rptkBaoCao2009.aspx");
        }
        if (rbKiemke1.Checked)
        {
            Response.Redirect("rptdkKiemke1.aspx");
        }
        if (rbKiemke2.Checked)
        {
            Response.Redirect("rptdkKiemke2.aspx");
        }
    }
}
