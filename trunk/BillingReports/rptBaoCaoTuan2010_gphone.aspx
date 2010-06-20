<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rptBaoCaoTuan2010_gphone.aspx.cs" Inherits="rptBaoCaoTuan2010_gphone" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Báo cáo tuần</title>
</head>
<body>
    <form id="form1" runat="server">
   
         <div>    
        <rsweb:ReportViewer ID="rptBaoCaoTuan1" runat="server" Width="22cm" Height="38cm" 
                 ShowBackButton="True" >
        </rsweb:ReportViewer>   
      
    </div>
    </form>
</body>
</html>
