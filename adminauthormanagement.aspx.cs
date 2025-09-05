using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class adminauthormanagement : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            showauthors();
        }
        //add button
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfAutherExists())
                {
                    Response.Write("<script>alert('auther with this id exists');</script>");
                }
                else
                {
                    addNewAuther();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
        //update button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckIfAutherExists())
            {
                updateAuther();

            }
            else
            {
                Response.Write("<script>alert('auther with this id not exists');</script>");
            }

        }
        //delete button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (CheckIfAutherExists())
            {
                deleteAuther();

            }
            else
            {
                Response.Write("<script>alert('auther with this id not exists');</script>");
            }

        }
        //go button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            gobutton();
        }

        //USERDEFINED FUNCTIONS
        bool CheckIfAutherExists()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM author_master_tbl WHERE author_id = @author_id", con);
                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
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

        //Add Auther
        void addNewAuther()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO author_master_tbl (author_id, author_name) " +
                    "VALUES(@author_id, @author_name)", con);
                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                showauthors();
                Response.Write("<script>alert('Auther Added Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        //update auther
        void updateAuther()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("UPDATE author_master_tbl set author_name = @author_name where author_id = @author_id", con);
                cmd.Parameters.AddWithValue("@author_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                showauthors();
                Response.Write("<script>alert('Auther updated Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteAuther()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("delete from author_master_tbl where author_id=@author_id", con);

                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                showauthors();
                Response.Write("<script>alert('Auther deleted Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void showauthors()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM author_master_tbl", con);

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

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM author_master_tbl WHERE author_id = @author_id OR author_name = @author_name", con);
                cmd.Parameters.AddWithValue("@author_id", txtsearch.Text.Trim());
                cmd.Parameters.AddWithValue("@author_name", txtsearch.Text.Trim());

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
                    Response.Write("<script>alert('No records found');</script>");
                    txtsearch.Text = "";
                    showauthors();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void gobutton()
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM author_master_tbl WHERE author_id = @author_id", con);

            cmd.Parameters.AddWithValue("@author_id", TextBox1.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TextBox2.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                Response.Write("<script>alert('Invalid Auther Id');</script>");
            }
        }
    }
}