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
                    ///per user count
                    String insert = "select newLogin.name,count(Created_By) AS Entry from information, newLogin where Created_By=newLogin.Id and Is_Deleted = 0 group by rollup(newLogin.name)";

                    SqlConnection conn = new SqlConnection(Information.connectionstring);
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    count.DataSource = cmd.ExecuteReader();
                    count.DataBind();
                    conn.Close();

                    ///per Class Count
                    insert = "select class,count(Id) AS Entry from information where Is_Deleted = 0 group by rollup(class)";

                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    classWiseCount.DataSource = cmd.ExecuteReader();
                    classWiseCount.DataBind();
                    conn.Close();

                    ///per title
                    insert = "select Title,count(Title) as EntryCount from Information where Is_Deleted = 0 group by rollup(Title)";
                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    titleWiseCount.DataSource = cmd.ExecuteReader();
                    titleWiseCount.DataBind();
                    conn.Close();

                    ///per shift count
                    insert = "select Shift,count(Shift) as EntryCount from Information where Is_Deleted = 0 group by rollup(Shift)";
                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    shiftWiseCount.DataSource = cmd.ExecuteReader();
                    shiftWiseCount.DataBind();
                    conn.Close();

                    ///per blood group count
                    insert = "select Blood_Group,count(Blood_Group) as EntryCount from Information where Is_Deleted = 0 group by rollup(Blood_Group)";
                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    bloodGroupCount.DataSource = cmd.ExecuteReader();
                    bloodGroupCount.DataBind();
                    conn.Close();

                    ///per blood report summary
                    insert = "SELECT top 1"
                    + "(SELECT COUNT(id) FROM information WHERE blood_group != 'N/A' and Blood_Group_Checked = 0) as 'Outside',"
                    + "(SELECT COUNT(id) FROM information WHERE blood_group != 'N/A' and Blood_Group_Checked = 1) as 'In School',"
                    + "(SELECT COUNT(id) FROM information WHERE blood_group != 'N/A' ) as 'Total Tested',"
                    + "(SELECT COUNT(id) FROM information WHERE blood_group = 'N/A' ) as 'Not Tested',"
                    + "(SELECT COUNT(id) FROM information WHERE blood_group != 'N/A' and Blood_Group_Checked = 1 and is_paid=1) as 'Paid',"
                    + "(SELECT COUNT(id) FROM information WHERE blood_group != 'N/A' and Blood_Group_Checked = 1 and is_paid=0) as 'Due'"
                    + "FROM information where  Is_Deleted = 0; ";
                    conn = new SqlConnection(Information.connectionstring);
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();

                    bloodGroupSummary.DataSource = cmd.ExecuteReader();
                    bloodGroupSummary.DataBind();
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