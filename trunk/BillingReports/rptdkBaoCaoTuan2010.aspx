<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rptdkBaoCaoTuan2010.aspx.cs"
    Inherits="rptdkBaoCaoTuan2010" %>

<%@ Register Assembly="DateTimePicker" Namespace="DateTimePicker" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Báo cáo tuần</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <tr>
                <td colspan="2">
                    BẢNG KIỂM KÊ NỢ PHẢI THU KHÁCH HÀNG SỬ DỤNG DỊCH VỤ VT- CNTT
                </td>
            </tr>
            <tr>
                <td colspan="4">
                </td>
            </tr>
            <tr>
                <td align="right" width="100px">
                    Tuần từ ngày
                </td>
                <td align="right" width="100px">
                    <cc2:DaintyDate ID="ddIdentifyIssueDate" runat="server" FormatType="dd/MM/yyyy" 
                        />
                </td>
                <td align="center" width="100px">
                    Đến
                </td>
                <td>
                    <cc2:DaintyDate ID="ddIdentifyIssueToDate" runat="server" 
                        FormatType="dd/MM/yyyy"/>
                </td>
            </tr>
            <tr>
                <td width="200px">
                </td>
                <td colspan="3">
                    <asp:Button ID="btnTaoBaoCao" runat="server" Text="Xuất báo cáo" OnClick="btnTaoBaoCao_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
