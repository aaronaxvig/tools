using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Axvig.Aaron.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SumpService : ISumpService
    {
        public int CreateReading(string meters)
        {
            double parsedMeters = double.Parse(meters);

            using (SqlConnection conn = new SqlConnection(SqlHelper.GetConnString()))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO SumpReadings (depth, timeStamp)" +
                        " OUTPUT INSERTED.id VALUES (@depth, @timeStamp);";
                    command.Parameters.AddWithValue("depth", parsedMeters);
                    command.Parameters.AddWithValue("timeStamp", DateTime.UtcNow);

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public List<double> GetReadings(string count)
        {
            int countParsed = int.Parse(count);

            using (SqlConnection conn = new SqlConnection(SqlHelper.GetConnString()))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT TOP " + countParsed + " depth FROM SumpReadings ORDER BY id DESC";

                    List<double> readings = new List<double>();
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        readings.Add(reader.GetDouble(0));
                    }

                    return readings;
                }
            }
        }
    }
}