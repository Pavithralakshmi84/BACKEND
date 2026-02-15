<%@ Page Title="Products" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Master_page.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <style>
        .products-container {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            margin: 20px;
        }
        .product-card {
            flex: 1 1 200px;
            background-color: #fff;
            border-radius: 6px;
            box-shadow: 0 0 5px rgba(0,0,0,0.1);
            padding: 20px;
            text-align: center;
        }
        .product-card img {
            max-width: 150px;
            height: auto;
            border-radius: 4px;
        }
        .product-card h3 {
            margin-top: 10px;
            font-size: 18px;
            color: #007acc;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Our Product Categories</h2>
    <p>Select a category to manage items.</p>

    <div class="products-container">
        <div class="product-card">
            <asp:Image ID="imgBackpack" runat="server" ImageUrl="~/backpack.jpg" AlternateText="Backpack" />
            <h3>Backpack</h3>
        </div>
        <div class="product-card">
            <asp:Image ID="imgTote" runat="server" ImageUrl="~/Tote.jpg" AlternateText="Tote Bag" />
            <h3>Tote Bag</h3>
        </div>
        <div class="product-card">
            <asp:Image ID="imgSling" runat="server" ImageUrl="~/sling.jpg" AlternateText="Sling Bag" />
            <h3>Sling Bag</h3>
        </div>
        <div class="product-card">
            <asp:Image ID="imgWallet" runat="server" ImageUrl="~/wallet.jpg" AlternateText="Wallet" />
            <h3>Wallet</h3>
        </div>
        <div class="product-card">
            <asp:Image ID="imgHandbag" runat="server" ImageUrl="~/handbag.jpg" AlternateText="Handbag" />
            <h3>Handbag</h3>
        </div>
    </div>
</asp:Content>
