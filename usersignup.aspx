<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="ElibraryManagement.usersignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
    <div class="row">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <img width="100px" src="imgs\loginimage.png" />
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h4>Member Sign Up</h4>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <hr />
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-6">
                            <label>Full Name:</label>
                            <asp:TextBox class="form-control" ID="TextBox3" runat="server" placeholder="Full Name"></asp:TextBox>
                        </div>

                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Date of Birth:</label>
                                <asp:TextBox class="form-control" ID="TextBox4" runat="server" placeholder="Member Id" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                     <div class="row">
                        <div class="col-md-6">
                            <label>Contact No:</label>
                            <asp:TextBox class="form-control" ID="TextBox5" runat="server" placeholder="Enter Your Contact No" TextMode="Phone"></asp:TextBox>
                        </div>

                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Email ID:</label>
                                <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="Enter your Email ID" TextMode="Email"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>State:</label>
                                <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                    <asp:ListItem Text="Select" Value="select"/>
                                    <asp:ListItem Text="Andhra Pradesh" Value="Andhra Pradesh"/>
                                    <asp:ListItem Text="Arunachal Pradesh" Value="Arunachal Pradesh"/>
                                    <asp:ListItem Text="Bihar" Value="Bihar"/>
                                    <asp:ListItem Text="Chhatishgad" Value="Chhatishgad"/>
                                    <asp:ListItem Text="Rajastan" Value="Rajastan"/>
                                </asp:DropDownList>
                            </div>
                        </div>

                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>City:</label>
                                    <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Enter City"></asp:TextBox>
                                </div>
                            </div>

                        <div class="col-md-4">
                            <div class="form-group">
                                <label>Pin Code:</label>
                                <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="Area Pin Code" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>      
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label>Full Adreess:</label>
                                <asp:TextBox class="form-control" ID="TextBox8" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="col">
                            <center>
                            <p>Login Credentials</p>
                            </center>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>User ID:</label>
                                <asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Password:</label>
                                <asp:TextBox class="form-control" placeholder="Password" ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <div class="form-control">
                                <center>
                                <br />
                                <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
                                </center>
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
