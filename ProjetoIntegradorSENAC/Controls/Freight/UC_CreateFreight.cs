using Entitys;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Sql;
using Sql.Query;
using System.Net;
using System.Configuration;

namespace ProjetoIntegradorSENAC.Controls.Freight
{
    public partial class UC_CreateFreight : UserControl
    {
        DataBase db;
        _user userLogged;
        private readonly string api_key = ConfigurationManager.AppSettings["ApiKey"];

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
                var freight = new _freight
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

        private double CalcDistance()
        {
            string[] startingPoint = cb_startingPointCity.Text.Trim().Split("-");
            string[] Destination = cb_destinationCity.Text.Trim().Split("-");

            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={startingPoint[0]}|{startingPoint[1]}&destinations={Destination[0]}|{Destination[1]}&key={api_key}";
            string url2 = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={startingPoint[1]}%{startingPoint[0]}&destinations={Destination[1]}%{Destination[0]}&key={api_key}";

            try
            {
                var distanceNode = RequestAPI(url);
                if (distanceNode != null && distanceNode.Type == JTokenType.Object)
                {
                    var distance = distanceNode["text"].ToObject<string>().Replace("km", "").Trim();
                    return double.Parse(distance);
                }
                else if (distanceNode == null)
                {
                    distanceNode = RequestAPI(url2);
                    var distance = distanceNode["text"].ToObject<string>().Replace("km", "").Trim();
                    return double.Parse(distance);
                }
                else
                {
                    MessageBox.Show("Erro ao tentar encontrar a cidade, por favor contate o suporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar encontrar a cidade, por favor contate o suporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        private JToken RequestAPI(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);

            string responseFromServer = reader.ReadToEnd();
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(responseFromServer);

            JToken distanceNode = jsonObject.SelectToken("rows[0].elements[0].distance");

            return distanceNode;
        }
    }
}
