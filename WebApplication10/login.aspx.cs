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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void txtteacher_Click(object sender, EventArgs e)
        {
            string tname = txtfname.Text;
            string tid = txtid.Text;
            string tpw = txtpassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIVKNCP;Initial Catalog=leave_management;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("select * from Teacher_login where Teacher_id='" + tid + "'and Teacher_name='" + tname + "'and Password='" + tpw + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                Response.Redirect("Teacher.aspx");
            }
            else
            {
                Response.Write("<script>alert('invalid username or password')</script>");
            }
        }

        protected void txtstudent_Click(object sender, EventArgs e)
        {
            string sname = txtfname.Text;
            string sid = txtid.Text;
            string spw = txtpassword.Text;
            Session["student_name"] = txtfname.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIVKNCP;Initial Catalog=leave_management;Integrated Security=True");
                DataTable dt = new DataTable();
                SqlCommand com = new SqlCommand("select * from Student_login where student_id='" + sid + "'and student_name='"+sname+"'and password='"+spw+"'", con);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(dt);
            if (dt.Rows.Count!=0)
            {
                Response.Redirect("Apply.aspx");
            }
            else
            {
                Response.Write("<script>alert('invalid username or password')</script>");
            }
        }
    }
}