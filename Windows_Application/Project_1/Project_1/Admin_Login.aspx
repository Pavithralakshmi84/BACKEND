<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="Project_1.Admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login - Campus Selection System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        .login-container {
            background: #fff;
            border-radius: 20px;
            box-shadow: 0 15px 35px rgba(0,0,0,0.2);
            padding: 3rem;
            width: 100%;
            max-width: 420px;
            animation: fadeIn 0.8s ease-in-out;
        }
        @keyframes fadeIn {
            from {opacity: 0; transform: translateY(-20px);}
            to {opacity: 1; transform: translateY(0);}
        }
        .login-header {
            text-align: center;
            margin-bottom: 2rem;
        }
        .login-header i {
            font-size: 3.5rem;
            color: #667eea;
            margin-bottom: 1rem;
        }
        .form-control {
            border-radius: 10px;
            padding: 0.75rem 1rem;
            border: 2px solid #e9ecef;
            transition: all 0.3s;
        }
        .form-control:focus {
            border-color: #667eea;
            box-shadow: 0 0 0 0.2rem rgba(102, 126, 234, 0.25);
        }
        .btn-login {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            border: none;
            border-radius: 10px;
            padding: 0.75rem;
            font-weight: 600;
            width: 100%;
            color: #fff;
            transition: all 0.3s;
        }
        .btn-login:hover {
            transform: translateY(-2px);
            box-shadow: 0 10px 20px rgba(102, 126, 234, 0.3);
        }
        .alert {
            border-radius: 10px;
            margin-top: 1rem;
        }
        .back-link {
            text-align: center;
            margin-top: 1.5rem;
        }
        .toggle-password {
            position: absolute;
            right: 15px;
            top: 50%;
            transform: translateY(-50%);
            cursor: pointer;
            color: #667eea;
        }
        .input-group {
            position: relative;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <div class="login-header">
                <i class="fas fa-user-shield"></i>
                <h2 class="mb-1">Admin Login</h2>
                <p class="text-muted">Campus Selection System</p>
            </div>

            <asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnLogin" Visible="true">
                <div class="mb-4">
                    <label class="form-label fw-bold">
                        <i class="fas fa-user me-2"></i>Username
                    </label>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control form-control-lg" 
                        placeholder="Enter admin username" />
                </div>

                <div class="mb-4 input-group">
                    <label class="form-label fw-bold w-100">
                        <i class="fas fa-lock me-2"></i>Password
                    </label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" 
                        CssClass="form-control form-control-lg" placeholder="Enter password"/>
                    <span class="toggle-password" onclick="togglePassword()">
                        <i class="fas fa-eye"></i>
                    </span>
                </div>

                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-login btn-lg" 
                    OnClick="btnLogin_Click" />
            </asp:Panel>

            <asp:Panel ID="pnlMessage" runat="server" Visible="false">
                <asp:Label ID="lblMessage" runat="server" CssClass="alert alert-danger w-100 text-center" Visible="false"></asp:Label>
            </asp:Panel>

            <div class="back-link">
                <a href="Home.aspx" class="text-decoration-none fw-bold text-dark">
                    <i class="fas fa-arrow-left me-1"></i>Back to Home
                </a>
            </div>
        </div>
    </form>

    <script>
        function togglePassword() {
            var input = document.getElementById('<%= txtPassword.ClientID %>');
            var icon = document.querySelector('.toggle-password i');
            if (input.type === "password") {
                input.type = "text";
                icon.classList.remove("fa-eye");
                icon.classList.add("fa-eye-slash");
            } else {
                input.type = "password";
                icon.classList.remove("fa-eye-slash");
                icon.classList.add("fa-eye");
            }
        }
    </script>
</body>
</html>

