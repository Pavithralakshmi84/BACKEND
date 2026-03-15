<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shortlist.aspx.cs" Inherits="Project_1.Shortlist" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shortlist - Campus Selection System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body {
            background: linear-gradient(135deg, #00c6ff 0%, #0072ff 100%);
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
            color: #0072ff;
        }
        .grid-header {
            background-color: #0072ff;
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

        <!-- Shortlist Report -->
        <div class="container">
            <div class="card">
                <h2 class="mb-4">✅ Shortlisted Applications</h2>
                <asp:GridView ID="gvShortlist" runat="server" CssClass="table table-bordered table-hover"
                              AutoGenerateColumns="false" EmptyDataText="No shortlisted applications found."
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
