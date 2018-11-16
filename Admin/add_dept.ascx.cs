using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_add_dept : System.Web.UI.UserControl
{
    dbconnect db1 = new dbconnect();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            dbconnect db2 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select did from tbl_key";
            SqlDataReader dr = db2.executeread(cmd1);
            dr.Read();
            int x = dr.GetInt32(0);
            x++;
            string did = "DEPT_" + x.ToString();
            TextBox1.Text = did;

            dbconnect db3 = new dbconnect();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "update tbl_key set did=@x";
            cmd2.Parameters.AddWithValue("@x", x);
            db3.execute(cmd2);
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText="insert into tbl_dept values(@did,@crs)";
        cmd1.Parameters.AddWithValue("@did", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@crs", TextBox2.Text);
       
       
        db1.execute(cmd1);
        Response.Redirect("adminhome.aspx");

    }
}