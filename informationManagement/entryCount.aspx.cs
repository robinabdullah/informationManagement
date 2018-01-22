using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class entryCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_name"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                if (Session["user_name"].ToString() == "Robin" || Session["user_name"].ToString() == "alamin")
                {

                    String insert = "select newLogin.name,count(Created_By) AS Entry from information, newLogin where Created_By=newLogin.Id group by newLogin.name";

                    SqlConnection conn = new SqlConnection(Information.connectionstring);
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    count.DataSource = cmd.ExecuteReader();
                    count.DataBind();
                }
                else
                {
                    Response.Redirect("informationPage.aspx");
                }
            }
        }

    }
}