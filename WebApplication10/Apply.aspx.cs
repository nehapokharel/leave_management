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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
           
            

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIVKNCP;Initial Catalog=leave_management;Integrated Security=True");

            SqlCommand com = new SqlCommand();
            com.CommandText = "insert into leave(student_name,noofdays,start_date,end_date,reason) values (@sname,@days,@sdate,@edate,@reason)";
            //com.CommandText = "insert into backup_leave(student_name,noofdays,start_date,end_date,reason) values (@sname,@days,@sdate,@edate,@reason)";
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@sname", sname.Text);
            com.Parameters.AddWithValue("@days", Convert.ToInt32(days.Text));
            com.Parameters.AddWithValue("@sdate", startdate.Text);
            com.Parameters.AddWithValue("@edate", enddate.Text);
            com.Parameters.AddWithValue("@reason", reason.Text);
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}