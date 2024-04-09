﻿<%@ Page Title="Products Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Asp_Training.Products" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Products</title>
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquer/3.5.1/jquery.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
        <script type="text/javascript">
    </head>
    <body>
        <div class="container mt-5">
            <div class="d-flex mb-5 flex-grow-1">
                <button type="button" id="GetProducts" class="btn btn-primary me-4">Get Products</button>
            </div>
            <div>
                <h1>Products</h1>
                <table class="table table-bordered border-dark productsTable">
                    <thead>
                        <tr>
                            <th>Product ID</th>
                            <th>Name</th>
                            <th>Brand</th>
                            <th>Price</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><span class="productID"></span></td>
                            <td><span class="name"></span></td>
                            <td><span class="brand"></span></td>
                            <td><span class="price"></span></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
