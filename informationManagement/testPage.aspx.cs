using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace informationManagement
{
    public partial class testPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///tenary operator
            ///

            if (Request.QueryString["SampleQuerySting"] != null)
            {
                Response.Write(Request.QueryString["SampleQuerySting"]);
            }
            else
            {
                Response.Write("no data found in SampleQuerySting");

            }
        }
    }
}