<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A-Login.aspx.cs" Inherits="Pharmacy_App.Admin.A_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
            </asp:Login>
        </div>
    </form>
</body>
</html>
