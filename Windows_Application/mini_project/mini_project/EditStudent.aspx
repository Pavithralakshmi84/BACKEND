<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="mini_project.EditStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Student ID: <asp:TextBox ID="txtID" runat="server" /><br />
Name: <asp:TextBox ID="txtName" runat="server" /><br />
Age: <asp:TextBox ID="txtAge" runat="server" /><br />
Class: <asp:TextBox ID="txtClass" runat="server" /><br />
Email: <asp:TextBox ID="txtEmail" runat="server" /><br />
<asp:Button ID="btnUpdate" runat="server" Text="Update Student" OnClick="btnUpdate_Click" />

        </div>
    </form>
</body>
</html>
