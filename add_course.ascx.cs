using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_add_course : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Enabled = false;
        dbconnect db1 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "select dept_id from tbl_dept";
        SqlDataReader dr1 = db1.executeread(cmd1);
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1.GetString(0));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db1 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "insert into tbl_course values(@bid,@did,@crs,@nosem)";
        cmd1.Parameters.AddWithValue("@bid", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@did", DropDownList1.SelectedValue);
        cmd1.Parameters.AddWithValue("@crs", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@nosem", TextBox4.Text);

        db1.execute(cmd1);
        Response.Write("<script>confirm('Course Added')</script>");
        Server.Transfer("adminhome.aspx");

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        dbconnect db2 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "select * from tbl_dept where dept_id=@id";
        cmd2.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db2.executeread(cmd2);
        dr1.Read();

        TextBox2.Text = dr1.GetString(1);
    }
}