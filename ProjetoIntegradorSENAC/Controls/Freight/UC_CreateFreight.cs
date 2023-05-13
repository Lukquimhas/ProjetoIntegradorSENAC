using Entitys;
using Sql;
using Sql.Query;

namespace ProjetoIntegradorSENAC.Controls.Freight
{
    public partial class UC_CreateFreight : UserControl
    {
        DataBase db;
        _user userLogged;

        public UC_CreateFreight(string userId)
        {
            InitializeComponent();
            db = new DataBase();
            userLogged = GetLoggedUser(userId);
        }

        private void CreateFreight(string startPoint, string destination, double distance, double value_per_km, string load, string trace, string obs)
        {
            var select = new ScriptSelect();
            var insert = new ScriptInsert();

            try
            {
                var freight = new Freight
                {
                    StartPoint = startPoint,
                    Destination = destination,
                    Distance = distance,
                    ValueKm = value_per_km,
                    Load = load,
                    Trace = trace,
                    Obs = obs,
                    Client = userLogged.IdCompany,
                    Concluded = "Não",
                    CreateDate = DateTime.Now
                };

                var queryGetFreightId = select.ScriptGetFreightId();
                var listId = db.ExecuteSelectQuery(queryGetFreightId);
                freight.IdFreight = listId[0];
                freight.TotalValue = freight.GetTotalValue();

                var queryInsertFreightDB = insert.InsertFreightDB(freight);
                db.ExecuteQuery(queryInsertFreightDB);
                MessageBox.Show("Frete criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private _user GetLoggedUser(string userId)
        {
            var select = new ScriptSelect();

            var query = select.ScriptSelectUserInfo(userId);

            return db.ExecuteUserLoggedSelectQuery(query);
        }

        
    }
}
