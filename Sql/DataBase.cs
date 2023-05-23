using System.Configuration;
using Entitys;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Sql
{
    public class DataBase
    {
        public void ExecuteQuery(string query)
        {
            using (var conn = ConnectionProjetoSENAC())
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
                    for (int i = 0; i < reader.FieldCount; i++)
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
                        StartPoint = reader["Origem"].ToString(),
                        Destination = reader["Destino"].ToString(),
                        Distance = double.Parse(reader["Distancia"].ToString()),
                        ValueKm = double.Parse(reader["ValorKm"].ToString()),
                        TotalValue = double.Parse(reader["ValorTotal"].ToString()),
                        Load = reader["Carga"].ToString(),
                        Trace = Convert.ToBoolean(reader["Rastreio"]),
                        Obs = reader["Observacao"].ToString(),
                        Driver = reader["Motorista"].ToString(),
                        Client = reader["Cliente"].ToString(),
                        Concluded = Convert.ToBoolean(reader["Concluido"]),
                        CreateDate = Convert.ToDateTime(reader["DataCriado"]),
                        IdClient = reader["idCliente"].ToString()
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
                        Name = reader["name"].ToString(),
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

        public List<string> ExecuteGetCity(string query, string state)
        {
            var cityList = new List<string>();
            using (var conn = ConnectionProjetoSENAC())
            {
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandText = query
                };

                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cityList.Add($"{reader["cidade"]}-{reader["estado"]}");
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return cityList;
        }

        public Company ExecuteGetCompany(string query)
        {
            using (var conn = ConnectionProjetoSENAC())
            {
                try
                {
                    var command = new SqlCommand()
                    {
                        Connection = conn,
                        CommandText = query,
                    };
                    conn.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var company = new Company
                        {
                            CompanyId = reader["EmpresaId"].ToString(),
                            CorporateName = reader["RazaoSocial"].ToString(),
                            CNPJ = reader["CNPJ"].ToString(),
                            PhoneNumber = reader["Telefone"].ToString(),
                            OpeningDate = Convert.ToDateTime(reader["DataDeAbertura"].ToString()),
                            RegisterDate = Convert.ToDateTime(reader["Data_Cadastro"].ToString()),
                            Note = double.Parse(reader["Nota"].ToString())
                        };
                        return company;
                    }

                    return new Company();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static SqlConnection ConnectionProjetoSENAC()
        {
            return new SqlConnection("Server=DESKTOP-HOOC6CO;Database=projeto_SENAC;Trusted_Connection=True;");
            //return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}
