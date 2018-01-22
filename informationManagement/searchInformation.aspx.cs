using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class searchInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
                username.Text = Session["user_name"].ToString();
        }

        protected void searchButton1_Click(object sender, EventArgs e)
        {
            msg.Text = " ";
            list.DataSource = null;
          list.DataBind();
            String search;
            String connstring = @"server=DESKTOP-JAP561I\SQLEXPRESS;database=attendenceManagement;integrated security=true";


            if(clas.SelectedIndex != 0 && shift.SelectedIndex != 0)
            {
                 search = String.Format("select * from Information where Class='{0}' and Shift='{1}'", clas.SelectedItem.Text, shift.SelectedItem.Text);
                
            }
           else if (clas.SelectedIndex != 0)
            {
                 search = String.Format("select * from Information where Class='{0}'", clas.SelectedItem.Text);
                
            }
          
            else if(shift.SelectedIndex != 0)
            {
                 search = String.Format("select * from Information where Shift='{0}'", shift.SelectedItem.Text);
               
            }

           
            else
            {
                 search = "select * from Information ";
               
            }

            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(search, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                msg.Text = "Not found";
            }
            else
            {
                list.DataSource = reader;
                list.DataBind();
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            //Session["user_name"] = null;
            Session.Clear();
            Response.Redirect("LoginPage.aspx");
        }
    }
}