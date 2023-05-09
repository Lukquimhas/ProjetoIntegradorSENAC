using System.Configuration;
using Entitys;
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

        public List<Freight> ExecuteFreightSelectQuery(string query)
        {
            var Freights = new List<Freight>();
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
                    Freights.Add(new Freight
                    {
                        IdFreight = reader["Id"].ToString(),
                        From = reader["origem"].ToString(),
                        To = reader["destino"].ToString(),
                        Distance = double.Parse(reader["distancia"].ToString()),
                        ValueKm = double.Parse(reader["valor_km"].ToString()),
                        TotalValue = double.Parse(reader["valor_total"].ToString()),
                        Load = reader["carga"].ToString(),
                        Trace = reader["rastreio"].ToString(),
                        Obs = reader["observacao"].ToString(),
                        Driver = reader["motorista"].ToString(),
                        Client = reader["cliente"].ToString(),
                        Concluded = reader["concluido"].ToString()
                    });
                }

                return Freights;
            }
        }

        public static SqlConnection ConnectionProjetoSENAC()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}
