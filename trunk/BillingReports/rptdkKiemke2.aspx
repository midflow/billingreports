<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rptdkKiemke2.aspx.cs" Inherits="rptdkKiemke2" %>
<%@ Register Assembly="DateTimePicker" Namespace="DateTimePicker" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="100%">
            <tr>
                <td colspan ="2">
                    BẢNG KIỂM KÊ NỢ PHẢI THU KHÁCH HÀNG SỬ DỤNG DỊCH VỤ VT- CNTT</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
             <td colspan ="2">
                </td>
            <td align="right" width="200px">
                &nbsp;</td>
             <td>
                 &nbsp;</td>
            </tr>
               
             <tr>
            <td align="right" width="15%px">
                Thời điểm lập báo cáo</td>
            <td>
               <cc2:DaintyDate ID="ddIdentifyIssueDate" runat="server" FormatType="dd/MM/yyyy" 
                    SelectedDate="06/30/2009 16:27:00" />
                </td>        
            <td width="15%">
                Huyện</td>        
            <td>
                <asp:DropDownList ID="ddlHuyen" runat="server" Height="22px" Width="200px">
                    <asp:ListItem Value="0">Tất cả</asp:ListItem>
                    <asp:ListItem Value="1">Thị xã Thủ Dầu Một</asp:ListItem>
                    <asp:ListItem Value="3">Huyện Thuận An</asp:ListItem>
                    <asp:ListItem Value="2">Huyện Dĩ An</asp:ListItem>
                    <asp:ListItem Value="4">Huyện Bến Cát</asp:ListItem>
                    <asp:ListItem Value="5">Huyện Dầu Tiếng</asp:ListItem>
                    <asp:ListItem Value="6">Huyện Tân Uyên</asp:ListItem>
                    <asp:ListItem Value="7">Huyện Phú Giáo</asp:ListItem>
                </asp:DropDownList>
                </td>        
        </tr>  
               
             <tr>
            <td align="right" width="200px">
                &nbsp;</td>
            <td>
                &nbsp;</td>        
            <td>
                &nbsp;</td>        
            <td>
                &nbsp;</td>        
        </tr>  
        <tr>
            <td  width="200px">
                </td>
            <td>
                <asp:Button ID="btnTaoBaoCao" runat="server" Text="Xuất báo cáo" onclick="btnTaoBaoCao_Click" 
                    />
             </td>        
            <td>
                &nbsp;</td>        
            <td>
                &nbsp;</td>        
        </tr>            
        </table>
    </div>
    </form>
</body>
</html>
