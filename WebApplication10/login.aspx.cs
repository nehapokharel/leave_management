﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtteacher_Click(object sender, EventArgs e)
        {
            
        }

        protected void txtstudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("Apply.aspx");
        }
    }
}