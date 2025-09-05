<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminmembermanagement.aspx.cs" Inherits="ElibraryManagement.adminmembermanagement" %>

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
                                    <h3>Member Details</h3>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/loginimage.png" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            
                            <div class="col-md-3">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" placeholder="Member ID" ID="TextBox1" runat="server"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Full Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Full Name" ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-5">
                                <label>Acount Status</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" placeholder="Pending" ID="TextBox3" runat="server"></asp:TextBox>
                                        <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i class="fa-solid fa-circle-check"></i></asp:LinkButton>
                                        <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"><i class="fa-solid fa-pause-circle"></i></asp:LinkButton>
                                        <asp:LinkButton class="btn btn-danger mr-1" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"><i class="fa-solid fa-times-circle"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>

                        </div>


                        <div class="row">
                            <div class="col-md-4">
                                <label>DOB</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="DOB" ID="TextBox4" runat="server" TextMode="Date" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Contact No</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Contact No" ID="TextBox5" runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Email ID" ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>State</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="State" ID="TextBox7" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="City" ID="TextBox8" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Pin Code</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Pin Code" ID="TextBox9" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Full Address" ID="TextBox10" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <asp:Button class="btn btn-danger" ID="Button2" runat="server" Text="Delete Member" OnClick="Button2_Click" />
                                </center>
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
                                    <h3>Member List</h3>
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
                                <asp:TextBox ID="TextBox11" placeholder="search by id or contact no" runat="server"></asp:TextBox><asp:Button ID="Button3" runat="server" Text="search" OnClick="Button3_Click" />
                                <table class="table tablel-responsive table-striped">
                                    <tr>
                                        <th>Full Name</th>
                                        <th>Email</th>
                                        <th>Contact</th>
                                        <th>Member ID</th>
                                        <th>Status</th>
                                    </tr>
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("full_name") %></td>
                                                <td><%# Eval("email") %></td>
                                                <td><%# Eval("contact_no") %></td>
                                                <td><%# Eval("member_id") %></td>
                                                <td><%# Eval("account_status") %></td>
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
