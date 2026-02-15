<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Master_page.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        .about-container {
            background-color: #fff;
            padding: 30px;
            margin: 20px;
            border-radius: 6px;
            box-shadow: 0 0 5px rgba(0,0,0,0.1);
            line-height: 1.6;
        }
        .about-container h2 {
            color: #007acc;
            margin-bottom: 15px;
        }
        .about-container p {
            font-size: 16px;
            color: #333;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="about-container">
        <h2>About Bag World</h2>
        <p>
            Bag World is your one-stop destination for stylish and functional bags. 
            Our collection includes backpacks, tote bags, sling bags, wallets, and handbags 
            from leading brands such as Michael Kors, Guess, Charles & Keith, Louis Vuitton, and Baggit.
        </p>
        <p>
            We are committed to providing high-quality products that combine fashion with practicality. 
            Whether you’re looking for a durable backpack for everyday use, an elegant handbag for special occasions, 
            or a compact wallet to keep your essentials organized, Bag World has something for everyone.
        </p>
        <p>
            Our mission is to make bag shopping easy, enjoyable, and accessible. 
            Explore our collections and discover the perfect bag that matches your style and needs.
        </p>
    </div>


</asp:Content>
