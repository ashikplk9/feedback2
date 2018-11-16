using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Tutor_add_sem : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String s = Convert.ToString(Session["us"]);
        dbconnect db21 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_account where account_id=@cid";
        cmd5.Parameters.AddWithValue("@cid",s);
        SqlDataReader dr11 = db21.executeread(cmd5);
        dr11.Read();
        TextBox2.Text = dr11.GetString(3);
        if (!IsPostBack)
        {
            dbconnect db1 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select branch_id from tbl_course";
            SqlDataReader dr1 = db1.executeread(cmd1);
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1.GetString(0));
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db21 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_course where branch_id=@cid";
        cmd5.Parameters.AddWithValue("@cid", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db21.executeread(cmd5);
        dr1.Read();
        TextBox1.Text = dr1.GetString(2);
    }
  
    protected void Button3_Click(object sender, EventArgs e)
    {
        dbconnect db23 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "insert into tbl_sem values(@subcode,@brid,@semno,@subject)";
        cmd1.Parameters.AddWithValue("@subcode", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@brid",DropDownList1.SelectedValue);
        cmd1.Parameters.AddWithValue("@semno", TextBox6.Text);
        cmd1.Parameters.AddWithValue("@subject", TextBox5.Text);
        db23.execute(cmd1);
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
}