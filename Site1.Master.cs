using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
	public partial class Site1 : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            try
            {
                if (Session["role"] == null || Session["role"].ToString().Trim() == "")
                {
                    LinkButton2.Visible = true; //user login
                    LinkButton3.Visible = true; //signup link

                    LinkButton4.Visible = false; //logout
                    LinkButton5.Visible = false; //hello user

                    LinkButton6.Visible = true; //admin login
                    LinkButton7.Visible = false; //auther management
                    LinkButton8.Visible = false; //publisher managment
                    LinkButton9.Visible = false; //book inventry
                    LinkButton10.Visible = false; //book issuence
                    LinkButton11.Visible = false; //member management
                }
                else if(Session["role"].Equals("user"))
                {
                    LinkButton2.Visible = false; //user login
                    LinkButton3.Visible = false; //signup link

                    LinkButton4.Visible = true; //logout
                    LinkButton5.Visible = true; //hello user
                    LinkButton5.Text = "Hello" + Session["username"].ToString();

                    LinkButton6.Visible = false; //admin login
                    LinkButton7.Visible = false; //auther management
                    LinkButton8.Visible = false; //publisher managment
                    LinkButton9.Visible = false; //book inventry
                    LinkButton10.Visible = false; //book issuence
                    LinkButton11.Visible = false; //member management
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton2.Visible = false; //user login
                    LinkButton3.Visible = false; //signup link

                    LinkButton4.Visible = true; //logout
                    LinkButton5.Visible = true; //hello user
                    LinkButton5.Text = "Hello admin";

                    LinkButton6.Visible = false; //admin login
                    LinkButton7.Visible = true; //auther management
                    LinkButton8.Visible = true; //publisher managment
                    LinkButton9.Visible = true; //book inventry
                    LinkButton10.Visible = true; //book issuence
                    LinkButton11.Visible = true; //member management
                }
            }
            catch(Exception ex)
            {

            }
            
		}

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
			Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventorypage.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissueing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] ="";
            Session["role"] = "";
            Session["status"] = "";


            LinkButton2.Visible = true; //user login
            LinkButton3.Visible = true; //signup link

            LinkButton4.Visible = false; //logout
            LinkButton5.Visible = false; //hello user

            LinkButton6.Visible = true; //admin login
            LinkButton7.Visible = false; //auther management
            LinkButton8.Visible = false; //publisher managment
            LinkButton9.Visible = false; //book inventry
            LinkButton10.Visible = false; //book issuence
            LinkButton11.Visible = false; //member management

            Response.Redirect("HomePage.aspx");
        }
    }
}