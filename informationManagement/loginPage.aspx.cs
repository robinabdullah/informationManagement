using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class loginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton1_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                msg.Text = "please enter valid name";
            }
           else if (password.Text == "")
            {
                msg.Text = "please enter valid password";
            }
            else {
              
                String search = String.Format("select Id, Name,Password,Role from newLogin where Name='{0}' and Password='{1}'", name.Text, password.Text);


                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(search, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String address = "informationPage.aspx";
                    Session["user_name"] = name.Text;
                    Session["user_id"] = reader["Id"].ToString();
                    Session["role"] = reader["Role"].ToString();
                    Response.Redirect(address);
                }
                if (reader.HasRows == false)
                {
                    msg.Text = "Login failed";
                }

                reader.Close();
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }

        }
    }
}