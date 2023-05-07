using Microsoft.Data.SqlClient;
using Sql.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql
{
    public class DataBase
    {
        static QueryText qt = new QueryText();
        public DataBase(){ }

        public static object ExecuteSqlCommand(string query)
        {
            using(var conn = ConnectionProjetoSENAC())
            {
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandText = query
                };

                return command.ExecuteNonQuery();
            }
        }

        public static List<string> UserInfo(string username)
        {
            var userinfos = new List<string>();

            using (var conn = ConnectionProjetoSENAC())
            {
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandText = qt.SelectLoginUserInfo(username)
                };
                conn.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    userinfos.Add(reader.ToString());
                }
            }

            return userinfos;
        }

        public static SqlConnection ConnectionProjetoSENAC()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}
