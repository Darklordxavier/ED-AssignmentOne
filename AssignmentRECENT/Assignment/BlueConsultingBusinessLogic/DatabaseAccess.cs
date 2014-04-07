using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using BlueConsultingBusinessLogic.ReportDataSetTableAdapters;
namespace BlueConsultingBusinessLogic
{
    public static class DatabaseAccess
    {
        
        public static ReportDataSet getReportsByConsultantID(string consultantID)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            var selectCommand = new SqlCommand("SELECT * FROM FOODS", connection);
            var adapter = new SqlDataAdapter(selectCommand);

            var resultSet = new ReportDataSet();


            connection.Close();
            return resultSet;
            
            /*SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            connection.Open();
            //SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\11435803\Documents\Visual Studio 2012\Projects\Assignment\GUI\App_Data\DATABASE.MDF';Integrated Security=True");
            var selectCommand = new SqlCommand("Select * From Reports where ConsultantID LIKE @id", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            
            ReportDataSet report = new ReportDataSet();
            selectCommand.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = "%" + consultantID + "%";

            var tableAdapter = new ReportDataSet();
            tableAdapter.Fill(report);

            connection.Close();
            return tableAdapter;        
             * */
          
        }
         

    }
}
