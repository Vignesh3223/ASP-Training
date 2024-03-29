<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Asp_Training._Default" Theme="Common" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row mb-3">
            <div class="col-md-4 d-flex flex-column">
                <div class="mb-3">
                    <h1>Table Operations</h1>
                    <div class="d-flex gap-3 flex-grow-1">
                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Create" OnClick="btnCreate_Click" SkinID="createbtnskin"/>
                        <asp:Button ID="Button7" class="btn btn-danger" runat="server" Text="Drop" OnClick="btnDrop_Click" SkinID="deletebtnskin" />
                    </div>
                </div>
                <div class="mb-3">
                    <h1>Display Table</h1>
                    <div class="flex-grow-0">
                        <asp:Button ID="Button2" class="btn btn-info" runat="server" Text="Display" OnClick="btnDisplay_Click" SkinID="displaybtnskin" />
                    </div>
                </div>
                <div class="mb-3">
                    <h3>Records</h3>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label6" runat="server" Text="ID" CssClass="col-form-label" SkinID="label1skin"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label7" runat="server" Text="First name" CssClass="col-form-label" SkinID="label1skin"></asp:Label>
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label8" runat="server" Text="Last name" CssClass="col-form-label" SkinID="label1skin"></asp:Label>
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group mb-2">
                        <asp:Label ID="Label9" runat="server" Text="Email" CssClass="col-form-label" SkinID="label1skin"></asp:Label>
                        <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="d-flex gap-3 flex-grow-0 mt-3">
                        <asp:Button ID="Button3" class="btn btn-primary" runat="server" Text="Insert" OnClick="btnAdd_Click" SkinID="createbtnskin" />
                        <asp:Button ID="Button4" class="btn btn-success" runat="server" Text="Update" OnClick="btnUpdate_Click" SkinID="updatebtnskin" />
                        <asp:Button ID="Button5" class="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" SkinID="deletebtnskin" />
                    </div>
                </div>
            </div>
            <div class="col-md-8 d-flex flex-column mt-3">
                <div class="d-flex justify-content-center align-items-center">
                    <asp:Label ID="successMessage" runat="server" CssClass="alert alert-success" Visible="false"></asp:Label>
                    <asp:Label ID="errorMessage" runat="server" CssClass="alert alert-danger" Visible="false"></asp:Label>
                </div>
                <div class="mt-5 d-flex flex-column justify-content-center align-items-center">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="custom-grid" SkinID="gridviewskin">
                        <EmptyDataTemplate>
                            <div>No data available</div>
                        </EmptyDataTemplate>
                        <Columns>
                            <asp:BoundField HeaderText="Id" DataField="Id" />
                            <asp:BoundField HeaderText="First Name" DataField="Firstname" />
                            <asp:BoundField HeaderText="Last Name" DataField="Lastname" />
                            <asp:BoundField HeaderText="Email" DataField="Email" />
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="Button6" class="btn btn-primary" runat="server" Text="Select" OnClick="btnSelect_Click" SkinID="displaybtnskin" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </main>

    <style>
        .custom-grid {
            border-collapse: separate;
            border-spacing: 10px;
        }

            .custom-grid th,
            .custom-grid td {
                padding: 10px;
                text-align: center;
                border-left: 1px solid;
                border-bottom: 1px solid;
            }
    </style>

</asp:Content>

