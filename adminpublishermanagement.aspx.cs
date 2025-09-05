using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ElibraryManagement
{
	public partial class adminpublishermanagement : System.Web.UI.Page
	{
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
            showpublishers();
        }
        //go button
        protected void Button1_Click(object sender, EventArgs e)
        {
            gobutton();
        }
        //add button
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIfPublisherExists())
                {
                    Response.Write("<script>alert('publisher with this id exists');</script>");
                }
                else
                {
                    addNewPublisher();

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
            if (CheckIfPublisherExists())
            {
                updatePublisher();

            }
            else
            {
                Response.Write("<script>alert('publisher with this id not exists');</script>");
            }

        }
        //delete button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (CheckIfPublisherExists())
            {
                deletePublisher();

            }
            else
            {
                Response.Write("<script>alert('publisher with this id not exists');</script>");
            }
        }

        //userdefined functions
        bool CheckIfPublisherExists()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM publisher_master_table WHERE publisher_id = @publisher_id", con);
                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());

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

        void addNewPublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO publisher_master_table (publisher_id, publisher_name) " +
                    "VALUES(@publisher_id, @publisher_name)", con);
                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                showpublishers();
                Response.Write("<script>alert('publisher Added Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void showpublishers()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM publisher_master_table", con);

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

        void updatePublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("UPDATE publisher_master_table set publisher_name = @publisher_name where publisher_id = @publisher_id", con);
                cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                showpublishers();
                Response.Write("<script>alert('publisher updated Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deletePublisher()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("delete from publisher_master_table where publisher_id=@publisher_id", con);

                cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                showpublishers();
                Response.Write("<script>alert('publisher deleted Succesfully');</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void gobutton()
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM publisher_master_table WHERE publisher_id = @publisher_id", con);

            cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
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
                Response.Write("<script>alert('Invalid publisher Id');</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM publisher_master_table WHERE publisher_id = @publisher_id OR publisher_name = @publisher_name", con);
                cmd.Parameters.AddWithValue("@publisher_id", txtsearch.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher_name", txtsearch.Text.Trim());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
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
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}