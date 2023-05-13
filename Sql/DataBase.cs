using System.Configuration;
using Entitys;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace Sql
{
    public class DataBase
    {
        public void ExecuteQuery(string query)
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

        public List<_freight> ExecuteFreightSelectQuery(string query)
        {
            var Freights = new List<_freight>();
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
                    Freights.Add(new _freight
                    {
                        IdFreight = reader["Id"].ToString(),
                        StartPoint = reader["origem"].ToString(),
                        Destination = reader["destino"].ToString(),
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

        public _user ExecuteUserLoggedSelectQuery(string query)
        {
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
                    var user = new _user
                    {
                        UserId = reader["IdUsuario"].ToString(),
                        Name = reader["nome"].ToString(),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        Password = reader["senha"].ToString(),
                        Cpf = reader["cpf"].ToString(),
                        IdCompany = reader["IdEmpresa"].ToString(),
                        AccountType = reader["tipo_acesso"].ToString()
                    };
                    return user;
                }

                return new _user();
            }
        }



        public static SqlConnection ConnectionProjetoSENAC()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}
