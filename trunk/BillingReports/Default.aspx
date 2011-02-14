<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Title="Báo cáo công nợ Tỉnh Bình Dương" %>

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
                <asp:RadioButton ID="rbBaoCaoTuan2011" runat="server" 
                    Text="Báo cáo tuần trong năm 2011" GroupName="Baocao" Checked="True" />
            </td>        
        </tr>  
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbBaoCaoTuan2010" runat="server" 
                    Text="Báo cáo tuần trong năm 2010" GroupName="Baocao" />
            </td>        
        </tr>
             
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbBaoCaoTuan2010_gphone" runat="server" 
                    Text="Báo cáo tuần gphone trong năm 2010" GroupName="Baocao"
                     />
            </td>        
        </tr>
             
         <tr>
            <td>
            </td>
            <td>
                <asp:RadioButton ID="rbBaoCao2009" runat="server" Text="Báo cáo năm 2009" GroupName="Baocao"
                     />
            </td>        
        </tr>
             
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbBaoCao2009_2" runat="server" Text="Báo cáo năm 2009" GroupName="Baocao"
                     />
            &nbsp;(tính đến 10 tháng 2 năm 2010)</td>        
        </tr>
             
         <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:RadioButton ID="rbBaoCao2009_3" runat="server" Text="Báo cáo năm 2009" GroupName="Baocao"
                     />
                &nbsp;(tính đến 31 tháng 3 năm 2010)</td>        
        </tr>
             
         <tr>
            <td>
                </td>
            <td>
                <asp:RadioButton ID="rbBaoCaoTuan2009" runat="server" 
                    Text="Báo cáo tuần trong năm 2009" GroupName="Baocao"
                     />
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
                <asp:RadioButton ID="rbKiemke2_30062010" Text="Bảng kiểm kê nợ loại 2" 
                    GroupName="Baocao" runat="server" />
            &nbsp;(30 tháng 6 năm 2010)</td>        
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

