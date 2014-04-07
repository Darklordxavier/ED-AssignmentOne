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

            ConsultantLogic consultant = (ConsultantLogic)Session["consultant"];
            LinkedList<Report> reports = new LinkedList<Report>();

            if (consultant != null)
            {
                reports = consultant.getAllReports();

                foreach (Report report in reports)
                {
                    String reportData = String.Format("{0}", report.ReportDate); //could add more identifiers?
                    listboxReports.Items.Add(reportData);
                }
            }

            var connectionString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            var selectCommand = new SqlCommand("Select * From Reports where ConsultantID LIKE @id", connection);
            var adapter = new SqlDataAdapter(selectCommand);

            selectCommand.Parameters.Add("@Id", SqlDbType.VarChar).Value = "%" + User.Identity.Name + "%";

            var resultSet = new DataSet();
            adapter.Fill(resultSet);

            GridView1.DataSource = resultSet;
            GridView1.DataBind();

            connection.Close();
            
        }

        protected void btnCreateReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultantCreateReport.aspx");
        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            ConsultantLogic consultant = (ConsultantLogic)Session["consultant"];
            
            if (consultant != null)
            {
                //find and print report
                //later on make sure user selected something

                String selectedReport = listboxReports.SelectedItem.ToString();
                Report report = consultant.getReport(selectedReport); //here lies the problem

                if (report != null) //if report is found
                {
                    Session["reportPreview"] = report.getFormattedReport();
                    Response.Redirect("ConsultantShowReport.aspx");
                }
            }
        }
        
    }
}