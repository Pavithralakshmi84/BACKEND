<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview withoutDB.aspx.cs" Inherits="Gridview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <style>
        .btn-spacing { margin-right: 15px; margin-bottom: 20px; }
        .gv-container { max-width: 100%; overflow-x: auto; }
        .gv-custom { 
            width: 100%; 
            border-collapse: collapse; 
        }
        .gv-custom th { 
            background-color: #11AEA3; color: white; padding: 10px; text-align: center; 
        }
        .gv-custom td { 
            padding: 10px; border: 1px solid #ddd; 
        }
        .gv-custom tr:nth-child(even) { background-color: #f2f2f2; }
    </style>

</head>
<body class="container mt-4">
    <form id="form1" runat="server">
        <div class="row justify-content-center">
            <div class="col-md-10">
                <h2 class="text-center mb-4">Data Display Demo</h2>
                <div class="text-center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Using List" CssClass="btn btn-primary btn-spacing" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Using DataTable" CssClass="btn btn-success btn-spacing" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Display in ListView" CssClass="btn btn-info" />
                </div>
                
                <!-- GridView for List and DataTable -->
                <div class="gv-container mt-4">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover gv-custom" AutoGenerateColumns="true">
                    </asp:GridView>
                </div>
                
                <!-- ListView for alternative display -->
                <asp:ListView ID="ListView1" runat="server" Visible="false">
                    <LayoutTemplate>
                        <div class="row">
                            <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="col-md-6 mb-3">
                            <div class="card">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %> (ID: <%# Eval("Id") %>)</h5>
                                    <p class="card-text">
                                        Age: <%# Eval("Age") %><br />
                                        Mobile: <%# Eval("MobileNo") %><br />
                                        Email: <%# Eval("Email") %><br />
                                        Address: <%# Eval("Address") %>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </LayoutView>
            </div>
        </div>
    </form>
</body>
</html>
