<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLogin.aspx.cs" Inherits="Project_1.StudentLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Login - Campus Selection System</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <!-- Centered Login Card -->
        <div class="container d-flex justify-content-center align-items-center vh-100">
            <div class="card shadow-lg" style="max-width: 400px; width: 100%;">
                <div class="card-header bg-primary text-white text-center">
                    <h2 class="mb-0">Student Login</h2>
                </div>
                <div class="card-body">
                    <!-- Email -->
                    <div class="mb-3">
                        <asp:Label ID="LblEmail" runat="server" AssociatedControlID="TxtEmail" CssClass="form-label" Text="Email"></asp:Label>
                        <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" Placeholder="Enter your email"></asp:TextBox>
                    </div>

                    <!-- Password -->
                    <div class="mb-3">
                        <asp:Label ID="LblPassword" runat="server" AssociatedControlID="TxtPassword" CssClass="form-label" Text="Password"></asp:Label>
                        <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="Password" Placeholder="Enter your password"></asp:TextBox>
                    </div>

                    <!-- Buttons -->
                    <div class="d-grid gap-2">
                        <asp:Button ID="BtnLogin" runat="server" Text="Login" CssClass="btn btn-success btn-lg" OnClick="BtnLogin_Click" />
                        <asp:Button ID="BtnRegister" runat="server" Text="Student Register" CssClass="btn btn-secondary btn-lg" OnClick="Button1_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
