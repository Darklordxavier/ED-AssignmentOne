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
            //update the date time using session?
            labelDate.Text = DateTime.Now.ToString();

            List<Report> reports = new List<Report>();

            //var connectionString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            //var connection = new SqlConnection(connectionString);
            //var selectCommand = new SqlCommand("Select * From Reports where ConsultantID LIKE @id", connection);
            //var adapter = new SqlDataAdapter(selectCommand);

            //selectCommand.Parameters.Add("@Id", SqlDbType.VarChar).Value = "%" + User.Identity.Name + "%";

            //var resultSet = new DataSet();
            //adapter.Fill(resultSet);

            //GridView1.DataSource = resultSet;
            //GridView1.DataBind();

            DataSet reportDataSet = BlueConsultingBusinessLogic.DatabaseAccess.getReportDataSet(User.Identity.Name);
            GridView1.DataSource = reportDataSet;
            GridView1.DataBind();
            //connection.Close();
            
        }

        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            Response.Write(" <script language='javascript'> window.open('SubmitReport.aspx','','width=500,Height=500,fullscreen=0,location=0,scrollbars=1,menubar=1,toolbar=1'); </script>"); ;
        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            
          
          
        }
        
    }
}