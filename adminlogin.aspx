<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="ElibraryManagement.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Button2 {
            width: 510px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs\admin.jpg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Admin LogIn</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>Email ID:</label>
                                    <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="Enter Email Id"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label>Password:</label>
                                    <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox><br />
                                </div>

                                <div class="d-grid gap-2">
                                    <div class="form-group">
                                        <asp:Button class="btn btn-success btn-lg" ID="Button1" runat="server" Text="Sign In" Width="509px" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <a href="HomePage.aspx"><< Back to Home Page</a><br /><br />
            </div>
        </div>
    </div>

</asp:Content>
