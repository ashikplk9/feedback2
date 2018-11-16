using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Tutor_question : System.Web.UI.UserControl
{

    public static int i = 1;
    public static int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        String sub, tchr,f;
        string m, y;
        sub = Convert.ToString(Session["subject"]);
        tchr = Convert.ToString(Session["teacher"]);
        m = Convert.ToString(Session["month"]);
        y = Convert.ToString(Session["year"]);
        f = Convert.ToString(Session["subcode"]);
        Label1.Text = Convert.ToString(m);
        Label2.Text = Convert.ToString(y);
        Label9.Text = Convert.ToString(f);
        Label3.Text = sub;
        Label4.Text = tchr;


        if (!IsPostBack)
        {
         
            dbconnect db1 = new dbconnect();
            dbconnect db2 = new dbconnect();
              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = "select * from tbl_qstn where qno=" + i + "";
              SqlCommand cmd1 = new SqlCommand();
              cmd1.CommandText = "select count(*) from tbl_qstn";
              count = (db2.id(cmd1));
              SqlDataReader dr = db1.executeread(cmd);

              while (dr.Read())
              {
                  Label5.Text = dr[0].ToString();
                  TextBox1.Text = dr[1].ToString();
              }

          }
      }
      protected void Button1_Click(object sender, EventArgs e)
      {
          if (i > 1)
          {
              i--;


              dbconnect db2 = new dbconnect();

              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = "select * from tbl_qstn where qno=" + i + "";
         
              SqlDataReader dr = db2.executeread(cmd);

              while (dr.Read())
              {
                  Label5.Text = dr[0].ToString();
                  TextBox1.Text = dr[1].ToString();
              }
          }
      }
      protected void Button2_Click(object sender, EventArgs e)
      {
          dbconnect db = new dbconnect();
          SqlCommand cmd = new SqlCommand();

          if (i <= count)
          {
              //i++;


              
              SqlCommand cmd11 = new SqlCommand();
              String opt = this.RadioButtonList1.SelectedValue;


              if (opt == "Excellent")
              {
                  cmd11.CommandText = "update tbl_feedback set opt1=opt1+1 where fid=@cd and qno=@q";
                  cmd11.Parameters.AddWithValue("@cd", Label9.Text);
                  cmd11.Parameters.AddWithValue("@q", Label5.Text);


              }
              else if (opt == "Very good")
              {
                  cmd11.CommandText = "update tbl_feedback set opt2=opt2+1 where fid=@cd and qno=@q";
                  cmd11.Parameters.AddWithValue("@cd", Label9.Text);
                  cmd11.Parameters.AddWithValue("@q", Label5.Text);


              }
              else if (opt == "Good")
              {
                  cmd11.CommandText = "update tbl_feedback set opt3=opt3+1 where fid=@cd and qno=@q";
                  cmd11.Parameters.AddWithValue("@cd", Label9.Text);
                  cmd11.Parameters.AddWithValue("@q", Label5.Text);


              }
              else if (opt == "Average")
              {
                  cmd11.CommandText = "update tbl_feedback set opt4=opt4+1 where fid=@cd and qno=@q";
                  cmd11.Parameters.AddWithValue("@cd", Label9.Text);
                  cmd11.Parameters.AddWithValue("@q", Label5.Text);


              }
              else if (opt == "Poor")
              {
                  cmd11.CommandText = "update tbl_feedback set opt5=opt5+1 where fid=@cd and qno=@q";
                  cmd11.Parameters.AddWithValue("@cd", Label9.Text);
                  cmd11.Parameters.AddWithValue("@q", Label5.Text);


              }
              else if (opt == "Very Poor")
              {
                  cmd11.CommandText = "update tbl_feedback set opt6=opt6+1 where fid=@cd and qno=@q";
                  cmd11.Parameters.AddWithValue("@cd", Label9.Text);
                  cmd11.Parameters.AddWithValue("@q", Label5.Text);


              }

              db.execute(cmd11);
              RadioButtonList1.ClearSelection();
              i++;
              cmd.CommandText = "select * from tbl_qstn where qno=" + i + "";

              SqlDataReader dr = db.executeread(cmd);

              while (dr.Read())
              {
                  Label5.Text = dr[0].ToString();
                  TextBox1.Text = dr[1].ToString();
              }

              //Response.Redirect("feedback.aspx");
          }

          //i++;

        }






      protected void Button3_Click(object sender, EventArgs e)
      {
          String s = RadioButtonList1.SelectedValue;
          Label9.Text = s;
      }
      protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
}






