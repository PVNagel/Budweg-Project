using BudwegErrorLoggingSystem.Commands;
using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;

namespace BudwegErrorLoggingSystem.Persistens
{
    public class ErrorReportRepo : IDisposable
    {

        public SqlConnection Connection { get; private set; }
        public ErrorReportRepo()
        {
            var dataSource = "(local)\\SQLEXPRESS";
            var initialCatalog = "BudwegDevelopment";

            var connectionString = $"Data Source={dataSource};Initial Catalog={initialCatalog};Integrated Security=True;TrustServerCertificate=True";
            Connection = new SqlConnection(connectionString);
            Connection.Open();


        }
        public void Save(Report errorReport)
        {
            var commandString = $"INSERT INTO ErrorReport  (ErrorCode, ErrorType, ErrorDescription, WorkerID, InspectorID, IsResolved) " +
                $"VALUES ({errorReport.ReportDisplay}, 'placeholder', '{errorReport.ErrorMessage}', 1, 1, {Convert.ToInt32(errorReport.IsResolved)});";
            var command = new SqlCommand(commandString, Connection);

            command.ExecuteReader().Close();
        }


        public Report? Get(int id)
        {
            var commandString = $"SELECT * FROM dbo.ErrorReport WHERE ErrorReportID = {id}";
            var command = new SqlCommand(commandString, Connection);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var result = new Report(id: Convert.ToInt32(reader[0].ToString()), reportDisplay: reader[1].ToString(), errorMessage: reader[3].ToString(), isResolved: bool.Parse(reader[6].ToString()));
                    return result;
                }
            }
            return null;
        }
        public ICollection<Report> GetAll()
        {
            var commandString = $"SELECT * FROM dbo.ErrorReport";
            var command = new SqlCommand(commandString, Connection);

            var result = new List<Report>();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(new Report(id: Convert.ToInt32(reader[0].ToString()), reportDisplay: reader[1].ToString(), errorMessage: reader[3].ToString(), isResolved: bool.Parse(reader[6].ToString())));

                }
            }
            return result;
        }

        public void DeleteRow(int id)
        {
            var commandString = $"DELETE FROM dbo.ErrorReport WHERE ErrorReportID = {id}";
            var command = new SqlCommand(commandString, Connection);
            command.ExecuteReader().Close();

        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
