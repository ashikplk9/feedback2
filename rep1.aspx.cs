using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

public partial class rep1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc");

            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ashik\Documents\Visual Studio 2010\login\App_Data\tbl_login.mdf;Integrated Security=True;User Instance=True");

            SqlDataAdapter ad = new SqlDataAdapter("select qno,opt1,opt2,opt3 from tbl_feedback", cn);
            DataSet1 ds = new DataSet1();

            ad.Fill(ds, "DataTable1");

            ReportDataSource datasource = new ReportDataSource("student", ds.Tables[0]);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }
    }
}