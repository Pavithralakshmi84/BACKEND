<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Project_1.AdminDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <!-- Home link -->
                <a class="navbar-brand fw-bold" href="Home.aspx">🏠 Home</a>
                <!-- Admin Dashboard link -->
                <a class="navbar-brand fw-bold ms-3" href="AdminDashboard.aspx">Admin Dashboard</a>

                <div class="navbar-nav ms-auto">
                    <asp:Button ID="btnStudentReport" runat="server" Text="Student Report" CssClass="btn btn-outline-light me-2" OnClick="btnStudentReport_Click" />
                    <asp:Button ID="btnViewStudentReport" runat="server" Text="View Student Application Report" CssClass="btn btn-outline-light me-2" OnClick="btnViewStudentReport_Click" />
                    <asp:Button ID="btnCompanyReport" runat="server" Text="Company Report" CssClass="btn btn-outline-light me-2" OnClick="btnCompanyReport_Click" />
                    <asp:Button ID="btnJobPostingReport" runat="server" Text="Job Posting Report" CssClass="btn btn-outline-light me-2" OnClick="btnJobPostingReport_Click" />
                    <asp:Button ID="btnShortlistReport" runat="server" Text="Shortlist Report" CssClass="btn btn-outline-light" OnClick="btnShortlistReport_Click" />
                </div>
            </div>
        </nav>

        <div class="container mt-5">
            <h2>Welcome, Admin!</h2>
            <p>Select a report from the navigation bar above.</p>
        </div>
    </form>
</body>
</html>
