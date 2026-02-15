<%@ Page Title="Exit" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeBehind="Exit.aspx.cs" Inherits="Master_page.Admin.Exit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .exit-container {
            background-color: #fff;
            padding: 30px;
            margin: 20px;
            border-radius: 6px;
            box-shadow: 0 0 5px rgba(0,0,0,0.1);
            text-align: center;
        }
        .exit-container h2 {
            color: #007acc;
            margin-bottom: 15px;
        }
        .exit-container p {
            font-size: 16px;
            color: #333;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="exit-container">
        <h2>You have successfully logged out</h2>
        <p>Thank you for using Bag World Admin Panel.</p>
        <asp:HyperLink ID="hlLogin" runat="server" NavigateUrl="~/Login.aspx" Text="Click here to login again" />
    </div>
</asp:Content>
