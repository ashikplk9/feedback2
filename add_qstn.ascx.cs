using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_add_qstn : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            dbconnect db2 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select qid from tbl_key";
            SqlDataReader dr = db2.executeread(cmd1);
            dr.Read();
            int x = dr.GetInt32(0);
            x++;
            string q= x.ToString();
            TextBox1.Text = q;

            dbconnect db3 = new dbconnect();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "update tbl_key set qid=@x";
            cmd2.Parameters.AddWithValue("@x", x);
            db3.execute(cmd2);
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db2 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "insert into tbl_qstn values(@no,@qn)";
        cmd2.Parameters.AddWithValue("@no",TextBox1.Text);
        cmd2.Parameters.AddWithValue("@qn", TextBox2.Text);
        db2.execute(cmd2);
        Response.Redirect("adminhome.aspx");
        Response.Write("<script>confirm('Quesion Added')</script>");
        Server.Transfer("adminhome.aspx");

    }
}