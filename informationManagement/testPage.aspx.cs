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
            string clasify = "";
            int value = -5;

            if(value > 0)
            {
                clasify = "positive value";
            }
            else
            {
                clasify = "negative value";
            }

            clasify = (value > 0) ? "positive value" : "negative value";
            Response.Write(clasify);
        }
    }
}