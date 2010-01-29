<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportBuilder.aspx.cs" Inherits="ReportBuilder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1" colspan="2">
                    Chọn loại báo cáo</td>
            </tr>
            <tr>
                <td width="25%">
                    &nbsp;</td>
                <td>
                    <asp:RadioButton ID="rbtKiemKe1" runat="server" GroupName="baocao" 
                        Text="Báo cáo kiểm kê nợ 1" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RadioButton ID="rbtKiemKe2" runat="server" GroupName="baocao" 
                        Text="Báo cáo kiểm kê nợ 2" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RadioButton ID="rbtTinhhinhTC" runat="server" GroupName="baocao" 
                        Text="Báo cáo tình hình thu cước" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RadioButton ID="rbtNoPhaiThu" runat="server" GroupName="baocao" 
                        Text="Báo cáo Nợ phải thu" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Tiếp theo</asp:LinkButton>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
