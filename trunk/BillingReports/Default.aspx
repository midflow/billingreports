﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table width="100%">        
        <tr>
            <td colspan=2>
                Báo cáo công nợ Tỉnh Bình Dương</td>            
        </tr>
             
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbBaoCaoTuan2010" runat="server" 
                    Text="Báo cáo tuần trong năm 2010" GroupName="Baocao"
                    oncheckedchanged="RadioButton1_CheckedChanged" Checked="True" />
            </td>        
        </tr>
             
         <tr>
            <td>
            </td>
            <td>
                &nbsp;<asp:RadioButton ID="rbBaoCao2009" runat="server" Text="Báo cáo năm 2009" GroupName="Baocao"
                    oncheckedchanged="RadioButton1_CheckedChanged" />
            </td>        
        </tr>
             
         <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;<asp:RadioButton ID="rbBaoCaoTuan2009" runat="server" 
                    Text="Báo cáo tuần trong năm 2009" GroupName="Baocao"
                    oncheckedchanged="RadioButton1_CheckedChanged" />
            </td>        
        </tr>
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbKiemke1" Text="Bảng kiểm kê nợ loại 1" GroupName="Baocao" runat="server" />
            </td>        
        </tr>
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbKiemke2" Text="Bảng kiểm kê nợ loại 2" GroupName="Baocao" runat="server" />
            </td>        
        </tr>
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnChonBaoCao" runat="server" Text="Chọn báo cáo" 
                    onclick="btnChonBaoCao_Click" />
             </td>        
        </tr>
       </table>
    </div>
    </form>
</body>
</html>

