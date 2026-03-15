<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyReport.aspx.cs" Inherits="Project_1.CompanyReport" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Report - Campus Selection System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
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
            color: #667eea;
        }
        .grid-header {
            background-color: #667eea;
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

        <div class="container mt-5">
            <div class="card">
                <h2 class="mb-4">🏢 Company Report</h2>
                <asp:GridView ID="gvCompanies" runat="server" CssClass="table table-bordered table-hover"
                              AutoGenerateColumns="false" EmptyDataText="No company records found."
                              HeaderStyle-CssClass="grid-header">
                    <Columns>
                        <asp:BoundField DataField="CompanyID" HeaderText="Company ID" />
                        <asp:BoundField DataField="Name" HeaderText="Company Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="JobRole" HeaderText="Job Role" />
                        <asp:BoundField DataField="EligibilityCGPA" HeaderText="Eligibility CGPA" DataFormatString="{0:F2}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
