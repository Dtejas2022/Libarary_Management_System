<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="ElibraryManagement.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .w-100 {
            width: 988px;
            height: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-fluid py-5">
        <div class="row justify-content-center">
            <div class="col-md-10 text-center">
                <img src="imgs/lms_banner.jpg" class="img-fluid mb-4 rounded shadow" alt="Library Management Banner" />
                <h2 class="mb-3">About Our Library Management System</h2>
                <p class="lead">
                    Welcome to our Library Management System — a robust and efficient platform designed to manage library resources and streamline book lending operations. Developed using ASP.NET Web Forms, SQL Server, HTML, CSS, and Bootstrap, this system ensures a secure, user-friendly experience for both administrators and readers.
                </p>
                <p>
                    Our system supports two types of users:
                </p>
                <ul class="list-unstyled text-start d-inline-block">
                    <li><i class="bi bi-person-check"></i> <strong>Admin:</strong> Can add books, authors, publishers, and issue books to users.</li>
                    <li><i class="bi bi-person"></i> <strong>Normal Users:</strong> Can view available books in the library.</li>
                </ul>
                <p>
                    With role-based access control and a modern interface, this platform helps libraries manage their collection efficiently while offering a seamless experience to users.
                </p>
                <p class="mt-4">
                    Thank you for using our system. We’re committed to continuous improvement and welcome your feedback!
                </p>
            </div>
        </div>
    </section>
</asp:Content>

