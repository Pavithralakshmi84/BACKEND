<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeBehind="Brand.aspx.cs" Inherits="Master_page.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



    <style>
        .brands-container {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            margin: 20px;
        }
        .brand-card {
            flex: 1 1 200px;
            background-color: #fff;
            border-radius: 6px;
            box-shadow: 0 0 5px rgba(0,0,0,0.1);
            padding: 20px;
            text-align: center;
        }
        .brand-card img {
            max-width: 150px;
            border-radius: 4px;
        }
        .brand-card h3 {
            margin-top: 10px;
            font-size: 18px;
            color: #007acc;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h2>Our Featured Brands</h2>
    <p>Select a brand to manage items.</p>

    <div class="brands-container">
        <div class="brand-card">
            <asp:Image ID="imgMichaelKors" runat="server" ImageUrl="~/MK.jpg" AlternateText="Michael Kors" Width="150px" />
            <h3>Michael Kors</h3>
        </div>
        <div class="brand-card">
            <asp:Image ID="imgGuess" runat="server" ImageUrl="~/guess.jpg" AlternateText="Guess" Width="150px" />
            <h3>Guess</h3>
        </div>
        <div class="brand-card">
            <asp:Image ID="imgCharlesKeith" runat="server" ImageUrl="~/CK.jpg" AlternateText="Charles & Keith" Width="150px" />
            <h3>Charles & Keith</h3>
        </div>
        <div class="brand-card">
            <asp:Image ID="imgLouisVuitton" runat="server" ImageUrl="~/LV.jpg" AlternateText="Louis Vuitton" Width="150px" />
            <h3>Louis Vuitton</h3>
        </div>
        <div class="brand-card">
            <asp:Image ID="imgBaggit" runat="server" ImageUrl="~/Baggit.jpg" AlternateText="Baggit" Width="150px" />
            <h3>Baggit</h3>
        </div>
    </div>



</asp:Content>
