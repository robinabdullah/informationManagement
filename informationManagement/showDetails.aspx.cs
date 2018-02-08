using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class showDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)//edit link
            {

                String select = "select Name,Class, Section, Department, Gender, Roll, Shift, Nationality from Information where Is_Deleted = 0 and Id=" + Request.QueryString["id"];
                SqlConnection conn = new SqlConnection(Information.connectionstring);
                SqlCommand cmd = new SqlCommand(select, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name.Text = reader["Name"].ToString();
                    clas.Text = reader["Class"].ToString();
                    if (clas.Text == "Class 9" || clas.Text == "Class 10")
                    {
                        departmentLabel.Visible = true;
                        department.Visible = true;
                        department.Text = reader["Department"].ToString();
                    }
                    else
                    {
                        department.Visible = false;
                        departmentLabel.Visible = false;
                    }
                    section.Text = reader["Section"].ToString();
                    // department.SelectedItem.Text = reader[3].ToString();
                    gender.Text = reader["Gender"].ToString();
                    roll.Text = reader["Roll"].ToString();
                    shift.Text = reader["Shift"].ToString();
                    national.Text = reader["Nationality"].ToString();

                }
                reader.Close();
                conn.Close();
                conn.Dispose();
               
                SqlConnection.ClearPool(conn);

            }
        }
    }
}