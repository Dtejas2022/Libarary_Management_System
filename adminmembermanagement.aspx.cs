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
	public partial class adminmembermanagement : System.Web.UI.Page
	{
		String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			ShowMemberDetails();

        }

		//go button
        protected void Button1_Click(object sender, EventArgs e)
        {
			if (!MemberIfExists())
			{
                Response.Write("<script>alert('Invalid member Id')</script>");
            }
			else
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
                    TextBox2.Text = dt.Rows[0][0].ToString();
                    TextBox3.Text = dt.Rows[0][10].ToString();
                    TextBox4.Text = dt.Rows[0][1].ToString();
                    TextBox5.Text = dt.Rows[0][2].ToString();
                    TextBox6.Text = dt.Rows[0][3].ToString();
                    TextBox7.Text = dt.Rows[0][4].ToString();
                    TextBox8.Text = dt.Rows[0][5].ToString();
                    TextBox9.Text = dt.Rows[0][6].ToString();
                    TextBox10.Text = dt.Rows[0][7].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Member ID');</script>");
                }
            }
        }


		//userdifined functions

		//find member exists or not
		bool MemberIfExists()
		{
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
                    return true;
                }
                else
                {
                    return false;
                }
            }
			catch(Exception ex)
			{
				Response.Write("<script>alert('"+ex.Message+"')</script>");
				return false;
			}
		}

		//show member details in table
		void ShowMemberDetails()
		{
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Repeater1.DataSource = ds;
                    Repeater1.DataBind();
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

		}

        //delete button
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MemberIfExists())
                {
                    DeleteMemberById();
                }
                else
                {
                    Response.Write("<script>alert('Member not exists');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }

        void DeleteMemberById()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("DELETE FROM member_master_tbl WHERE member_id = @member_id", con);
                cmd.Parameters.AddWithValue("@member_id", TextBox1.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowMemberDetails();
                Response.Write("<script>alert('Member deleted Succesfully');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }

        //search bar
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl WHERE member_id = @member_id OR contact_no = @contact_no", con);
                cmd.Parameters.AddWithValue("@member_id", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox11.Text.Trim());

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
                    Response.Write("<script>alert('Member not exists')</script>");
                    TextBox11.Text = "";
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        //active button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            UpdateMemberStatus("Active");
        }
        //Pending button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            UpdateMemberStatus("Pending");
        }
        //deactivate button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            UpdateMemberStatus("Deactive");
        }

        //update member status
        void UpdateMemberStatus(string status)
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("UPDATE member_master_tbl SET account_status = @account_status WHERE member_id = @member_id", con);
            cmd.Parameters.AddWithValue("@member_id", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@account_status", status);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowMemberDetails();
            TextBox3.Text = status;
            
        }
    }
}