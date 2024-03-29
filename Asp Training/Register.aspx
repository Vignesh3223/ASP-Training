<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Asp_Training.Register" Theme="Common" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container d-flex justify-content-center align-items-center">
        <div class="row mb-3 mt-3">
            <div class="col-6">
                <h3>New User..! Complete the Registration</h3>
                <form id="form1" runat="server" class="mt-4">
                    <div class="form-group mb-2">
                        <asp:Label ID="Label1" runat="server" Text="First Name: " SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="First Name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox1" ForeColor="red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label2" runat="server" Text="Last Name: " SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Last Name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox2" ForeColor="red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label3" runat="server" Text="Username: " SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Username"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox3" ForeColor="red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label4" runat="server" Text="Email: " SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox4" ForeColor="red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter a Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox4" ForeColor="red"></asp:RegularExpressionValidator>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label5" runat="server" Text="Password: " SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox5" ForeColor="red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label6" runat="server" Text="Confirm Password: " SkinID="labelskin"></asp:Label><br />
                        <asp:TextBox ID="TextBox6" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Required Field" ControlToValidate="TextBox6" ForeColor="red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ForeColor="red"></asp:CompareValidator>
                    </div>
                    <asp:Button ID="Button1" class="btn btn-primary mt-2" runat="server" Text="Register" OnClick="btnRegister_Click" SkinID="createbtnskin"/><br />
                     <p class="mt-2">Already a User? <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login...</asp:HyperLink></p>
                </form>
            </div>
            <div class="col-6">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/register.jpg" CssClass="img-fluid" />
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
        height: 450px;
    }

    #HyperLink1 {
        text-decoration: none;
        cursor: pointer;
    }
</style>
