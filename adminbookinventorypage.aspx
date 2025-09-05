<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbookinventorypage.aspx.cs" Inherits="ElibraryManagement.adminbookinventorypage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Book Details</h3>
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
                            <div class="col">
                                <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                            </div>
                        </div>


                        <div class="row">
                            <div class="col-md-4">
                                <label>Book ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" placeholder="Book ID" ID="TextBox1" runat="server"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-8">
                                <label>Book Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Book Name" ID="TextBox2" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col-md-4">
                                <label>Select Language</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                        <asp:ListItem Text="English" Value="English" runat="server" />
                                        <asp:ListItem Text="Hindi" Value="Hindi" runat="server" />
                                        <asp:ListItem Text="Marathi" Value="Marathi" runat="server" />
                                        <asp:ListItem Text="French" Value="French" runat="server" />
                                        <asp:ListItem Text="German" Value="German" runat="server" />
                                        <asp:ListItem Text="Urdu" Value="Urdu" runat="server" />
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Select Auther Name</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                                        <asp:ListItem Text="auther 1" Value="auther 1"></asp:ListItem>
                                        <asp:ListItem Text="auther 2" Value="auther 2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Genre</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Genre of Book" ID="TextBox6" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Select Publisher Name</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                                        <asp:ListItem Text="publisher 1" Value="publisher 1"></asp:ListItem>
                                        <asp:ListItem Text="publisher 2" Value="publisher 2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Publish Date</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="publish date" ID="TextBox8" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Edition</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="edition" ID="TextBox3" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Book Cost(per Unit)</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="book cost" ID="TextBox9" runat="server" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Pages</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="pages" ID="TextBox10" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Actual Stock</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="actual stock" ID="TextBox11" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Current Stock</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="current stock" ID="TextBox12" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Issued Books</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="issued books" ID="TextBox13" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Book Description</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Book Description" ID="TextBox14" runat="server" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button class="btn btn-success btn-lg px-4" ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
                            </div>

                            <div class="col-md-4">
                                <asp:Button class="btn btn-primary btn-lg px-4" ID="Button3" runat="server" Text="update" OnClick="Button3_Click" />
                            </div>

                            <div class="col-md-4">
                                <asp:Button class="btn btn-danger btn-lg px-4" ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>


            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Book Inventory List</h3>
                                </center>
                                <asp:TextBox ID="TextBox4" runat="server" placeholder="By Book Id or Book Name"></asp:TextBox><asp:Button ID="Button5" runat="server" Text="Search" OnClick="Button5_Click" />
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
                                        <th>Book ID</th>
                                        <th>Book Name</th>
                                        <th>Genre</th>
                                        <th>Publisher Name</th>
                                        <th>Author Name</th>
                                        <th>Language</th>
                                        <th>Book Cost</th>
                                    </tr>
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("book_id") %></td>
                                                <td><%# Eval("book_name") %></td>
                                                <td><%# Eval("genre") %></td>
                                                <td><%# Eval("publisher_name") %></td>
                                                <td><%# Eval("auther_name") %></td>
                                                <td><%# Eval("language") %></td>
                                                <td><%# Eval("book_cost") %></td>
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

</asp:Content>
