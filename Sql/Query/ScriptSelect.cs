using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Query
{
    public class ScriptSelect
    {
        public string ScriptValidateLogin(string username)
        {
            return $"SELECT IdUsuario, username, senha FROM usuarios WHERE username='{username}'";
        }

        public string ScriptGetFreight()
        {
            return $"SELECT * FROM fretes";
        }
    }
}
