using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;

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
            string sname = txtfname.Text;
            string sid = txtid.Text;
            string pspw = txtpassword.Text;



            Response.Redirect("Apply.aspx");
        }
    }
}