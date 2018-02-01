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
                if (Session["role"].ToString() == "admin")
                {

                    String insert = "select newLogin.name,count(Created_By) AS Entry from information, newLogin where Created_By=newLogin.Id group by rollup(newLogin.name)";

                    SqlConnection conn = new SqlConnection(Information.connectionstring);
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    count.DataSource = cmd.ExecuteReader();
                    count.DataBind();
                    conn.Close();

                    insert = "select class,count(Id) AS Entry from information group by rollup(class)";

                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    classWiseCount.DataSource = cmd.ExecuteReader();
                    classWiseCount.DataBind();
                    conn.Close();

                    insert = "select Title,count(Title) as EntryCount from Information group by rollup(Title)";
                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    titleWiseCount.DataSource = cmd.ExecuteReader();
                    titleWiseCount.DataBind();
                    conn.Close();

                    insert = "select Shift,count(Shift) as EntryCount from Information group by rollup(Shift)";
                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    titleWiseCount.DataSource = cmd.ExecuteReader();
                    titleWiseCount.DataBind();

                    conn.Close();
                    SqlConnection.ClearPool(conn);
                }
                else
                {
                    Response.Redirect("informationPage.aspx");
                }
            }
        }

    }
}