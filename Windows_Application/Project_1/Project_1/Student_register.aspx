<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_register.aspx.cs" Inherits="Project_1.Properties.Student_register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration - Campus Selection System</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <!-- Navigation Bar -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
            <div class="container-fluid">
                <a class="navbar-brand fw-bold" href="#">Campus Selection System</a>
                <div class="collapse navbar-collapse">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item"><a class="nav-link" href="Home.aspx">Home</a></li>
                        <li class="nav-item"><a class="nav-link" href="Student_register.aspx">Register</a></li>
                    </ul>
                </div>
            </div>
        </nav>

        <!-- Registration Form -->
        <div class="container mt-5">
            <div class="card shadow-lg">
                <div class="card-header bg-primary text-white text-center">
                    <h2 class="mb-0">Student Registration</h2>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label for="TxtName" class="form-label">Name</label>
                        <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="TxtEmail" class="form-label">Email</label>
                        <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="TxtPassword" class="form-label">Password</label>
                        <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="TxtDept" class="form-label">Department</label>
                        <asp:TextBox ID="TxtDept" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="TxtCGPA" class="form-label">CGPA</label>
                        <asp:TextBox ID="TxtCGPA" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="d-grid">
                        <asp:Button ID="BtnRegister" runat="server" Text="Register" CssClass="btn btn-success btn-lg" OnClick="BtnRegister_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
