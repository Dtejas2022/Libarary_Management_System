<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminauthormanagement.aspx.cs" Inherits="ElibraryManagement.adminauthormanagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Author Details</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/auther.jpg" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Auther ID:</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="TextBox1" placeholder="Auther ID" runat="server"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Auther Name:</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox2" placeholder="Auther Name" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <asp:Button class=" btn btn-lg btn-block btn-success form-control" ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <asp:Button class="btn btn-lg btn-block btn-warning form-control" ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <asp:Button class="btn btn-lg btn-block btn-danger form-control" ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-7">
                <%--search bar--%>
                                <asp:TextBox ID="txtsearch" class="form-control" runat="server"></asp:TextBox><asp:Button CssClass="form-control my-2 btn btn-primary" ID="Button5" runat="server" Text="Search" OnClick="Button5_Click" />
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Author List</h3>
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
                                <table class="table table-responsive">
                                    <tr>
                                        <td>Auther Id</td>
                                        <td>Auther Name</td>
                                    </tr>
                                </table>

                                <table class="table table-responsive text-center">
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("author_id")  %></td>
                                                <td><%#Eval("author_name")  %></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>

                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>

    </div>

</asp:Content>
