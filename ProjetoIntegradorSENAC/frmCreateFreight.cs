using Entitys;
using Microsoft.VisualBasic.ApplicationServices;
using Sql;
using Sql.Query;

namespace ProjetoIntegradorSENAC
{
    public partial class frmCreateFreight : Form
    {
        DataBase db;

        _user userLogged;


        public frmCreateFreight(string userId)
        {
            InitializeComponent();
            db = new DataBase();
            userLogged = GetLoggedUser(userId);
        }

        private void CreateFreight(string startPoint, string destination, double distance, double value_per_km, string load, string trace, string obs)
        {
            var select = new ScriptSelect();
            var query = select.ScriptGetFreightId();
            try
            {
                var freight = new Freight
                {
                    From = startPoint,
                    To = destination,
                    Distance = distance,
                    ValueKm = value_per_km,
                    Load = load,
                    Trace = trace,
                    Obs = obs,
                    Client = userLogged.IdCompany,
                    Concluded = "Não",
                    CreateDate = DateTime.Now
                };

                var listId = db.ExecuteSelectQuery(query);
                freight.IdFreight = listId[0];
                freight.TotalValue = freight.GetTotalValue();

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
