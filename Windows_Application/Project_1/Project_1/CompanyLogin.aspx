<%@ Page Language="C#" AutoEventWireup="true" 
         CodeBehind="CompanyLogin.aspx.cs" Inherits="Project_1.CompanyLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Login</title>
   
    <style>
        * { margin: 0; padding: 0; box-sizing: border-box; }
        body { 
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; 
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 20px;
        }
        .login-container { 
            max-width: 450px; 
            width: 100%;
            background: rgba(255, 255, 255, 0.95);
            backdrop-filter: blur(20px);
            padding: 40px; 
            border-radius: 25px; 
            box-shadow: 0 25px 50px rgba(0,0,0,0.15);
            border: 1px solid rgba(255,255,255,0.2);
            animation: slideUp 0.8s ease-out;
        }
        @keyframes slideUp {
            from { opacity: 0; transform: translateY(40px); }
            to { opacity: 1; transform: translateY(0); }
        }
        .login-header { 
            text-align: center; 
            margin-bottom: 35px; 
        }
        .login-header h2 { 
            color: #2c3e50; 
            margin: 0 0 8px 0; 
            font-size: 32px;
            font-weight: 700;
            background: linear-gradient(135deg, #667eea, #764ba2);
           
        }
        .login-header p { 
            color: #7f8c8d; 
            margin: 0;
            font-size: 16px;
        }
        .form-group { 
            margin-bottom: 25px; 
        }
        .form-label { 
            display: block; 
            margin-bottom: 10px; 
            font-weight: 600; 
            color: #34495e;
            font-size: 15px;
        }
        .form-control { 
            width: 100%; 
            padding: 16px 20px; 
            border: 2px solid #e1e8ed; 
            border-radius: 12px; 
            font-size: 16px;
            transition: all 0.3s ease;
            background: #fafbfc;
            font-family: inherit;
        }
        .form-control:focus {
            outline: none;
            border-color: #667eea;
            box-shadow: 0 0 0 4px rgba(102, 126, 234, 0.15);
            background: white;
            transform: translateY(-2px);
        }
        .btn-group {
            display: flex;
            gap: 15px;
            margin-top: 15px;
        }
        .btn {
            flex: 1;
            padding: 16px 24px;
            border: none;
            border-radius: 12px;
            cursor: pointer;
            font-size: 16px;
            font-weight: 600;
            transition: all 0.3s ease;
            text-transform: uppercase;
            letter-spacing: 0.8px;
            font-family: inherit;
        }
        .btn-login {
            background: linear-gradient(135deg, #667eea, #764ba2);
            color: white;
        }
        .btn-login:hover {
            background: linear-gradient(135deg, #5a67d8, #6b46c1);
            transform: translateY(-3px);
            box-shadow: 0 12px 30px rgba(102, 126, 234, 0.4);
        }
        .btn-register {
            background: linear-gradient(135deg, #48bb78, #38a169);
            color: white;
        }
        .btn-register:hover {
            background: linear-gradient(135deg, #38a169, #2f855a);
            transform: translateY(-3px);
            box-shadow: 0 12px 30px rgba(72, 187, 120, 0.4);
        }
        @media (max-width: 480px) {
            .login-container { margin: 10px; padding: 30px 25px; }
            .btn-group { flex-direction: column; gap: 12px; }
            .login-header h2 { font-size: 26px; }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <div class="login-header">
                <h2>🏢 Company Login</h2>
                <p>Access your company dashboard & post jobs</p>
            </div>

            <div class="form-group">
                <label class="form-label">Company Email</label>
                <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" 
                           placeholder="Enter your company email" TextMode="Email"></asp:TextBox>
            </div>

            <div class="form-group">
                <label class="form-label">Password</label>
                <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" 
                           placeholder="Enter your password" TextMode="Password"></asp:TextBox>
            </div>

            <div class="btn-group">
                <asp:Button ID="BtnLogin" runat="server" Text="Login" CssClass="btn btn-login" OnClick="BtnLogin_Click" 
                            />
                <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-register" OnClick="Button1_Click" 
                          />
            </div>
        </div>
    </form>
</body>
</html>
