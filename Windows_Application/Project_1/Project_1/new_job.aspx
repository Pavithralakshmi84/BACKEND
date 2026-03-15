<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="new_job.aspx.cs" Inherits="Project_1.new_job" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Jobs</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container mt-4">
            <h1 class="mb-4">Latest Job Openings</h1>

            <!-- Input fields -->
            <div class="row mb-3">
                <div class="col-md-4">
                    <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" Placeholder="Job Title"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control" Placeholder="Company"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtLocation" runat="server" CssClass="form-control" Placeholder="Location"></asp:TextBox>
                </div>
            </div>

            <asp:Button ID="btnAddJob" runat="server" Text="Add Job" CssClass="btn btn-success mb-3" OnClick="btnAddJob_Click" />

            <!-- GridView -->
            <asp:GridView ID="gvJobs" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="JobID" HeaderText="Job ID" />
                    <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                    <asp:BoundField DataField="Company" HeaderText="Company" />
                    <asp:BoundField DataField="Location" HeaderText="Location" />
                    <asp:BoundField DataField="EligibilityCGPA" HeaderText="Eligibility CGPA" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
