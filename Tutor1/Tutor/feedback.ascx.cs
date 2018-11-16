using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Tutor_feedback : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbconnect db1 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select dept_id from tbl_dept";
            SqlDataReader dr1 = db1.executeread(cmd1);
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1.GetString(0));
            }

            
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db2 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "select crs_name,branch_id from tbl_course where dept_id=@id";
        cmd2.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db2.executeread(cmd2);
        dr1.Read();
        TextBox1.Text = dr1.GetString(0);
        TextBox2.Text = dr1.GetString(1);
    }
   protected void Button1_Click(object sender, EventArgs e)
    {
      
        int q = 1;
       dbconnect db3 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "insert into stud_feedback values(@code,@dept,@course,@stream,@sem,@sub,@teacher,@month,@year)";
        cmd4.Parameters.AddWithValue("@code", TextBox7.Text);
        cmd4.Parameters.AddWithValue("@dept", DropDownList1.SelectedValue);
        cmd4.Parameters.AddWithValue("@course", TextBox1.Text);
        cmd4.Parameters.AddWithValue("@stream", TextBox2.Text);
        cmd4.Parameters.AddWithValue("@sem", DropDownList2.SelectedValue);
        cmd4.Parameters.AddWithValue("sub", DropDownList3.SelectedValue);
        cmd4.Parameters.AddWithValue("@teacher", TextBox3.Text);
        cmd4.Parameters.AddWithValue("@month", TextBox4.Text);
        cmd4.Parameters.AddWithValue("@year", TextBox5.Text);

        db3.execute(cmd4);
        SqlCommand cmd3 = new SqlCommand();
        while (q <= 18)
        {
            cmd3.CommandText = "insert into tbl_feedback values(@code,@no,@op1,@op2,@op3,@op4,@op5,@op6)";
            cmd3.Parameters.AddWithValue("@code", TextBox7.Text);
            cmd3.Parameters.AddWithValue("@no", q);
            cmd3.Parameters.AddWithValue("@op1", 0);
            cmd3.Parameters.AddWithValue("@op2", 0);
            cmd3.Parameters.AddWithValue("@op3", 0);
            cmd3.Parameters.AddWithValue("@op4", 0);
            cmd3.Parameters.AddWithValue("@op5", 0);
            cmd3.Parameters.AddWithValue("@op6", 0);
            q++;
            db3.execute(cmd3);
            cmd3.Parameters.Clear();
        }

        Response.Redirect("question.aspx");


        
        Button3.Visible = true;
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db4 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select sub_code from tbl_sem where subject=@s";
        cmd4.Parameters.AddWithValue("@s", DropDownList3.SelectedValue);
        SqlDataReader dr4 = db4.executeread(cmd4);
        dr4.Read();
        TextBox7.Text = dr4.GetString(0);

        dbconnect db3 = new dbconnect();
        SqlCommand cmd3 = new SqlCommand();
        cmd3.CommandText = "select teacher from tbl_sem where subject=@id";
        cmd3.Parameters.AddWithValue("@id", DropDownList3.SelectedValue);
        SqlDataReader dr1 = db3.executeread(cmd3);
        dr1.Read();
        TextBox3.Text = dr1.GetString(0);


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        dbconnect db3 = new dbconnect();
        SqlCommand cmd3 = new SqlCommand();
        cmd3.CommandText = "delete from tbl_feedback";
       
        db3.execute(cmd3);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["subject"] = DropDownList3.SelectedValue;
        Session["teacher"] = TextBox3.Text;
        Session["month"] = TextBox4.Text;
        Session["year"] = TextBox5.Text;
        Session["code"] = TextBox7.Text;
        
        Response.Redirect("question.aspx");
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
}