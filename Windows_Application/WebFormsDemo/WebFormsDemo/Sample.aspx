<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="WebFormsDemo.Sample" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Basic Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; padding: 20px;">
            <h2>ASP.NET Basic Controls</h2>

            <!-- Button Control -->
            <asp:Button ID="btnClickMe" runat="server" Text="Click Me" OnClick="btnClickMe_Click" />

            <br /><br />

            <!-- ListBox Control -->
            <asp:ListBox ID="lstFruits" runat="server" SelectionMode="Multiple">
                <asp:ListItem>Apple</asp:ListItem>
                <asp:ListItem>Banana</asp:ListItem>
                <asp:ListItem>Cherry</asp:ListItem>
                <asp:ListItem>Mango</asp:ListItem>
            </asp:ListBox>

            <br /><br />

            <!-- DropDownList Control -->
            <asp:DropDownList ID="ddlColors" runat="server">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
            </asp:DropDownList>

            <br /><br />

            <!-- Output Label -->
            <asp:Label ID="lblMessage" runat="server" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>

