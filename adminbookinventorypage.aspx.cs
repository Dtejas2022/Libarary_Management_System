using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
	public partial class adminbookinventorypage : System.Web.UI.Page
	{
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                Add_publisger_Auther_Names();
                DisplayBooks();
            }

        }
		// go button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckifBookExists())
            {
                Gobutton();
            }
            else
            {
                Response.Write("<script>alert('Invalid Book Id');</script>");
            }
        }

        //add button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckifBookExists())
                {
                    Response.Write("<script>alert('Book with this ID or Name alredy exists');</script>");
                }
                else
                {
                    Add_new_book();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        //update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckifBookExists())
            {
                UpdateExistingBook();
            }
            else
            {
                Response.Write("<script>alert('Invalid book Id ');</script>");
            }
        }

        //delete button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (CheckifBookExists())
            {
                DeleteExistingBook();
            }
            else
            {
                Response.Write("<script>alert('Invalid Book ID');</script>");
            }

        }

        //-----------------user defined functions-------

        //add database values to dropdown
        void Add_publisger_Auther_Names()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT author_name FROM author_master_tbl", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                DropDownList3.DataSource = dt;
                DropDownList3.DataValueField = "author_name";
                DropDownList3.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT publisher_name FROM publisher_master_table", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "publisher_name";
                DropDownList2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        //check if book alredy exists
        bool CheckifBookExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM book_master_tbl WHERE book_id = @book_id OR book_name = @book_name", con);

                cmd.Parameters.AddWithValue("@book_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@book_name", TextBox2.Text.Trim());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        //add new book
        void Add_new_book()
        {
            try
            {
                string filepath = "~/book_inventory/books.png"; // default path
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);

                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/book_inventory/" + filename));
                    filepath = "~/book_inventory/" + filename; // update filepath if uploaded
                }

                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO book_master_tbl (book_id, book_name, genre, auther_name, publisher_name, publish_date, language, edition, book_cost, no_of_pages, book_description, actual_stock, current_stock, book_img_link)" +
                    "VALUES(@book_id, @book_name, @genre, @auther_name, @publisher_name, @publish_date, @language, @edition, @book_cost, @no_of_pages, @book_description, @actual_stock, @current_stock, @book_img_link)", con);

                cmd.Parameters.AddWithValue("@book_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@book_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@genre", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@auther_name", DropDownList3.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@publisher_name", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@publish_date", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@language", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@edition", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@book_cost", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@no_of_pages", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@book_description", TextBox14.Text.Trim());
                cmd.Parameters.AddWithValue("@actual_stock", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@current_stock", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@book_img_link", filepath);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayBooks();
                Response.Write("<script>alert('Book Added Successfully');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox6.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextBox14.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        //update existing book
        void UpdateExistingBook()
        {
            try
            {
                string filepath = "~/book_inventory/books.png"; // default path
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);

                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/book_inventory/" + filename));
                    filepath = "~/book_inventory/" + filename; // update filepath if uploaded
                }

                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("UPDATE book_master_tbl SET book_name = @book_name, genre = @genre, auther_name=@auther_name, publisher_name = @publisher_name, publish_date = @publish_date, language = @language, edition = @edition, book_cost = @book_cost, no_of_pages = @no_of_pages, book_description = @book_description, actual_stock = @actual_stock, current_stock = @current_stock, book_img_link = @book_img_link WHERE book_id = @book_id", con);

                cmd.Parameters.AddWithValue("@book_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@book_name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@genre", TextBox6.Text);
                cmd.Parameters.AddWithValue("@auther_name", DropDownList3.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@publisher_name", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@publish_date", TextBox8.Text);
                cmd.Parameters.AddWithValue("@language", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@edition", TextBox3.Text);
                cmd.Parameters.AddWithValue("@book_cost", TextBox9.Text);
                cmd.Parameters.AddWithValue("@no_of_pages", TextBox10.Text);
                cmd.Parameters.AddWithValue("@book_description", TextBox14.Text);
                cmd.Parameters.AddWithValue("@actual_stock", TextBox11.Text);
                cmd.Parameters.AddWithValue("@current_stock", TextBox12.Text);
                cmd.Parameters.AddWithValue("@book_img_link", filepath);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayBooks();
                Response.Write("<script>alert('Book updated Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox6.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextBox14.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        //delete existing book
        void DeleteExistingBook()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("DELETE FROM book_master_tbl WHERE book_id = @book_id", con);

                cmd.Parameters.AddWithValue("@book_id", TextBox1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Book Deleted Succesfully');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                DisplayBooks();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            

        }

        //Display books in table format
        void DisplayBooks()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM book_master_tbl", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Repeater1.DataSource = ds;
                    Repeater1.DataBind();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        //go button logic
        void Gobutton()
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM book_master_tbl WHERE book_id = @book_id", con);

            cmd.Parameters.AddWithValue("@book_id", TextBox1.Text.Trim());

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TextBox2.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                Response.Write("<script>alert('Invalid book Id ');</script>");
            }
                con.Close();
        }

        //search button
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM book_master_tbl WHERE book_id = @book_id OR book_name = @book_name", con);

                cmd.Parameters.AddWithValue("@book_id", TextBox4.Text);
                cmd.Parameters.AddWithValue("@book_name", TextBox4.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Repeater1.DataSource = ds;
                    Repeater1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('No Record Found');</script>");
                    TextBox4.Text = "";
                    DisplayBooks();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}