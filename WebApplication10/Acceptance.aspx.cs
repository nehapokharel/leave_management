using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication10
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_acceptance_Click(object sender, EventArgs e)
        {
            string sname = Session["student_name"].ToString();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIVKNCP;Initial Catalog=leave_management;Integrated Security=True");
           
            SqlCommand com = new SqlCommand("select * from Acceptance where student_name ='" + sname + "'", con);
           
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);
            int n = dt.Rows.Count;
            if (dt.Rows.Count == 0)
            {
                Response.Write("<script>alert('You havenot asked for leave yet!!!')</script>");
            }
            else
            {
                lblresult.Text = sname +  " your leave application is " + dt.Rows[n-1].ItemArray[4].ToString();
                btn_acceptance.Visible = false;
            }
            
        }
    }
}