using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class admin_add_account : System.Web.UI.UserControl
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Enabled = false;
        //Response.Write("<script>alert('Please login')</script>");

        //string z = Session["us"].ToString();
        if (Session["us"] == null)
        {
            //Response.Write("<script>alert('Please login')</script>");
            //Server.Transfer("add_account.aspx");
           // Server.Transfer("logerror.aspx");
            Response.Redirect("logerror.aspx");

        }
        
        if (!IsPostBack)
        {

            dbconnect db2 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select aid from tbl_key";
            SqlDataReader dr = db2.executeread(cmd1);
            dr.Read();
            int x = dr.GetInt32(0);
            x++;
            string aid = "ACC_" + x.ToString();
            TextBox1.Text = aid;

            dbconnect db3 = new dbconnect();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "update tbl_key set aid=@x";
            cmd2.Parameters.AddWithValue("@x", x);
            db3.execute(cmd2);


            dbconnect db4 = new dbconnect();
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select dept_name from tbl_dept";
            SqlDataReader dr1 = db4.executeread(cmd4);
            while (dr1.Read())
            {
                DropDownList2.Items.Add(dr1.GetString(0));
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db6 = new dbconnect();
        SqlCommand cmd6 = new SqlCommand();
        cmd6.CommandText = "SELECT * from tbl_account where account_id=@acid";
        cmd6.Parameters.AddWithValue("@acid", TextBox1.Text);
        SqlDataReader dr2 = db6.executeread(cmd6);
        if (dr2.HasRows)
        {
            Response.Write("<script>confirm('Account Id alredy exists')</script>");
            //Server.Transfer("add_account.aspx");
            Server.Transfer("adminhome.aspx");

        }
        else
        {

            dbconnect db5 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();

            cmd1.CommandText = "insert into tbl_account values(@aid,@name,@desig,@di,@em,@ph,@st,@ph)";
            cmd1.Parameters.AddWithValue("@aid", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@desig", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("di", Label8.Text);
            cmd1.Parameters.AddWithValue("@em", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@ph", TextBox4.Text);
            cmd1.Parameters.AddWithValue("@st", "ok");

            db5.execute(cmd1);
            Response.Write("<script>alert('Account Created')</script>");
            Server.Transfer("adminhome.aspx");
            //Response.Redirect("adminhome.aspx");

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db6 = new dbconnect();
        SqlCommand cmd6 = new SqlCommand();
        dbconnect db7 = new dbconnect();
        SqlCommand cmd7 = new SqlCommand();
        dbconnect db8 = new dbconnect();
        SqlCommand cmd8 = new SqlCommand();
        string x = DropDownList1.SelectedValue;

        cmd7.CommandText = "SELECT dept_name from tbl_account,tbl_dept where tbl_dept.dept_id=tbl_account.dept_id and tbl_account.dept_id=@did";
        cmd7.Parameters.AddWithValue("@did", Label8.Text);
        SqlDataReader dr7 = db7.executeread(cmd7);
        dr7.Read();
        if (dr7.HasRows)
        {
        string dn = dr7.GetString(0);


        if (x.Equals("HOD"))
        {
            cmd6.CommandText = "SELECT * from tbl_account where dept_id=@did and designation='HOD'";
            cmd6.Parameters.AddWithValue("@did", Label8.Text);
            SqlDataReader dr2 = db6.executeread(cmd6);
            if (dr2.HasRows)
            {
                Response.Write("<script>confirm('HOD alredy exists')</script>");
                //Server.Transfer("add_account.aspx");
                Server.Transfer("adminhome.aspx");

            }

        }


        if (x.Equals("Tutor"))
        {



            cmd8.CommandText = "SELECT COUNT (*) from tbl_account where dept_id=@did and designation='Tutor'";
            cmd8.Parameters.AddWithValue("@did", DropDownList2.SelectedValue);
            SqlDataReader dr8 = db8.executeread(cmd8);

            dr8.Read();
            int n = dr8.GetInt32(0);
            if (dn.Equals("MCA") && n >= 3)
            {
                Response.Write("<script>confirm('Alredy 3 Tutors exists')</script>");
                //Server.Transfer("add_account.aspx");
                //Server.Transfer("adminhome.aspx");

            }
            string dn1 = dn.Substring(0, 3);
            if (dn1.Equals("Btech") && n >= 4)
            {
                Response.Write("<script>confirm('Alredy 4 Tutors exists')</script>");
                //Server.Transfer("add_account.aspx");
                //Server.Transfer("adminhome.aspx");

            }
            if (dn1.Equals("Mtech") && n >= 2)
            {
                Response.Write("<script>confirm('Alredy 2 Tutors exists')</script>");
                //Server.Transfer("add_account.aspx");
                //Server.Transfer("adminhome.aspx");

            }
        }
        }



    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db10 = new dbconnect();
        SqlCommand cmd10 = new SqlCommand();
        cmd10.CommandText = "select dept_id from tbl_dept where dept_name=@dname";
        cmd10.Parameters.AddWithValue("@dname", DropDownList2.SelectedValue);
        SqlDataReader dr1 = db10.executeread(cmd10);
        dr1.Read();
        Label8.Text = dr1.GetString(0);
    }
}