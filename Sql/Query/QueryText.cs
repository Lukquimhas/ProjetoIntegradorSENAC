using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Query
{
    internal class QueryText
    {
        public QueryText() { }

        public string SelectLoginUserInfo(string username)
        {
            return $"SELECT IdUsuario, username, senha FROM usuarios WHERE usuario={username}";
        }
    }
}
