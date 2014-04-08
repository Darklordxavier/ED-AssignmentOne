using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlueConsultingBusinessLogic;
using BlueConsultingBusinessLogic.ReportDataSetTableAdapters;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GUI.Consultant
{
    public partial class ConsultantMainGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //refresh
            labelDate.Text = DateTime.Now.ToString();

            List<Report> reports = new List<Report>();
            DataSet reportDataSet = DatabaseAccess.getReportDataSet(User.Identity.Name);
            listboxReports.DataSource = reportDataSet;
            listboxReports.DataBind();

            GridView1.DataSource = reportDataSet;
            GridView1.DataBind();
        }

        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            Response.Write(" <script language='javascript'> window.open('SubmitReport.aspx','','width=500,Height=500,fullscreen=0,location=0,scrollbars=1,menubar=1,toolbar=1'); </script>"); ;
        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            
      
          
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }
        
    }
}