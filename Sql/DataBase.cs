using System.Configuration;
using System.Configuration.Provider;
using System.Data.SqlClient;

namespace Sql
{
    public class DataBase
    {
        public void ExecuteInsertQuery(string query)
        {
            using(var conn = ConnectionProjetoSENAC())
            {
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandText = query
                };
                conn.Open();

                command.ExecuteNonQuery();
            }
        }

        public List<string> ExecuteSelectQuery(string query)
        {
            var InfoList = new List<string>();
            using (var conn = ConnectionProjetoSENAC())
            {
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandText = query
                };
                conn.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        InfoList.Add(reader.GetString(i));
                    }
                }

                return InfoList;
            }
        }

        public static SqlConnection ConnectionProjetoSENAC()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}
