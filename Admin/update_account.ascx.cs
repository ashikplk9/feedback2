using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_update_account : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            dbconnect db1 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select account_id from tbl_account";
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
        cmd2.CommandText = "select * from tbl_account where account_id=@id";
        cmd2.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db2.executeread(cmd2);
        dr1.Read();
        TextBox1.Text = dr1.GetString(1);
        TextBox2.Text = dr1.GetString(3);
        TextBox3.Text = dr1.GetString(4);
        TextBox4.Text = dr1.GetString(5);
        string des = dr1.GetString(2);
        if (des == "HOD")
        {
            RadioButtonList1.Items[0].Selected = true;
        }
        else if (des == "Tutor")
        {
            RadioButtonList1.Items[1].Selected = true;
        }
        else
        {
            RadioButtonList1.Items[2].Selected = true;
        }
        
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db17 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "update tbl_account set account_id='" + DropDownList1.SelectedValue + "',name='" + TextBox1.Text
+ "',designation='" + RadioButtonList1.SelectedValue + "',dept_id='" + TextBox2.Text + "',email='" + TextBox3.Text + "',phone='"
    + TextBox4.Text + "',status='ok' Where account_id='" + DropDownList1.SelectedValue + "' ";
        db17.execute(cmd4);

        dbconnect db16 = new dbconnect();
        SqlCommand cmd7 = new SqlCommand();
        cmd7.CommandText = "update tbl_login set userid='" + DropDownList1.SelectedValue +
            "',pass='" + TextBox4.Text + "',type='" + RadioButtonList1.SelectedValue +
            "' Where userid='" + DropDownList1.SelectedValue + "' ";
        db16.execute(cmd7);
    }
}