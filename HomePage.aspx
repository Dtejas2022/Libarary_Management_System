<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ElibraryManagement.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .w-100 {
            width: 988px;
            height: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <img src="imgs\lms_banner.jpg" class="img-fluid"/>
    </section>

    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                    <h2>Our Features</h2>
                    <p><b>Our 3 Primery Services</b></p>
                    </center>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <center>
                    <img width="150px" src="imgs\Old_Geodesy_library_books.jpg" />
                    <h4>Digital Books Inventory</h4>
                    <p class="text-justify">Our Digital Books Inventory allows administrators to efficiently manage the library’s collection of books. With real-time database integration, books can be added, updated, or removed seamlessly. Each entry stores essential information such as title, author, publisher, genre, and availability status.</p>
                    </center>
                </div>
            

           
                <div class="col-md-4">
                    <center>
                    <img width="150px" src="imgs\Old_Geodesy_library_books.jpg" />
                    <h4>Book Issuing System</h4>
                    <p class="text-justify">The Book Issuing module allows admins to issue books to users with just a few clicks. The system tracks issued dates and user details, providing complete transparency and easy monitoring of borrow and return history.</p>
                    </center>
                </div>
            

            
                <div class="col-md-4">
                    <center>
                    <img width="150px" src="imgs\Old_Geodesy_library_books.jpg" />
                    <h4>Role-Based Access Control</h4>
                    <p class="text-justify">With secure session-based role management, our system differentiates between Admins and Normal Users. Admins can manage library data, while users are restricted to viewing available books only—ensuring system security and control.</p>
                    </center>
                </div>
           </div>
        </div>
    </section>

    <section>
        <img class="img-fluid w-100"src="imgs\page2.jpg" />
    </section>


    <section>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <center>
                <h2>Our Process</h2>
                <p><b>we have simple 3 step process</b></p>
                </center>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <center>
                <img src="imgs\signUp.jpg" width="150px"/>
                <h4>Sign In</h4>
                <p class="text-justify">The Sign In feature allows both Admins and Normal Users to securely log in to the system. Using session-based authentication, the system identifies the user role and provides appropriate access. Admins are redirected to the admin dashboard, while normal users can explore available books. This ensures a personalized and secure experience for every user.</p>
                </center>
            </div>
        

       
            <div class="col-md-4">
                <center>
                <img src="imgs\search_b.jpg" width="150px"/>
                <h4>Search Books</h4>
                <p class="text-justify">The Search Books feature allows users to quickly find books available in the library by title, author, or publisher. This functionality provides real-time filtering and displays only relevant results, improving user experience and saving time. It ensures that both students and staff can easily locate books from the digital inventory.</p>
                </center>
            </div>
        

        
            <div class="col-md-4">
                <center>
                <img src="imgs\visiteUs.jpg" width="150px" />
                <h4>Visit Us</h4>
                <p class="text-justify"> We welcome all students and staff to visit our physical library for a more immersive reading experience. Explore a wide range of books, reference materials, and journals in person. Our staff is always available to assist with locating books, membership queries, and understanding how to use our Library Management System effectively.

                </p>
                </center>
            </div>
       </div>
    </div>
</section>
    
</asp:Content>
