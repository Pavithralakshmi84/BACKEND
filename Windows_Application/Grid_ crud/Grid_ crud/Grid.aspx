<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="Grid__crud.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Management</title>
      <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            margin: 0;
            padding: 20px;
        }

        .container {
            max-width: 600px;
            margin: 0 auto;
        }

        h3 {
            color: #fff;
            text-align: center;
            margin-bottom: 30px;
            text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
            font-weight: 600;
        }

        .card {
            background: rgba(255, 255, 255, 0.95);
            backdrop-filter: blur(10px);
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0,0,0,0.1);
            padding: 40px;
            border: none;
            transition: transform 0.3s ease;
        }

        .card:hover {
            transform: translateY(-5px);
        }

        .form-label {
            color: #333;
            font-weight: 600;
            margin-bottom: 8px;
            display: block;
        }

        .form-control {
            border: 2px solid #e1e5e9;
            border-radius: 12px;
            padding: 12px 15px;
            font-size: 16px;
            transition: all 0.3s ease;
            background: #f8f9fa;
            width: 100%;
            box-sizing: border-box;
        }

        .form-control:focus {
            border-color: #667eea;
            box-shadow: 0 0 0 0.2rem rgba(102, 126, 234, 0.25);
            background: #fff;
            transform: translateY(-2px);
            outline: none;
        }

        .form-control[readonly] {
            background: #e9ecef;
            color: #6c757d;
        }

        .btn-primary {
            background: linear-gradient(45deg, #667eea, #764ba2);
            border: none;
            border-radius: 50px;
            padding: 15px 40px;
            font-size: 18px;
            font-weight: 600;
            text-transform: uppercase;
            letter-spacing: 1px;
            color: white;
            cursor: pointer;
            transition: all 0.3s ease;
            box-shadow: 0 10px 30px rgba(102, 126, 234, 0.4);
            width: 100%;
        }

        .btn-primary:hover {
            transform: translateY(-3px);
            box-shadow: 0 15px 40px rgba(102, 126, 234, 0.6);
            background: linear-gradient(45deg, #5a6fd8, #6a4190);
        }

        .form-group {
            margin-bottom: 25px;
        }

        .text-center {
            text-align: center;
        }

        .message {
            margin-top: 20px;
            padding: 15px;
            border-radius: 10px;
            text-align: center;
            font-weight: 500;
        }

        .success {
            background: #d4edda;
            color: #155724;
            border: 1px solid #c3e6cb;
        }

        .error {
            background: #f8d7da;
            color: #721c24;
            border: 1px solid #f5c6cb;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
  <asp:Label runat="server" Text="Customer ID"></asp:Label>
<asp:TextBox runat="server" ID="TxtCustID"></asp:TextBox><br /><br />
<asp:Label runat="server" Text="Name"></asp:Label>
<asp:TextBox runat="server" ID="TxtName"></asp:TextBox><br /><br />
<asp:Label runat="server" Text="Address"></asp:Label>
<asp:TextBox runat="server" ID="TxtAddress"></asp:TextBox><br /><br />
<asp:Label runat="server" Text="Phone number"></asp:Label>
<asp:TextBox runat="server" ID="TxtPhno"></asp:TextBox><br /><br />
            <br /><br />
             <br /><br />
            <asp:Button ID="BtnInsert" runat="server" Text="INSERT" OnClick="BtnInsert_Click" />

             <br /><br /> <br /><br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustID" Height="152px" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
                OnRowDeleting="GridView1_RowDeleting"
                OnRowEditing="GridView1_RowEditing"
                OnRowUpdating="GridView1_RowUpdating" Width="553px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                         <Columns>                
                    <asp:BoundField DataField="CustID" HeaderText="Customer Id" />
                    <asp:BoundField DataField="Name" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Phno" HeaderText="Phone Num" />
                             <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                             <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
