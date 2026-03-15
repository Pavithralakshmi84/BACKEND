<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostJob.aspx.cs" Inherits="Project_1.PostJob" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Post New Job</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        body { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); min-height: 100vh; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; }
        .job-form-card { background: rgba(255,255,255,0.95); backdrop-filter: blur(20px); border-radius: 20px; box-shadow: 0 20px 40px rgba(0,0,0,0.1); max-width: 700px; margin: 50px auto; padding: 40px; }
        .form-label { font-weight: 600; color: #2c3e50; margin-bottom: 8px; font-size: 15px; }
        .form-control, .form-select { border: 2px solid #e9ecef; border-radius: 12px; padding: 14px 18px; font-size: 16px; background: #f8f9fa; }
        .form-control:focus, .form-select:focus { border-color: #667eea; box-shadow: 0 0 0 0.2rem rgba(102,126,234,0.25); background: white; transform: translateY(-1px); }
        .btn-post { background: linear-gradient(135deg, #48bb78, #38a169); border: none; border-radius: 12px; padding: 16px 40px; font-size: 18px; font-weight: 600; color: white; width: 100%; }
        .btn-post:hover { background: linear-gradient(135deg, #38a169, #2f855a); transform: translateY(-2px); box-shadow: 0 10px 25px rgba(72,187,120,0.4); }
        .btn-back { background: linear-gradient(135deg, #667eea, #764ba2); border: none; border-radius: 12px; padding: 12px 30px; color: white; font-weight: 500; }
        .job-header { text-align: center; margin-bottom: 35px; }
        .job-header h1 { font-size: 2.5rem; font-weight: 700; background: linear-gradient(135deg, #667eea, #764ba2);}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="job-form-card">
            <div class="job-header">
                <h1>📤 Post New Job</h1>
                <p class="lead mb-0">Create a new job opening for students to apply</p>
            </div>

            <!-- ✅ FIXED Message Label -->
            <asp:Label ID="lblMessage" runat="server" Visible="false" CssClass="alert mt-3 w-100"></asp:Label>

            <!-- Job Title + Salary -->
            <div class="row">
                <div class="col-md-6 mb-4">
                    <label class="form-label">Job Title <span class="text-danger">*</span></label>
                    <asp:TextBox ID="txtJobTitle" runat="server" CssClass="form-control" placeholder="Software Developer"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-4">
                    <label class="form-label">Salary (₹ per annum)</label>
                    <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control" TextMode="Number" placeholder="500000"></asp:TextBox>
                </div>
            </div>

            <!-- ✅ NEW LOCATION + Max Applicants -->
            <div class="row">
                <div class="col-md-6 mb-4">
                    <label class="form-label">Location</label>
                    <asp:TextBox ID="txtLocation" runat="server" CssClass="form-control" placeholder="Chennai / Remote / Bangalore"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-4">
                    <label class="form-label">Max Applicants</label>
                    <asp:TextBox ID="txtMaxApps" runat="server" CssClass="form-control" TextMode="Number" Text="100"></asp:TextBox>
                </div>
            </div>

            <!-- Skills + Experience -->
            <div class="row">
                <div class="col-md-6 mb-4">
                    <label class="form-label">Required Skills</label>
                    <asp:TextBox ID="txtSkills" runat="server" CssClass="form-control" placeholder="C#, ASP.NET, SQL Server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-4">
                    <label class="form-label">Experience Level</label>
                    <asp:DropDownList ID="ddlExperience" runat="server" CssClass="form-select">
                        <asp:ListItem Value="Fresher">Fresher</asp:ListItem>
                        <asp:ListItem Value="1 Year">1 Year</asp:ListItem>
                        <asp:ListItem Value="2 Years">2 Years</asp:ListItem>
                        <asp:ListItem Value="3+ Years">3+ Years</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!-- Description -->
            <div class="mb-4">
                <label class="form-label">Job Description <span class="text-danger">*</span></label>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" placeholder="Describe job responsibilities, requirements..."></asp:TextBox>
            </div>

            <!-- Deadline -->
            <div class="mb-4">
                <label class="form-label">Application Deadline</label>
                <asp:TextBox ID="txtDeadline" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>

            <!-- Buttons -->
            <div class="d-grid gap-3 d-md-flex justify-content-md-end">
                <asp:Button ID="btnPostJob" runat="server" Text="🚀 Post Job Live" CssClass="btn-post btn-lg px-4 me-md-2" OnClick="btnPostJob_Click" />
                <a href="CompanyDashboard.aspx" class="btn btn-back btn-lg px-4">← Dashboard</a>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
