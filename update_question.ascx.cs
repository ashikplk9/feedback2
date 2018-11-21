using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_update_question : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbconnect db1 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select qno from tbl_qstn";
            SqlDataReader dr1 = db1.executeread(cmd1);
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1.GetString(0));
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         dbconnect db17 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "update tbl_qstn set qstn=@qn where qno=@no";
        cmd4.Parameters.AddWithValue("@qn",TextBox1.Text);
        cmd4.Parameters.AddWithValue("@no", DropDownList1.SelectedValue);

        db17.execute(cmd4);


        Response.Write("<script>confirm('Question Updated')</script>");
        
        Server.Transfer("adminhome.aspx");


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db2 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "select qstn from tbl_qstn where qno=@no";
        cmd2.Parameters.AddWithValue("@no", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db2.executeread(cmd2);
        dr1.Read();

        TextBox1.Text = dr1.GetString(0);
    }
}