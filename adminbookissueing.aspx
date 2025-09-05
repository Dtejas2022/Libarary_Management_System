<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbookissueing.aspx.cs" Inherits="ElibraryManagement.adminbookissueing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Book Issuing</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/books.jpg" />
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
                                <label>Member ID:</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Member ID" ID="TextBox1" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Book ID:</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" placeholder="Book ID" ID="TextBox2" runat="server"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>Member Name:</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Member Name" ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Book Name:</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Book Name" ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>Issue Date:</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Start Date" ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Return Date:</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="End Date" ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-6">
                                <asp:Button class="btn btn-success" ID="Button2" runat="server" Text="Issue Book" OnClick="Button2_Click" />
                            </div>
                            <div class="col-md-6">
                                <asp:Button class="btn btn-primary" ID="Button3" runat="server" Text="Recieve Book" OnClick="Button3_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Issued Book List</h3>
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
                                <table class="table table-striped">
                                    <tr>
                                        <th>Member ID</th>
                                        <th>Member Name</th>
                                        <th>Book ID</th>
                                        <th>Book Name</th>
                                        <th>Issue Date</th>
                                        <th>Due Date</th>
                                        <th>Recieve Book Action</th>
                                    </tr>

                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("member_id") %></td>
                                                <td><%# Eval("member_name") %></td>
                                                <td><%# Eval("book_id") %></td>
                                                <td><%# Eval("book_name") %></td>
                                                <td><%# Eval("issue_date") %></td>
                                                <td><%# Eval("due_date") %></td>
                                                <td >
                                                    <asp:LinkButton ID="LinkButton1" class="btn btn-danger" runat="server" OnClick="LinkButton1_Click">Delete</asp:LinkButton>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("book_id") %>' Visible="false"></asp:Label>
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("member_id") %>' Visible="false"></asp:Label>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    </div>
</asp:Content>
