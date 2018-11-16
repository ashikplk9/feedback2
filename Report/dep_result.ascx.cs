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

public partial class Report_dep_result : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        double opt1, opt2, opt3, opt4, opt5, opt6;
        double count = 8;
        double[] point = new double[18];
        int i = 0;
        string subcode;
        dbconnect db1 = new dbconnect();
        dbconnect db2 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        dbconnect db3 = new dbconnect();
        SqlCommand cmd3 = new SqlCommand();
        String dept = "DEPT_1";
        String cid = "MCA";
        String sem = "1";
        dbconnect db5 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "delete from tbl_temp";
        db5.execute(cmd5);

        cmd3.CommandText = "select subcode from stud_feedback where dept_id=@did and course=@c and sem=@s";
        cmd3.Parameters.AddWithValue("@did", dept);
        cmd3.Parameters.AddWithValue("@c", cid);
        cmd3.Parameters.AddWithValue("@s", sem);
        SqlDataReader dr3 = db3.executeread(cmd3);
        SqlDataReader dr1;
        while (dr3.Read())
        {
            subcode = dr3.GetString(0);

            cmd1.CommandText = "select * from tbl_feedback where fid=@fid";
            cmd1.Parameters.AddWithValue("@fid", subcode);
             dr1 = db1.executeread(cmd1);

            i = 0;
            while (dr1.Read())
            {
                opt1 = dr1.GetInt32(2);
                opt2 = dr1.GetInt32(3);
                opt3 = dr1.GetInt32(4);
                opt4 = dr1.GetInt32(5);
                opt5 = dr1.GetInt32(6);
                opt6 = dr1.GetInt32(7);

                point[i] = ((opt1 * 5) + (opt2 * 4) + (opt3 * 3) + (opt4 * 2) + (opt5 * 1) + (opt6 * .5)) / 10;

                i++;


            }
            cmd2.CommandText = "insert into tbl_temp values(@sid,@q1,@q2,@q3,@q4,@q5,@q6,@q7,@q8,@q9,@q10,@q11,@q12,@q13,@q14,@q15,@q16,@q17,@q18)";
            cmd2.Parameters.AddWithValue("@sid", subcode);
            cmd2.Parameters.AddWithValue("@q1", point[0]);
            cmd2.Parameters.AddWithValue("@q2", point[1]);
            cmd2.Parameters.AddWithValue("@q3", point[2]);
            cmd2.Parameters.AddWithValue("@q4", point[3]);
            cmd2.Parameters.AddWithValue("@q5", point[4]);
            cmd2.Parameters.AddWithValue("@q6", point[5]);
            cmd2.Parameters.AddWithValue("@q7", point[6]);
            cmd2.Parameters.AddWithValue("@q8", point[7]);
            cmd2.Parameters.AddWithValue("@q9", point[8]);
            cmd2.Parameters.AddWithValue("@q10", point[9]);
            cmd2.Parameters.AddWithValue("@q11", point[10]);
            cmd2.Parameters.AddWithValue("@q12", point[11]);
            cmd2.Parameters.AddWithValue("@q13", point[12]);
            cmd2.Parameters.AddWithValue("@q14", point[13]);
            cmd2.Parameters.AddWithValue("@q15", point[14]);
            cmd2.Parameters.AddWithValue("@q16", point[15]);
            cmd2.Parameters.AddWithValue("@q17", point[16]);
            cmd2.Parameters.AddWithValue("@q18", point[17]);
            db2.execute(cmd2);
            cmd1.Parameters.Clear();
            cmd2.Parameters.Clear();
        } report();
    }



    protected void Button2_Click(object sender, EventArgs e)
    {



    }
    public void report()
    {
        string collage = "AWH Engineering Collage";
        string department = "Deaprtment of Civil";
        string sem = " 1st Sem";
        dbconnect db1 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "select * from tbl_temp";
        SqlDataReader dr2 = db1.executeread(cmd1);


        try
        {
            string imageFilePath = Server.MapPath(".") + "/logo4.jpg";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);

            Document pdfDoc = new Document(PageSize.A2);
            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;

            jpg.ScaleToFit(600, 510);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            Paragraph Text1 = new Paragraph(collage);
            Paragraph Text2 = new Paragraph(department);
            Paragraph Text3 = new Paragraph(sem);
            PdfPTable table = new PdfPTable(19);
            PdfPCell cell = new PdfPCell(new Phrase("Feedback Result"));
            
            //----------------------------------------------------/

            cell.HorizontalAlignment = 1;
            table.HorizontalAlignment = 1;


            cell.Colspan = 19;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            table.AddCell("Subject Code");
            table.AddCell("Q1");
            table.AddCell("Q2");
            table.AddCell("Q3");
            table.AddCell("Q4");
            table.AddCell("Q5");
            table.AddCell("Q6");
            table.AddCell("Q7");
            table.AddCell("Q8");
            table.AddCell("Q9");
            table.AddCell("Q10");
            table.AddCell("Q11");
            table.AddCell("Q12");
            table.AddCell("Q13");
            table.AddCell("Q14");
            table.AddCell("Q15");
            table.AddCell("Q16");
            table.AddCell("Q17");
            table.AddCell("Q18");
            

            while (dr2.Read())
            {
                string code = Convert.ToString(dr2.GetString(0));
                string Q1 = Convert.ToString(dr2.GetDecimal(1));
                string Q2 = Convert.ToString(dr2.GetDecimal(2));
                string Q3 = Convert.ToString(dr2.GetDecimal(3));
                string Q4 = Convert.ToString(dr2.GetDecimal(4));
                string Q5 = Convert.ToString(dr2.GetDecimal(5));
                string Q6 = Convert.ToString(dr2.GetDecimal(6));
                string Q7 = Convert.ToString(dr2.GetDecimal(7));
                string Q8 = Convert.ToString(dr2.GetDecimal(8));
                string Q9 = Convert.ToString(dr2.GetDecimal(9));
                string Q10 = Convert.ToString(dr2.GetDecimal(10));
                string Q11 = Convert.ToString(dr2.GetDecimal(11));
                string Q12 = Convert.ToString(dr2.GetDecimal(12));
                string Q13 = Convert.ToString(dr2.GetDecimal(13));
                string Q14 = Convert.ToString(dr2.GetDecimal(14));
                string Q15 = Convert.ToString(dr2.GetDecimal(15));
                string Q16 = Convert.ToString(dr2.GetDecimal(16));
                string Q17 = Convert.ToString(dr2.GetDecimal(17));
                string Q18 = Convert.ToString(dr2.GetDecimal(18));

                
                table.AddCell(code);
                table.AddCell(Q1);
                table.AddCell(Q2);
                table.AddCell(Q3);
                table.AddCell(Q4);
                table.AddCell(Q5);
                table.AddCell(Q6);
                table.AddCell(Q7);
                table.AddCell(Q8);
                table.AddCell(Q9);
                table.AddCell(Q10);
                table.AddCell(Q11);
                table.AddCell(Q12);
                table.AddCell(Q13);
                table.AddCell(Q14);
                table.AddCell(Q15);
                table.AddCell(Q16);
                table.AddCell(Q17);
                table.AddCell(Q18);
            }

            Text1.Alignment = Element.ALIGN_CENTER;
            cell.BorderWidthBottom = 3f;


            
            //----------------------------------------------------------------------//

            PdfPTable table1 = new PdfPTable(3);
            PdfPCell cell1 = new PdfPCell(new Phrase("Feedback Result"));
            cell.Colspan = 19;
            cell.HorizontalAlignment = 1;
            
            table1.AddCell("Subject Code");
            table1.AddCell("Subject Name");
            table1.AddCell("Staff Name");
            dbconnect db6 = new dbconnect();
            SqlCommand cmd6 = new SqlCommand();
            cmd6.CommandText = "select subid,subject,teacher from tbl_temp,tbl_sem where tbl_temp.subid=tbl_sem.sub_code";
          //  cmd6.CommandText = "select sub_code,subject,teacher from tbl_sem where sem_no='1'";
            SqlDataReader dr6 = db6.executeread(cmd6);
            while (dr6.Read())
            {
                string code = Convert.ToString(dr6.GetString(0));
                string Q1 = Convert.ToString(dr6.GetString(1));
                string Q2 = Convert.ToString(dr6.GetString(2));
                table1.AddCell(code);
                table1.AddCell(Q1);
                table1.AddCell(Q2);
            }
            pdfDoc.Add(jpg);
            pdfDoc.Add(Text1);
            pdfDoc.Add(Text2);
            pdfDoc.Add(Text3);
            pdfDoc.Add(table);
            pdfDoc.Add(Text1);
            pdfDoc.Add(Text2);
            pdfDoc.Add(Text3);
            pdfDoc.Add(table1);


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

}



