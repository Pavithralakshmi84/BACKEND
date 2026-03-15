<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudentApplicationReport.aspx.cs" Inherits="Project_1.ViewStudentApplicationReport" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Application Report - Campus Selection System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body {
            background: linear-gradient(135deg, #ff9966 0%, #ff5e62 100%);
            min-height: 100vh;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .card {
            background: rgba(255,255,255,0.95);
            border-radius: 15px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            padding: 2rem;
            margin-top: 2rem;
        }
        h2 {
            font-weight: 700;
            color: #ff5e62;
        }
        .grid-header {
            background-color: #ff5e62;
            color: #fff;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark shadow-sm">
            <div class="container">
                <a class="navbar-brand fw-bold" href="AdminDashboard.aspx">Admin Dashboard</a>
                <div class="navbar-nav ms-auto">
                    <asp:Button ID="btnBackDashboard" runat="server" Text="⬅️ Back to Dashboard" CssClass="btn btn-outline-light" OnClick="btnBackDashboard_Click" />
                </div>
            </div>
        </nav>

        <!-- Student Application Report -->
        <div class="container">
            <div class="card">
                <h2 class="mb-4">📑 Student Application Report</h2>
                <asp:GridView ID="gvApplications" runat="server" CssClass="table table-bordered table-hover"
                              AutoGenerateColumns="false" EmptyDataText="No applications found."
                              HeaderStyle-CssClass="grid-header">
                    <Columns>
                        <asp:BoundField DataField="ApplicationID" HeaderText="Application ID" />
                        <asp:BoundField DataField="StudentEmail" HeaderText="Student Email" />
                        <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                        <asp:BoundField DataField="AppliedDate" HeaderText="Applied Date" DataFormatString="{0:dd-MMM-yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
