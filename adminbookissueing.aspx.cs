using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
	public partial class adminbookissueing : System.Web.UI.Page
	{
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                Display_issued_books();
            }
            
        }
		//go button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            go_clicked();
        }

        //issue Book click
        protected void Button2_Click(object sender, EventArgs e)
        {
            issue_book();
        }

        //Recieve book click
        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        //Delete button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("DELETE FROM book_issue_tbl WHERE book_id=@book_id AND member_id = @member_id", con);
            string book_id = (((sender as LinkButton).NamingContainer.FindControl("Label1") as Label).Text);
            string member_id = (((sender as LinkButton).NamingContainer.FindControl("Label2") as Label).Text);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("member_id", member_id);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Display_issued_books();
        }

        //-----------------------User Defined Functions-----------------------

        //go button logic
        void go_clicked()
        {
            //finding Full Name of member using member id
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl WHERE member_id = @member_id", con);
                cmd.Parameters.AddWithValue("@member_id", TextBox1.Text.Trim());
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    TextBox3.Text = dt.Rows[0][0].ToString();
                    con.Close();
                }
                else
                {
                    Response.Write("<script>alert('Member not exists')</script>");
                    TextBox1.Text = "";
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

            try
            {
                //finding Book name using Book id
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM book_master_tbl WHERE book_id = @book_id", con);
                cmd.Parameters.AddWithValue("@book_id", TextBox2.Text.Trim());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    TextBox4.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Book not exists')</script>");
                    TextBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }

        //issue book logic
        void issue_book()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO book_issue_tbl (member_id, member_name, book_id, book_name, issue_date, due_date)" +
                    "VALUES(@member_id, @member_name, @book_id, @book_name, @issue_date, @due_date)", con);
                
                cmd.Parameters.AddWithValue("@member_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@member_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@book_id", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@book_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@issue_date", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@due_date", TextBox6.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display_issued_books();

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        //display issued books
        void Display_issued_books()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM book_issue_tbl", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Repeater1.DataSource = ds;
                    Repeater1.DataBind();                   
                }
                
              
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        //return Book Logic
        //void book_return()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script>alert('" + ex.Message + "')</script>");
        //    }
        //}
    }
}