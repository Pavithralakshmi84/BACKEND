<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobPosting.aspx.cs" Inherits="Project_1.JobPosting" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Posting Report - Campus Selection System</title>
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
            margin-top: 2rem;
        }
        h2 {
            font-weight: 700;
            color: #185a9d;
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
                <a class="navbar-brand fw-bold" href="CompanyDashboard.aspx">Company Reports</a>
                <div class="navbar-nav ms-auto">
                    <asp:Button ID="btnBackDashboard" runat="server" Text="⬅️ Back to Dashboard" CssClass="btn btn-outline-light" OnClick="btnBackDashboard_Click" />
                </div>
            </div>
        </nav>

        <!-- Job Posting Report -->
        <div class="container">
            <div class="card">
                <h2 class="mb-4">📊 Job Posting Report</h2>
                <asp:GridView ID="gvJobs" runat="server" CssClass="table table-bordered table-hover"
                              AutoGenerateColumns="false" EmptyDataText="No job records found."
                              HeaderStyle-CssClass="grid-header">
                    <Columns>
                        <asp:BoundField DataField="JobID" HeaderText="Job ID" />
                        <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="Location" HeaderText="Location" />
                        <asp:BoundField DataField="EligibilityCGPA" HeaderText="Eligibility CGPA" DataFormatString="{0:F2}" />
                        <asp:BoundField DataField="PostedDate" HeaderText="Posted Date" DataFormatString="{0:dd-MMM-yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
