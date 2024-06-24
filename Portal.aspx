<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Portal.aspx.cs" Inherits="Tuition_Managment_System.Portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: xx-large;
            background-color: #FFFFFF;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <div class="auto-style4">
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <h1 class="auto-style3">
                    <asp:Label ID="Lbl_TMS" runat="server" CssClass="auto-style2" Text="Tuition Management System"></asp:Label>
                </h1>
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
            <asp:Menu ID="Menu1" runat="server" CssClass="auto-style1" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Principal Portal.aspx" Text="Principal Portal" Value="Principal Portal"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Teacher Portal.aspx" Text=" Teacher Portal" Value=" Teacher Portal"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Student Portal.aspx" Text="Student Portal" Value="Student Portal"></asp:MenuItem>
                </Items>
                <StaticMenuItemStyle VerticalPadding="10px" Width="500px" />
            </asp:Menu>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
