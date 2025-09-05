<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="ElibraryManagement.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Button2 {
            width: 509px;
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
                                <img width="150px" src="imgs\loginimage.png" />
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Member LogIn</h3>
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
                                <label>Member ID:</label>
                                <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="Member Id"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>Password:</label>
                                <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                            </div>
                            <br />
                            <div class="d-grid gap-2">
                            <div class="form-group">
                                <asp:Button class="btn btn-success btn-lg" ID="Button1" runat="server" Text="Sign In" Width="509px" OnClick="Button1_Click" />
                            </div>

                            <div class="form-group">
                                <a href="usersignup.aspx">
                                    <input class="btn btn-info btn-lg btn-block" id="Button2" type="button" value="sign Up" />
                                </a>
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
