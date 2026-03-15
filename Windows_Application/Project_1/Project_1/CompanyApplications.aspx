<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyApplications.aspx.cs" Inherits="Project_1.CompanyApplications" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Applications - Campus Selection System</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow-lg">
                <!-- Logout -->
                <asp:Button ID="btnLogout" runat="server" Text="🚪 Logout"
                           CssClass="btn btn-outline-danger position-absolute top-0 end-0 m-3"
                           OnClick="btnLogout_Click" />

                <!-- Header -->
                <div class="card-header bg-primary text-white text-center py-4">
                    <h2>📋 <asp:Label ID="lblCompanyName" runat="server" Font-Bold="true"></asp:Label></h2>
                    <p class="mb-0">Manage Job Applications</p>
                </div>

                <div class="card-body p-4">
                    <!-- Applications Grid -->
                    <asp:GridView ID="gvApplications" runat="server" CssClass="table table-hover table-striped"
                                  AutoGenerateColumns="false" GridLines="None" EmptyDataText="No applications found."
                                  OnRowCommand="gvApplications_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="ApplicationID" HeaderText="ID" />
                            <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                            <asp:BoundField DataField="StudentEmail" HeaderText="Email" />
                            <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                            <asp:BoundField DataField="Location" HeaderText="Location" />
                            <asp:BoundField DataField="CGPA" HeaderText="CGPA" DataFormatString="{0:F2}" />
                            <asp:BoundField DataField="AppliedDate" HeaderText="Applied" DataFormatString="{0:dd-MMM-yyyy}" />
                            <asp:TemplateField HeaderText="Status">
                                <ItemTemplate>
                                    <span class="badge <%# GetStatusClass(Eval("Status").ToString()) %>">
                                        <%# Eval("Status") %>
                                    </span>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Actions">
                                <ItemTemplate>
                                    <asp:Button ID="btnShortlist" runat="server" Text="✅ Shortlist"
                                               CssClass="btn btn-success btn-sm me-1"
                                               CommandName="Shortlist" CommandArgument='<%# Eval("ApplicationID") %>' />
                                    <asp:Button ID="btnReject" runat="server" Text="❌ Reject"
                                               CssClass="btn btn-danger btn-sm"
                                               CommandName="Reject" CommandArgument='<%# Eval("ApplicationID") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
