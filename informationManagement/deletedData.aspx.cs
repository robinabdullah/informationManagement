using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class deletedData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else if (Session["role"].ToString() == "guest")
            {
                Response.Redirect("informationPage.aspx");
            }
            else {

                username.Text = Session["user_name"].ToString();

               }
            SqlConnection conn;
            SqlCommand cmd;
            if (Request.QueryString["undodelete"] != null)
            {
                String update = String.Format("update Information set Is_Deleted = 0 where  Is_Deleted = 1 and Id=" + Request.QueryString["undodelete"]);
                 conn = new SqlConnection(Information.connectionstring);
                 cmd = new SqlCommand(update, conn);

                conn.Open();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    msg.Text = "successfully delete";
                }



            }
           
                String delete = "select ID, Name,Class, Section, Department, Gender, Roll, Shift, Nationality from Information where Is_Deleted = 1";

                 conn = new SqlConnection(Information.connectionstring);
                 cmd = new SqlCommand(delete, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                delet.DataSource = reader;
                delet.DataBind();

               if(reader.HasRows == false)
            {
                msg.Text = "No data found";
            }

                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);


        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LoginPage.aspx");

        }
    }
}