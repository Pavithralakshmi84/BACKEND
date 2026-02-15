<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Master_page.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
     .welcome-box {
         background-color: #fff;
         padding: 20px;
         margin: 20px;
         border-radius: 6px;
         box-shadow: 0 0 5px rgba(0,0,0,0.1);
     }
     .quick-links {
         display: flex;
         flex-wrap: wrap;
         gap: 20px;
         margin: 20px;
     }
     .link-card {
         flex: 1 1 200px;
         background-color: #007acc;
         color: #fff;
         text-align: center;
         padding: 20px;
         border-radius: 6px;
         text-decoration: none;
         font-weight: bold;
     }
     .link-card:hover {
         background-color: #005f99;
     }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

 <h1>Welcome to Bag World</h1>
    <p>Please choose your portal:</p>

    <div class="home-container">
        <div class="home-card">
            <h2>Admin</h2>
            <p>Manage products, brands, and users.</p>
            <asp:HyperLink ID="lnkAdmin" runat="server" NavigateUrl="~/Admin_Master.master" Text="Go to Admin Page" />
        </div>
        <div class="home-card">
            <h2>User</h2>
            <p>Browse products and explore brands.</p>
            <asp:HyperLink ID="lnkUser" runat="server" NavigateUrl="~/User/Product.aspx" Text="Go to User Page" />
        </div>
    </div>
</asp:Content>
