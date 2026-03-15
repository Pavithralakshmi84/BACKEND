<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="Project_1.EditProfile" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Edit Company Profile</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body { background: linear-gradient(135deg, #f5f7fa 0%, #c3cfe2 100%); min-height: 100vh; }
        .profile-card { background: rgba(255,255,255,0.95); backdrop-filter: blur(10px); border-radius: 20px; }
        .form-floating { margin-bottom: 1.5rem; }
        .btn-modern { border-radius: 50px; font-weight: 600; transition: all 0.3s; }
        .btn-modern:hover { transform: translateY(-2px); box-shadow: 0 8px 25px rgba(0,0,0,0.2); }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-8 col-lg-6">
                    <div class="profile-card shadow-lg p-5">
                        
                        <!-- Header -->
                        <div class="text-center mb-4">
                            <h2 class="fw-bold text-primary">Edit Company Profile</h2>
                            <asp:Label ID="lblMessage" runat="server" CssClass="alert" Visible="false"></asp:Label>
                        </div>

                        <!-- Company Name -->
                        <div class="form-floating">
                            <asp:TextBox ID="txtCompanyName" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                            <asp:Label ID="lblCompanyName" runat="server" AssociatedControlID="txtCompanyName" Text="Company Name *"></asp:Label>
                            <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" ControlToValidate="txtCompanyName"
                                ErrorMessage="Company name is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                        <!-- Email (Read Only) -->
                        <div class="form-floating">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control bg-light" ReadOnly="true" placeholder="Email"></asp:TextBox>
                            <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email (Cannot be changed)"></asp:Label>
                        </div>

                        <!-- Job Role -->
                        <div class="form-floating">
                            <asp:TextBox ID="txtJobRole" runat="server" CssClass="form-control" placeholder="Job Role"></asp:TextBox>
                            <asp:Label ID="lblJobRole" runat="server" AssociatedControlID="txtJobRole" Text="Job Role"></asp:Label>
                        </div>

                        <!-- Eligibility CGPA -->
                        <div class="form-floating">
                            <asp:TextBox ID="txtEligibilityCGPA" runat="server" CssClass="form-control" TextMode="Number" placeholder="Eligibility CGPA"></asp:TextBox>
                            <asp:Label ID="lblCGPA" runat="server" AssociatedControlID="txtEligibilityCGPA" Text="Eligibility CGPA (0-10)"></asp:Label>
                            <asp:RangeValidator ID="rvCGPA" runat="server" ControlToValidate="txtEligibilityCGPA"
                                MinimumValue= 0 MaximumValue=10 ErrorMessage="CGPA must be between 0-10"
                                CssClass="text-danger" Display="Dynamic" Type="Double"></asp:RangeValidator>
                        </div>

                        <!-- Buttons -->
                        <div class="d-flex gap-3 justify-content-center mt-4">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" CssClass="btn btn-success btn-modern"
                                OnClick="btnUpdate_Click" />
                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-warning btn-modern"
                                OnClick="btnReset_Click" CausesValidation="false" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary btn-modern"
                                OnClick="btnCancel_Click" CausesValidation="false" />
                        </div>

                        <!-- Back to Dashboard -->
                        <div class="text-center mt-3">
                            <asp:HyperLink ID="lnkDashboard" runat="server" NavigateUrl="CompanyDashboard.aspx"
                                CssClass="text-decoration-none text-primary fw-bold">← Back to Dashboard</asp:HyperLink>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
