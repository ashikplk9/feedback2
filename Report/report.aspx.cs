using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;



public partial class Report_report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("--select--");
            dbconnect db6 = new dbconnect();
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select distinct(dept_id) from stud_feedback";
            SqlDataReader dr1 = db6.executeread(cmd4);
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1.GetString(0));
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Add("--select--");
        dbconnect db8 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from stud_feedback where dept_id=@did";
        cmd5.Parameters.AddWithValue("@did", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db8.executeread(cmd5);
        
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1.GetString(2));
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

        DropDownList3.Items.Add("--select--");
        dbconnect db8 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from stud_feedback where course=@course";
        cmd5.Parameters.AddWithValue("@course", DropDownList2.SelectedValue);
        SqlDataReader dr1 = db8.executeread(cmd5);
        while (dr1.Read())
        {
            DropDownList3.Items.Add(dr1.GetString(4));
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList4.Items.Add("--select--");
        dbconnect db8 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from stud_feedback where sem=@sem and course=@c and dept_id=@did";
        cmd5.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        cmd5.Parameters.AddWithValue("@c", DropDownList2.SelectedValue);
        cmd5.Parameters.AddWithValue("@did", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db8.executeread(cmd5);
        while (dr1.Read())
        {
            DropDownList4.Items.Add(dr1.GetString(5));
        }
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db8 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from stud_feedback where sub=@sub";
        cmd5.Parameters.AddWithValue("@sub", DropDownList4.SelectedValue);
        SqlDataReader dr1 = db8.executeread(cmd5);
        dr1.Read();
        TextBox1.Text = dr1.GetString(6);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string did = DropDownList1.SelectedValue; ;
        string course = DropDownList2.SelectedValue; ;
        string sem = DropDownList3.SelectedValue;
        string sub = DropDownList4.SelectedValue;
        string teacher = TextBox1.Text;

        dbconnect db9 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select qno,opt1,opt2,opt3,opt4,opt5,opt6 from tbl_feedback,stud_feedback where tbl_feedback.fid=stud_feedback.fid";
        SqlDataReader dr2 = db9.executeread(cmd5);

        //dr2.Read();
        //string qno = Convert.ToString(dr2.GetInt32(0));
        //string opt1 = Convert.ToString(dr2.GetInt32(1));
        //string opt2 = Convert.ToString(dr2.GetInt32(2));
        //string opt3 = Convert.ToString(dr2.GetInt32(3));
        //string opt4 = Convert.ToString(dr2.GetInt32(4));
        //string opt5 = Convert.ToString(dr2.GetInt32(5));
        //string opt6 = Convert.ToString(dr2.GetInt32(6));
        try
        {
            string imageFilePath = Server.MapPath(".") + "/logo4.jpg";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);

            Document pdfDoc = new Document(PageSize.A4, 25, 10, 25, 10);
            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;

            jpg.ScaleToFit(600, 510);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            Paragraph Text = new Paragraph  ("Department ID :" + did + "\n Course :" + course + "\n Sem No :" + sem + "\n Subject :" + sub + "\n Teacher :" + teacher + "\n \n \n");
            PdfPTable table = new PdfPTable(7);
            PdfPCell cell = new PdfPCell(new Phrase("Feedback Result"));
            cell.Colspan = 7;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            table.AddCell("Qno");
            table.AddCell("Excelent");
            table.AddCell("Very Good");
            table.AddCell("Good");
            table.AddCell("Avarage");
            table.AddCell("Poor");
            table.AddCell("Very Poor");
            while (dr2.Read())
            {
                string qno = Convert.ToString(dr2.GetInt32(0));
                string opt1 = Convert.ToString(dr2.GetInt32(1));
                string opt2 = Convert.ToString(dr2.GetInt32(2));
                string opt3 = Convert.ToString(dr2.GetInt32(3));
                string opt4 = Convert.ToString(dr2.GetInt32(4));
                string opt5 = Convert.ToString(dr2.GetInt32(5));
                string opt6 = Convert.ToString(dr2.GetInt32(6));

                // table.AddCell("Qno");
                table.AddCell(qno);
                // table.AddCell("Excelent");
                table.AddCell(opt1);
                //   table.AddCell("Very Good");
                table.AddCell(opt2);
                // table.AddCell("Good");
                table.AddCell(opt3);
                // table.AddCell("Avarage");
                table.AddCell(opt4);
                // table.AddCell("Poor");
                table.AddCell(opt5);
                // table.AddCell("Very Poor");
                table.AddCell(opt6);
            }
            
            Text.Alignment = Element.ALIGN_CENTER;
            
            pdfDoc.Add(jpg);
            pdfDoc.Add(Text);
            pdfDoc.Add(table);

            pdfWriter.CloseStream = false;
            pdfDoc.Close();
            Response.Buffer = true;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Report.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();

        }
        catch (Exception ex)
        { Response.Write(ex.Message); }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       /* MailMessage msg = new MailMessage();
        msg.From = new MailAddress("ashikplk9@gmail.com");
        msg.To.Add("ashik2793@gmail.com.com");
        msg.Body = "Testing the automatic mail";
        msg.IsBodyHtml = true;
        msg.Subject = "FeedBack Result";
        SmtpClient smt = new SmtpClient("smtp.gmail.com", 587);
        smt.Port = 587;
        smt.Credentials = new NetworkCredential("ashikplk9@gmail.com", "8891127854");
        smt.EnableSsl = true;
        smt.Send(msg);
        string script = "<script>alert('Mail Sent Successfully');self.close();</script>";  */

        
     
        /*    NetworkCredential login = new NetworkCredential("ashikplk9@gmail.com", "8891127854");

            System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

            email.To.Add(new MailAddress("ashik2793@gmail.com"));
            email.From = new MailAddress("ashikplk9@gmail.com");
            email.Subject = "Question";

            email.Body = "test";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = login;
            client.Send(email); */





        MailMessage msg = new MailMessage();
        System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
        try
        {
            msg.Subject = "Add Subject";
            msg.Body = "Add Email Body Part";
            msg.From = new MailAddress("ashikplk9@gmail.com");
            msg.To.Add("ashikplk9@gmai.com");
            msg.IsBodyHtml = true;
            client.Host = "smtp.gmail.com";
            System.Net.NetworkCredential basicauthenticationinfo = new System.Net.NetworkCredential("ashikplk9@gmail.com", "8891127854");
            client.Port = int.Parse("587");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicauthenticationinfo;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
            client.Send(msg);
        }
        catch (Exception ex)
        {
           
        }

        }
    }
