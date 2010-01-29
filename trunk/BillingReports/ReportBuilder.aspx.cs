using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReportBuilder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (rbtKiemKe1.Checked)
        {
            Response.Redirect("#");
        }
        if (rbtKiemKe2.Checked)
        {
            Response.Redirect("#");
        }
        if (rbtTinhhinhTC.Checked)
        {
            Response.Redirect("FillParameters.aspx");
        }
        if (rbtNoPhaiThu.Checked)
        {
            Response.Redirect("#");
        }
    }
}
