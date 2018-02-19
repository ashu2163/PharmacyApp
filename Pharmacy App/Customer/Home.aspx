<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Pharmacy_App.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 35px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 323px;
        }
        .auto-style5 {
            width: 323px;
        }
        .auto-style6 {
            width: 323px;
            height: 30px;
        }
        .auto-style7 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <nav>
        <div class="nav-wrapper black">
            <asp:Image ID="Image1" runat="server" imageUrl="~/pharmacy-logo.png"/>
            <a href="" class="brand-logo">Logo</a><br />
&nbsp;</div>
    </nav>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="seller_city" DataValueField="seller_city" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td class="auto-style3"></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmacyApp_DBConnectionString %>" SelectCommand="SELECT DISTINCT [seller_city] FROM [seller]"></asp:SqlDataSource>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td>
                                <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged">Enter medicine name or disease</asp:TextBox>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td class="auto-style7"></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove item" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
             </tr>
            </table>
        </form>
</body>
</html>
