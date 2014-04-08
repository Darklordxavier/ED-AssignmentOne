using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using BlueConsultingBusinessLogic.ReportDataSetTableAdapters;
using System.Data;

namespace BlueConsultingBusinessLogic
{
    public static class DatabaseAccess
    {
        public static ReportDataSet getReportDataSet(string consultantID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            var selectCommand = new SqlCommand("Select * From Reports where ConsultantID LIKE @id", connection);
            var adapter = new SqlDataAdapter(selectCommand);

            selectCommand.Parameters.Add("@Id", SqlDbType.VarChar).Value = "%" + consultantID + "%";

            var resultSet = new ReportDataSet();
            adapter.Fill(resultSet);
            connection.Close();
            return resultSet;
        }

        

        public static void insertReportToDatabase(Report report)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            #region CommandCreation
            var insertCommand = new SqlCommand("INSERT Into Reports VALUES (@DepartmentSupervisorID, @ConsultantID, @ReportStatus, @PDF)", connection);
            if (report.DepartmentSupervisorID == null)
            {
                insertCommand.Parameters.Add("@DepartmentSupervisorID", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                insertCommand.Parameters.Add("@DepartmentSupervisorID", SqlDbType.VarChar).Value =report.DepartmentSupervisorID;
            }

            if (report.ConsultantID == null)
            {
                insertCommand.Parameters.Add("@ConsultantID", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                insertCommand.Parameters.Add("@ConsultantID", SqlDbType.VarChar).Value = report.ConsultantID;
            }

            if (report.ReportStatus == null)
            {
                insertCommand.Parameters.Add("@ReportStatus", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                insertCommand.Parameters.Add("@ReportStatus", SqlDbType.VarChar).Value =  report.ReportStatus;
            }

            if (report.PDF == null)
            {
                insertCommand.Parameters.Add("@PDF", SqlDbType.VarBinary).Value = DBNull.Value;
            }
            else
            {
                insertCommand.Parameters.Add("@PDF", SqlDbType.VarBinary).Value =  report.PDF ;
            }
            #endregion
            connection.Open();
            insertCommand.ExecuteNonQuery();
            connection.Close();
            //var adapter = new SqlDataAdapter(selectCommand);
        }


    }

    
}
