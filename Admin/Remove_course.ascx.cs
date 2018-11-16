using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_Remove_branch : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db3 = new dbconnect();
        SqlCommand cmd3 = new SqlCommand();
        cmd3.CommandText = "delete from tbl_course where dept_id=@id";
        cmd3.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
        db3.execute(cmd3);
        Panel1.Visible = false;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db2 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "select * from tbl_course where dept_id=@id";
        cmd2.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db2.executeread(cmd2);
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1.GetString(0));
        }
        

        
    }


    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db2 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "select * from tbl_course where branch_id=@id";
        cmd2.Parameters.AddWithValue("@id", DropDownList2.SelectedValue);
        SqlDataReader dr1 = db2.executeread(cmd2);
        dr1.Read();

        TextBox1.Text = dr1.GetString(2);
        TextBox2.Text = dr1.GetString(3);
        Panel1.Visible = true;
    }
}