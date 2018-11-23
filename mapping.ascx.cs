using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HOD_mapping : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String s = Convert.ToString(Session["us"]);
        dbconnect db21 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_account where account_id=@cid";
        cmd5.Parameters.AddWithValue("@cid", s);
        SqlDataReader dr11 = db21.executeread(cmd5);
        dr11.Read();
        TextBox5.Text = dr11.GetString(3);

        if (!IsPostBack)
        {
            dbconnect db1 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select branch_id from tbl_course";
            SqlDataReader dr1 = db1.executeread(cmd1);
            while (dr1.Read())
            {
                DropDownList4.Items.Add(dr1.GetString(0));
            }
        }
              
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
            dbconnect db2 = new dbconnect();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "select sub_code from tbl_sem where branch_id=@id and sem_no=@no";
            //cmd2.Parameters.AddWithValue("@no", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@id", DropDownList4.SelectedValue);
            cmd2.Parameters.AddWithValue("@no", DropDownList1.SelectedValue);
            SqlDataReader dr1 = db2.executeread(cmd2);
            
            

                while (dr1.Read())
                {
                    DropDownList2.Items.Add(dr1.GetString(0));

                }
            

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox3.Enabled = false;
        dbconnect db3 = new dbconnect();
        SqlCommand cmd3 = new SqlCommand();
        cmd3.CommandText = "select subject from tbl_sem where sub_code=@code";
        cmd3.Parameters.AddWithValue("@code", DropDownList2.SelectedValue);
        SqlDataReader dr10 = db3.executeread(cmd3);
        dr10.Read();
        TextBox3.Text = dr10.GetString(0);


        String d = TextBox5.Text;
        dbconnect db4 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select * from tbl_account where dept_id=@id";
        cmd4.Parameters.AddWithValue("@id", d);
        SqlDataReader dr14 = db4.executeread(cmd4);
        while (dr14.Read())
        {
            DropDownList3.Items.Add(dr14.GetString(0));

        }

    }
   
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db4 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select name from tbl_account where account_id=@id";
        cmd4.Parameters.AddWithValue("@id", DropDownList3.SelectedValue);
        SqlDataReader dr14 = db4.executeread(cmd4);
        dr14.Read();
        TextBox4.Text = dr14.GetString(0);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db24 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
       /* cmd1.CommandText = "insert into tbl_sem values(@code,@id,@no,@sub,@tch)";
        cmd1.Parameters.AddWithValue("@code", DropDownList2.SelectedValue);
        cmd1.Parameters.AddWithValue("@no", DropDownList1.SelectedValue);
        cmd1.Parameters.AddWithValue("@id", DropDownList4.SelectedValue);
        cmd1.Parameters.AddWithValue("@sub",TextBox3.Text);
        cmd1.Parameters.AddWithValue("@tch", DropDownList3.SelectedValue);*/
        cmd1.CommandText = "update tbl_sem set teacher=@tch where sub_code=@sub";
        cmd1.Parameters.AddWithValue("@tch", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@sub", DropDownList2.SelectedValue);
        db24.execute(cmd1);
        Response.Write("<script>alert('Successfull')</script>");
        
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db21 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_course where branch_id=@cid";
        cmd5.Parameters.AddWithValue("@cid", DropDownList4.SelectedValue);
        SqlDataReader dr1 = db21.executeread(cmd5);
        dr1.Read();
        TextBox2.Text = dr1.GetString(2);
    }
}