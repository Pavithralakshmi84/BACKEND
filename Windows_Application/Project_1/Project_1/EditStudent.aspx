<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="Project_1.EditStudent" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Student Profile</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <h2 class="mb-4">Edit My Profile</h2>

        <div class="mb-3">
            <label class="form-label">Name</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Email</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Password</label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">Department</label>
            <asp:TextBox ID="txtDepartment" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label class="form-label">CGPA</label>
            <asp:TextBox ID="txtCGPA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" CssClass="btn btn-success" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnBack" runat="server" Text="⬅️ Back to Dashboard" CssClass="btn btn-secondary ms-2" OnClick="btnBack_Click" />

        <div class="mt-3">
            <asp:Label ID="lblMessage" runat="server" CssClass="fw-bold"></asp:Label>
        </div>
    </form>
</body>
</html>
