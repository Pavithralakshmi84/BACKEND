<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyDashboard.aspx.cs" Inherits="Project_1.CompanyDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Dashboard</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .navbar {
            background: rgba(255,255,255,0.95);
            backdrop-filter: blur(20px);
            box-shadow: 0 2px 20px rgba(0,0,0,0.1);
        }
        .welcome-card, .stats-card, .table {
            background: rgba(255,255,255,0.95);
            backdrop-filter: blur(20px);
            border-radius: 15px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.1);
        }
        .stats-card { transition: all 0.3s ease; height: 120px; }
        .stats-card:hover { transform: translateY(-5px); }
        .logout-btn {
            background: linear-gradient(135deg, #ff6b6b, #ee5a52);
            border: none;
            border-radius: 12px;
            padding: 10px 20px;
        }
        .table th {
            background: linear-gradient(135deg, #667eea, #764ba2);
            color: white;
            font-weight: 600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-light py-3">
            <div class="container">
                <a class="navbar-brand fw-bold fs-3" href="CompanyDashboard.aspx">
                    🏢 <asp:Label ID="lblCompanyName" runat="server" CssClass="text-primary"></asp:Label>
                </a>
                <div class="navbar-nav ms-auto">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn logout-btn text-white" 
                               OnClick="btnLogout_Click" />
                </div>
            </div>
        </nav>

        <div class="container-fluid mt-5 pt-5">
            <!-- Stats Cards -->
            <div class="row mb-5">
                <div class="col-md-3 mb-4">
                    <div class="stats-card p-4 text-center h-100">
                        <h2 class="text-primary mb-1"><asp:Label ID="lblTotalJobs" runat="server" Text="0"></asp:Label></h2>
                        <p class="mb-0 fw-bold text-muted">Total Jobs Posted</p>
                    </div>
                </div>
                <div class="col-md-3 mb-4">
                    <div class="stats-card p-4 text-center h-100 bg-success bg-opacity-10">
                        <h2 class="text-success mb-1"><asp:Label ID="lblTotalApplications" runat="server" Text="0"></asp:Label></h2>
                        <p class="mb-0 fw-bold text-success">Total Applications</p>
                    </div>
                </div>
                <div class="col-md-3 mb-4">
                    <div class="stats-card p-4 text-center h-100 bg-warning bg-opacity-10">
                        <h2 class="text-warning mb-1"><asp:Label ID="lblNewApplications" runat="server" Text="0"></asp:Label></h2>
                        <p class="mb-0 fw-bold text-warning">New Applications</p>
                    </div>
                </div>
                <div class="col-md-3 mb-4">
                    <div class="stats-card p-4 text-center h-100 bg-info bg-opacity-10">
                        <h2 class="text-info mb-1"><asp:Label ID="lblShortlisted" runat="server" Text="0"></asp:Label></h2>
                        <p class="mb-0 fw-bold text-info">Shortlisted Students</p>
                    </div>
                </div>
            </div>

            <!-- Action Buttons -->
            <div class="row mb-5">
                <div class="col-md-4 mb-3">
                    <asp:Button ID="btnPostJob" runat="server" Text="📤 Post New Job" CssClass="btn btn-primary w-100" OnClick="btnPostJob_Click" />
                </div>
                <div class="col-md-4 mb-3">
                    <asp:Button ID="btnViewApplications" runat="server" Text="📋 View Applications" CssClass="btn btn-success w-100" OnClick="btnViewApplications_Click" />
                </div>
                <div class="col-md-4 mb-3">
                    <asp:Button ID="btnEditProfile" runat="server" Text="👤 Edit Profile" CssClass="btn btn-info w-100" OnClick="btnEditProfile_Click" />
                </div>
            </div>

            <!-- Jobs Posted Table -->
            <h3 class="mb-4">Jobs Posted</h3>
            <div class="table-responsive mb-5">
                <asp:GridView ID="gvJobs" runat="server" CssClass="table table-hover"
                              AutoGenerateColumns="False" EmptyDataText="No jobs posted yet.">
                    <Columns>
                        <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                        <asp:BoundField DataField="Location" HeaderText="Location" />
                        <asp:BoundField DataField="Deadline" HeaderText="Deadline" DataFormatString="{0:dd-MMM-yyyy}" />
                        <asp:BoundField DataField="MaxApplications" HeaderText="Max Applications" />
                        <asp:BoundField DataField="PostedDate" HeaderText="Posted On" DataFormatString="{0:dd-MMM-yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Recent Applications Table -->
            <h3 class="mb-4">Recent Applications</h3>
            <div class="table-responsive mb-5">
                <asp:GridView ID="gvApplications" runat="server" CssClass="table table-hover" 
                             AutoGenerateColumns="false" EmptyDataText="No applications yet. Post a job to get applications!"
                             OnRowDataBound="gvApplications_RowDataBound" OnRowCommand="gvApplications_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="StudentName" HeaderText="Student" />
                        <asp:BoundField DataField="JobRole" HeaderText="Job Applied" />
                        <asp:BoundField DataField="CGPA" HeaderText="CGPA" DataFormatString="{0:F2}" />
                        <asp:BoundField DataField="AppliedDate" HeaderText="Applied" DataFormatString="{0:dd-MMM-yyyy}" />
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:Button ID="btnShortlist" runat="server" Text="✅ Shortlist"
                                           CssClass="btn btn-success btn-sm"
                                           CommandName="Shortlist" CommandArgument='<%# Eval("StudentEmail") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Shortlisted Students Table -->
            <h3 class="mb-4">Shortlisted Students</h3>
            <div class="table-responsive">
                <asp:GridView ID="gvShortlisted" runat="server" CssClass="table table-hover"
                              AutoGenerateColumns="false" EmptyDataText="No shortlisted students yet.">
                    <Columns>
                        <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                        <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                        <asp:BoundField DataField="AppliedDate" HeaderText="Applied On" DataFormatString="{0:dd-MMM-yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
