<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyRegister.aspx.cs" Inherits="Project_1.CompanyRegister" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Registration</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 0; background: #f0f2f5; }
        .container { max-width: 600px; margin: 40px auto; background: white; padding: 30px; border-radius: 10px; box-shadow: 0 5px 15px rgba(0,0,0,0.1); }
        h2 { text-align: center; color: #333; margin-bottom: 20px; }
        .form-label { display: block; margin-bottom: 5px; font-weight: bold; }
        .form-control { width: 100%; padding: 10px; margin-bottom: 15px; border: 1px solid #ccc; border-radius: 5px; }
        .btn { background: #667eea; color: white; padding: 10px 20px; border: none; border-radius: 5px; cursor: pointer; }
        .btn:hover { background: #5a6fd8; }
        .message { margin-top: 15px; padding: 10px; border-radius: 5px; text-align: center; }
        .success { background: #d4edda; color: #155724; }
        .error { background: #f8d7da; color: #721c24; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Company Registration</h2>

            <label class="form-label">Company Name</label>
            <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>

            <label class="form-label">Email</label>
            <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox>

            <label class="form-label">Password</label>
            <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

            <label class="form-label">Job Role</label>
            <asp:TextBox ID="TxtJobRole" runat="server" CssClass="form-control"></asp:TextBox>

            <label class="form-label">Eligibility CGPA</label>
            <asp:TextBox ID="TxtCGPA" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Button ID="BtnRegister" runat="server" Text="Register Company" CssClass="btn" OnClick="BtnRegister_Click" />

        
        </div>
    </form>
</body>
</html>
