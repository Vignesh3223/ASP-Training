<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Asp_Training.Login" Theme="Common" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container d-flex justify-content-center align-items-center">
        <div class="row mb-3 mt-5">
            <div class="col-6">
                <h1>Login</h1>
                <form id="form1" runat="server" class="mt-4">
                    <div class="form-group mb-3">
                        <asp:Label ID="Label1" runat="server" Text="Username" SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group mb-3">
                        <asp:Label ID="Label2" runat="server" Text="Password" SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox2" runat="server"  TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click" SkinID="createbtnskin"/><br />
                    <p class="mt-3">New User?
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Create an account...</asp:HyperLink></p>
                </form>
            </div>
            <div class="col-6">
                <asp:Image runat="server" ImageUrl="~/Images/login.png" CssClass="img-fluid"></asp:Image>
            </div>
        </div>
    </div>
</body>
</html>
<style>
    .row {
        border: 1px double black;
        border-radius: 0 20px;
    }

    form {
        border-right: 1px solid black;
        height: 400px;
    }

    #HyperLink1 {
        text-decoration: none;
        cursor: pointer;
    }
</style>
