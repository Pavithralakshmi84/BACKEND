<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview Crud.aspx.cs" Inherits="Gridview.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
<asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />

<asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
   <asp:TextBox ID="TxtEmail" runat="server" OnTextChanged="TxtEmail_TextChanged"></asp:TextBox><br />
<asp:Label ID="Label3" runat="server" Text="Salary"></asp:Label>
   <asp:TextBox ID="TxtSalary" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click" />


            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpId" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-top: 16px">
                <Columns>
                    <asp:BoundField DataField="EmpId" HeaderText="Employee Id" />
                    <asp:BoundField DataField="Name" HeaderText="Employee Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            
            
        </div>
    </form>
</body>
</html>
