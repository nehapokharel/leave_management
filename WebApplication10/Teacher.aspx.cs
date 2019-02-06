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
    public partial class Teacher : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QIVKNCP;Initial Catalog=leave_management;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("select * from leave", con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                Response.Write("<script>alert('No pending leave approval reamining')</script>");
            }
            else
            {
                lbllid.Text = dt.Rows[0].ItemArray[0].ToString();
                lblsname.Text = dt.Rows[0].ItemArray[1].ToString();
                lbldays.Text = dt.Rows[0].ItemArray[2].ToString();
                lblsdate.Text = dt.Rows[0].ItemArray[3].ToString();
                lbledate.Text = dt.Rows[0].ItemArray[4].ToString();
                lblreason.Text = dt.Rows[0].ItemArray[5].ToString();
            }
        }


        protected void lbAccept_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlCommand com1 = new SqlCommand("select * from leave", con);
            SqlDataAdapter sda = new SqlDataAdapter(com1);
            sda.Fill(dt);
            SqlCommand com = new SqlCommand();
            com.CommandText = "insert into Acceptance(Leave_id,Student_name,Accepted_by,approvaldays,result) values (@lid,@sname,@accby,@appdays,@result)";
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@lid", Convert.ToInt32(dt.Rows[0].ItemArray[0]));
            com.Parameters.AddWithValue("@sname", dt.Rows[0].ItemArray[1].ToString());
            com.Parameters.AddWithValue("@accby", "hari");
            com.Parameters.AddWithValue("@appdays", "2");
            com.Parameters.AddWithValue("@result", "accepted");
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


            SqlCommand com2 = new SqlCommand("delete from leave where leave_id='" + Convert.ToInt32(dt.Rows[0].ItemArray[0]) + "'", con);
            com2.Connection = con;
            con.Open();
            com2.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Teacher.aspx");



        }
        protected void lbDecline_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand com1 = new SqlCommand("select * from leave", con);
            SqlDataAdapter sda = new SqlDataAdapter(com1);
            sda.Fill(dt);
            SqlCommand com = new SqlCommand();
            com.CommandText = "insert into Acceptance(Leave_id,Student_name,Accepted_by,approvaldays,result) values (@lid,@sname,@accby,@appdays,@result)";
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@lid", Convert.ToInt32(dt.Rows[0].ItemArray[0]));
            com.Parameters.AddWithValue("@sname", dt.Rows[0].ItemArray[1].ToString());
            com.Parameters.AddWithValue("@accby", "hari");
            com.Parameters.AddWithValue("@appdays", "2");
            com.Parameters.AddWithValue("@result", "rejected");
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            SqlCommand com2 = new SqlCommand("delete from leave where leave_id='" + Convert.ToInt32(dt.Rows[0].ItemArray[0]) + "'", con);
            com2.Connection = con;
            con.Open();
            com2.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Teacher.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}