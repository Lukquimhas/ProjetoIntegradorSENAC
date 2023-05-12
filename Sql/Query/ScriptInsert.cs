using Entitys;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.Query
{
    public class ScriptInsert
    {
        public string InsertFreightDB(Freight freight)
        {
            string query = $"INSERT INTO fretes VALUES ({freight.IdFreight}, '{freight.StartPoint}', '{freight.Destination}', {freight.Distance}, {freight.ValueKm}, {freight.TotalValue}," +
                        $" '{freight.Load}', '{freight.Trace}', '{freight.Obs}', 'NULL', '{freight.Client}', '{freight.Concluded}', '{freight.CreateDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}')";
            return query;
        }
    }
}
