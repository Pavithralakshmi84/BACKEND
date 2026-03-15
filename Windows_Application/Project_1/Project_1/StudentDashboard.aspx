<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDashboard.aspx.cs" Inherits="Project_1.StudentDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Dashboard</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
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
        }
        .btn-action {
            border-radius: 12px;
            padding: 12px 24px;
            font-weight: 600;
            text-transform: uppercase;
        }
        .logout-btn {
            background: linear-gradient(135deg, #ff6b6b, #ee5a52);
            border: none;
            border-radius: 12px;
            padding: 10px 20px;
        }
        .home-btn {
            background: linear-gradient(135deg, #43cea2, #185a9d);
            border: none;
            border-radius: 12px;
            padding: 10px 20px;
            color: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-light bg-light shadow-sm">
            <div class="container">
                <a class="navbar-brand fw-bold fs-3" href="StudentDashboard.aspx">
                    🎓 <asp:Label ID="lblStudentName" runat="server" CssClass="text-primary"></asp:Label>
                </a>
                <div class="navbar-nav ms-auto d-flex align-items-center">
                    <!-- Home Button -->
                    <asp:Button ID="btnHome" runat="server" Text="🏠 Home" CssClass="btn home-btn me-2"
                                OnClick="btnHome_Click" />
                    <!-- Logout Button -->
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn logout-btn text-white" 
                                OnClick="btnLogout_Click" />
                </div>
            </div>
        </nav>

        <div class="container mt-5">
            <!-- Action Buttons -->
            <div class="row mb-5">
                <div class="col-md-4 mb-3">
                    <asp:Button ID="btnApplyJob" runat="server" Text="💼 Apply for Jobs" CssClass="btn btn-primary btn-action w-100" 
                               OnClick="btnApplyJob_Click" />
                </div>
                <div class="col-md-4 mb-3">
                    <asp:Button ID="btnBackDashboard" runat="server" Text="⬅️ Refresh Dashboard" CssClass="btn btn-secondary btn-action w-100" 
                               OnClick="btnBackDashboard_Click" />
                </div>
                <div class="col-md-4 mb-3">
                    <asp:Button ID="btnEditStudent" runat="server" Text="👤 Edit Profile" CssClass="btn btn-info btn-action w-100" 
                               OnClick="btnEditStudent_Click" />
                </div>
            </div>

            <!-- Applications Table -->
            <div class="card p-4">
                <h3 class="mb-3">My Applications</h3>
                <asp:GridView ID="gvApplications" runat="server" CssClass="table table-hover"
                              AutoGenerateColumns="false" EmptyDataText="You haven’t applied for any jobs yet.">
                    <Columns>
                        <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="Location" HeaderText="Location" />
                        <asp:BoundField DataField="AppliedDate" HeaderText="Applied On" DataFormatString="{0:dd-MMM-yyyy}" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
