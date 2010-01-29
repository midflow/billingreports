using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FillParameters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Report3.aspx?han_bc="+ txtHan_bc.Text + "&tu_ngay=" + txtTu.Text + "&den_ngay="+ txtDen.Text);
    }
}
