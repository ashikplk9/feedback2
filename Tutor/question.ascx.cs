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

    public static int j;
    public static int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Font.Bold = true;
        Label2.Font.Bold = true;
        Label8.Font.Bold = true;
        Label3.Font.Bold = true;
        Label4.Font.Bold = true;
        String sub, tchr,f;
        String m, y;
        sub = Convert.ToString(Session["subject"]);
        tchr = Convert.ToString(Session["teacher"]);
        m = Convert.ToString(Session["month"]);
        y = Convert.ToString(Session["year"]);
        f = Convert.ToString(Session["code"]);
        Label1.Text = Convert.ToString(m);
        Label2.Text = Convert.ToString(y);
        Label8.Text = Convert.ToString(f);
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
              count =db2.id(cmd1);
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

               
              if (i <count)
              {

                  i++;
                  
                
      cmd.CommandText = "select * from tbl_qstn where qno=" +i+ "";
      
                  SqlDataReader dr = db.executeread(cmd);

                 
                  while (dr.Read())
                  {
                      Label5.Text = dr[0].ToString();
                      TextBox1.Text = dr[1].ToString();
                  }
                  

                 
              }
            
              String opt = this.RadioButtonList1.SelectedValue;
              int a = Convert.ToInt32(Label5.Text) - 1;

              if (opt == "Excellent")
              {
                  cmd.CommandText = "update tbl_feedback set opt1=opt1+1 where fid=@cd and qno=@q";
                  cmd.Parameters.AddWithValue("@cd", Label8.Text);
                  cmd.Parameters.AddWithValue("@q", a);


              }
              else if (opt == "Very good")
              {
                  cmd.CommandText = "update tbl_feedback set opt2=opt2+1 where fid=@cd and qno=@q";
                  cmd.Parameters.AddWithValue("@cd", Label8.Text);
                  cmd.Parameters.AddWithValue("@q", a);


              }
              else if (opt == "Good")
              {
                  cmd.CommandText = "update tbl_feedback set opt3=opt3+1 where fid=@cd and qno=@q";
                  cmd.Parameters.AddWithValue("@cd", Label8.Text);
                  cmd.Parameters.AddWithValue("@q", a);


              }
              else if (opt == "Average")
              {
                  cmd.CommandText = "update tbl_feedback set opt4=opt4+1 where fid=@cd and qno=@q";
                  cmd.Parameters.AddWithValue("@cd", Label8.Text);
                  cmd.Parameters.AddWithValue("@q", a);


              }
              else if (opt == "Poor")
              {
                  cmd.CommandText = "update tbl_feedback set opt5=opt5+1 where fid=@cd and qno=@q";
                  cmd.Parameters.AddWithValue("@cd", Label8.Text);
                  cmd.Parameters.AddWithValue("@q", a);


              }
              else
              {
                  cmd.CommandText = "update tbl_feedback set opt6=opt6+1 where fid=@cd and qno=@q";
                  cmd.Parameters.AddWithValue("@cd", Label8.Text);
                  cmd.Parameters.AddWithValue("@q",a);


              }
                                


              
              db.execute(cmd);
              RadioButtonList1.ClearSelection();



          }

      
}
     








