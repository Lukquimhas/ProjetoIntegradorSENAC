﻿using System;
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
            return "SELECT TOP 1 Id FROM Fretes ORDER BY ID DESC";
        }

        public string ScriptValidateLogin(string username)
        {
            return $"SELECT IdUsuario, username, senha FROM usuarios WHERE username='{username}'";
        }

        public string ScriptGetFreight(string companyId)
        {
            return $"SELECT * FROM Frete WHERE idCliente='{companyId}'";
        }

        public string ScriptSelectUserInfo(string UserId)
        {
            return $"SELECT * FROM usuarios WHERE IdUsuario='{UserId}'";
        }

        public string ScriptSelectStateCity(string state)
        {
            return $"SELECT * FROM cidades WHERE estado='{state}'";
        }

        public string ScriptSelectEmpresa(string companyId)
        {
            return $"SELECT * FROM Empresa WHERE EmpresaId='{companyId}'";
        }
    }
}
