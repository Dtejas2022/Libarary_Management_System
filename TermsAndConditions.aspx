<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TermsAndConditions.aspx.cs" Inherits="ElibraryManagement.TermsAndConditions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container py-5">
        <div class="row justify-content-center">
            <div class="col-md-10">
                <h2 class="text-center mb-4">Terms and Conditions</h2>
                <p>
                    These Terms and Conditions govern your use of the Library Management System. By accessing or using this platform, you agree to comply with and be bound by the following terms. Please read them carefully.
                </p>

                <h5>1. User Accounts</h5>
                <p>
                    Users are responsible for maintaining the confidentiality of their login credentials. Any activity under your account is your responsibility.
                </p>

                <h5>2. User Roles</h5>
                <p>
                    - <strong>Admin:</strong> Authorized to manage books, publishers, authors, and issue books to users.<br />
                    - <strong>Normal User:</strong> Allowed to view available books only and not permitted to access admin-level features.
                </p>

                <h5>3. Book Issuing</h5>
                <p>
                    Books issued by the admin must be returned within the specified timeframe. Late returns may result in penalties, as per library policy.
                </p>

                <h5>4. Data Usage</h5>
                <p>
                    All data stored in the system, including user information and book records, will be used solely for library management purposes.
                </p>

                <h5>5. Restrictions</h5>
                <p>
                    Unauthorized access to admin features or attempting to modify database content without permission is strictly prohibited.
                </p>

                <h5>6. Modifications</h5>
                <p>
                    The library reserves the right to update or change these terms at any time. Continued use of the system after changes indicates acceptance of the new terms.
                </p>

                <h5>7. Contact</h5>
                <p>
                    For questions regarding these Terms and Conditions, please contact the library administration.
                </p>

                <p class="text-center mt-5">
                    <strong>Thank you for using our Library Management System.</strong>
                </p>
            </div>
        </div>
    </section>
</asp:Content>

