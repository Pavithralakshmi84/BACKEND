<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="Project_1.Company" %>


   <!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company registration

    </title>
    <asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .reg-container { max-width: 500px; margin: 50px auto; padding: 30px; }
        .reg-card { background: #f8f9fa; padding: 30px; border-radius: 10px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }
        .form-group { margin-bottom: 20px; }
        .form-group label { display: block; margin-bottom: 8px; font-weight: bold; color: #2c3e50; }
        .form-group input, .form-group select { width: 100%; padding: 12px; border: 1px solid #ddd; border-radius: 5px; box-sizing: border-box; font-size: 16px; }
        .btn-register { width: 100%; padding: 12px; background: #27ae60; color: white; border: none; border-radius: 5px; font-size: 16px; cursor: pointer; }
        .btn-register:hover { background: #229954; }
        .reg-title { text-align: center; color: #2c3e50; margin-bottom: 30px; }
        .switch-link { text-align: center; margin-top: 20px; }
        .switch-link a { color: #3498db; text-decoration: none; }
    </style>


    <div class="reg-container">
        <div class="reg-card">
            <h2 class="reg-title">🏢 Company Registration</h2>
            
            <div class="form-group">
                <label>Company Name:</label>
                <asp:TextBox ID="txtCompanyName" runat="server" placeholder="Tech Corp Ltd"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="company@example.com"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter strong password"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Job Role:</label>
                <asp:TextBox ID="txtJobRole" runat="server" placeholder="Software Engineer, Data Analyst, etc."></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Eligibility CGPA:</label>
                <asp:TextBox ID="txtCGPA" runat="server" TextMode="Number" step="0.01" min="0" max="10" placeholder="7.5"></asp:TextBox>
                <small>Minimum CGPA required (0-10)</small>
            </div>
            
            <asp:Button ID="btnRegister" runat="server" Text="Register Company" CssClass="btn-register" 
                        OnClick="btnRegister_Click" />
            
            <div class="switch-link">
                <p>Already registered? <a href="CompanyLogin.aspx">Login here</a></p>
                <p><a href="StudentLogin.aspx">Login as Student</a></p>
            </div>
        </div>
    </div>
</asp:Content>


