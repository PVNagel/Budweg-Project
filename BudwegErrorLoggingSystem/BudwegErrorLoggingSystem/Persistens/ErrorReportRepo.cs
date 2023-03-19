using BudwegErrorLoggingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudwegErrorLoggingSystem.Persistens
{
    public class ErrorReportRepo
    {
        public ErrorReportRepo() 
        {
            var dataSource = "(local)\\SQLEXPRESS";
            var initialCatalog = "BudwegDevelopment";

            var connectionString = $"Data Source={dataSource};Initial Catalog={initialCatalog};Integrated Security=True;Trust Server Certificate=true";
            var connection = new SqlConnection(connectionString);

            connection.Open();

            var toInsert = new ErrorReport
            {
                ErrorCode = "2020",
                ErrorDescription = "Bla bla",
                ErrorType = "Blø blø"

            };
            Insert(connection, toInsert);
            Read(connection);
            connection.Close();
        }
        private static void Insert(SqlConnection connection, ErrorReport errorReport)
        {
            var commandString = $"INSERT INTO ErrorReport  (ErrorCode, ErrorType, ErrorDescription, WorkerID, InspectorID, IsResolved) " +
                $"VALUES ({errorReport.ErrorCode}, '{errorReport.ErrorType}', '{errorReport.ErrorDescription}', 1, 1, 1);";
            var command = new SqlCommand(commandString, connection);

            command.ExecuteReader().Close();
        }


        private static void Read(SqlConnection connection)
        {
            var commandString = "SELECT * FROM dbo.ErrorReport";
            var command = new SqlCommand(commandString, connection);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.Write(reader[0].ToString());
                    Console.Write(reader[1].ToString());
                    Console.Write(reader[2].ToString());
                    Console.Write(reader[3].ToString());
                    Console.WriteLine();
                }

            }
        }
    }
}
