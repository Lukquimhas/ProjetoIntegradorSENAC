using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Query
{
    public class ScriptUpdate
    {
        public string ScriptChangePassword(string userId, string newPassword)
        {
            return $"UPDATE usuarios " +
                $"SET senha='{newPassword}' " +
                $"WHERE IdUsuario='{userId}'"; 
        }
    }
}
