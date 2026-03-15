<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyJobs.aspx.cs" Inherits="Project_1.ApplyJobs" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Apply for Jobs</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <h2 class="mb-4">Available Jobs</h2>

        <!-- Jobs Grid -->
        <asp:GridView ID="gvJobs" runat="server" CssClass="table table-striped"
                      AutoGenerateColumns="false" OnRowCommand="gvJobs_RowCommand">
            <Columns>
                <asp:BoundField DataField="JobID" HeaderText="Job ID" />
                <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                <asp:BoundField DataField="Company" HeaderText="Company" />
                <asp:BoundField DataField="Location" HeaderText="Location" />
                <asp:BoundField DataField="EligibilityCGPA" HeaderText="Eligibility CGPA" />
                <asp:ButtonField Text="Apply" CommandName="Apply" ButtonType="Button" />
            </Columns>
        </asp:GridView>

        <asp:Label ID="lblMessage" runat="server" CssClass="text-success fw-bold"></asp:Label>

        <!-- Back to Dashboard -->
        <div class="mt-4">
            <asp:Button ID="btnBackDashboard" runat="server" Text="⬅️ Back to Dashboard"
                        CssClass="btn btn-secondary" OnClick="btnBackDashboard_Click" />
        </div>
    </form>
</body>
</html>
