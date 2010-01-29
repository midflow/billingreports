using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class rptdkKiemke1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTaoBaoCao_Click(object sender, EventArgs e)
    {
        Response.Redirect("rptKiemke1.aspx?NgayThang="+ddIdentifyIssueDate.SelectedDate.Value.ToString("dd MMM yyyy") + "&id="+ ddlType.SelectedValue + "&huyen=" + ddlHuyen.SelectedValue) ;
    }
}
