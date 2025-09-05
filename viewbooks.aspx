<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewbooks.aspx.cs" Inherits="ElibraryManagement.viewbooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="col-lg-12">
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

</asp:Content>
