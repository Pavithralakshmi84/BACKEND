<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentReport.aspx.cs" Inherits="Project_1.StudentReport" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Report - Campus Selection System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body {
            background: linear-gradient(135deg, #43cea2 0%, #185a9d 100%);
            min-height: 100vh;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .card {
            background: rgba(255,255,255,0.95);
            border-radius: 15px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            padding: 2rem;
        }
        h2 {
            font-weight: 700;
            color: #185a9d;
        }
        .navbar-brand {
            font-weight: 600;
            font-size: 1.5rem;
        }
        .grid-header {
            background-color: #185a9d;
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
                <a class="navbar-brand" href="AdminDashboard.aspx">⬅️ Admin Dashboard</a>
                <div class="navbar-nav ms-auto">
                    <asp:Button ID="btnBackDashboard" runat="server" Text="Back to Dashboard" CssClass="btn btn-outline-light" OnClick="btnBackDashboard_Click" />
                </div>
            </div>
        </nav>

        <div class="container mt-5">
            <div class="card">
                <h2 class="mb-4">📊 Student Report</h2>
                <asp:GridView ID="gvStudents" runat="server" CssClass="table table-bordered table-hover"
                              AutoGenerateColumns="false" EmptyDataText="No student records found."
                              HeaderStyle-CssClass="grid-header">
                    <Columns>
                        <asp:BoundField DataField="StudentID" HeaderText="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Department" HeaderText="Department" />
                        <asp:BoundField DataField="CGPA" HeaderText="CGPA" DataFormatString="{0:F2}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
