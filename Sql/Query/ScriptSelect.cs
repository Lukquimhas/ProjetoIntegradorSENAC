using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Query
{
    public class ScriptSelect
    {
        public string ScriptGetFreightId()
        {
            return "SELECT TOP 1 id FROM fretes ORDER BY ID DESC";
        }

        public string ScriptValidateLogin(string username)
        {
            return $"SELECT IdUsuario, username, senha FROM usuarios WHERE username='{username}'";
        }

        public string ScriptGetFreight()
        {
            return $"SELECT * FROM fretes";
        }

        public string ScriptSelectUserInfo(string UserId)
        {
            return $"SELECT * FROM usuarios WHERE IdUsuario='{UserId}'";
        }
    }
}
