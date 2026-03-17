<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="mini_project.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name: <asp:TextBox ID="txtName" runat="server" /><br />
Age: <asp:TextBox ID="txtAge" runat="server" /><br />
Class: <asp:TextBox ID="txtClass" runat="server" /><br />
Email: <asp:TextBox ID="txtEmail" runat="server" /><br />
<asp:Button ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" />

        </div>
    </form>
</body>
</html>
