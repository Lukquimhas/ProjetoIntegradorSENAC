using Entitys;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Sql;
using Sql.Query;
using System.Net;
using System.Configuration;
using System.Globalization;

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

        private void CreateFreight(string startPoint, string destination, double distance, double value_per_km, string load, bool trace, string obs)
        {
            var insert = new ScriptInsert();
            var userCompany = GetUserCompany();

            try
            {
                var freight = new _freight
                {
                    StartPoint = startPoint,
                    Destination = destination,
                    Distance = distance,
                    ValueKm = value_per_km,
                    TotalValue = distance * value_per_km,
                    Load = load,
                    Trace = trace,
                    Obs = obs,
                    Client = userCompany.CorporateName,
                    Concluded = false,
                    CreateDate = DateTime.Now,
                    IdClient = userCompany.CompanyId
                };

                var queryInsertFreightDB = insert.InsertFreightDB(freight);
                db.ExecuteQuery(queryInsertFreightDB);
                MessageBox.Show("Frete criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetComboBoxCity(ComboBox stateComboBox, ComboBox cityComboBox)
        {
            cityComboBox.Enabled = true;
            cityComboBox.Items.Clear();

            var state = stateComboBox.Text;
            var select = new ScriptSelect();
            var query = select.ScriptSelectStateCity(state);

            var db = new DataBase();
            var citys = db.ExecuteGetCity(query, state);

            foreach (var item in citys)
            {
                cityComboBox.Items.Add(item);
            }
        }

        private _user GetLoggedUser(string userId)
        {
            var select = new ScriptSelect();

            var query = select.ScriptSelectUserInfo(userId);

            return db.ExecuteUserLoggedSelectQuery(query);
        }

        private Company GetUserCompany()
        {
            var select = new ScriptSelect();
            var query = select.ScriptSelectEmpresa(userLogged.IdCompany);

            return db.ExecuteGetCompany(query);
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

        private void cb_startingPointStates_TextChanged(object sender, EventArgs e)
        {
            SetComboBoxCity((sender as ComboBox), cb_startingPointCity);
        }

        private void cb_destinationStates_TextChanged(object sender, EventArgs e)
        {
            SetComboBoxCity((sender as ComboBox), cb_destinationCity);
        }

        private void SetDistance(ComboBox comboBox)
        {
            if (comboBox.Enabled == true && comboBox.Text != "--Insira a cidade--")
            {
                var distancia = CalcDistance();
                tb_distance.Text = $"{distancia}Km";
            }
        }

        private void cb_startingPointCity_TextChanged(object sender, EventArgs e)
        {
            SetDistance(cb_destinationCity);
        }

        private void cb_destinationCity_TextChanged(object sender, EventArgs e)
        {
            SetDistance(cb_startingPointCity);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
        }

        private void tb_valuePerKm_TextChanged(object sender, EventArgs e)
        {
            if (tb_distance.Text != "" && tb_valuePerKm.Text != "")
                tb_totalValue.Text = (double.Parse(tb_distance.Text.Replace("Km", "")) * double.Parse(tb_valuePerKm.Text.Replace(",", "."))).ToString("C2", new CultureInfo("pt-BR"));
        }

        private void UC_CreateFreight_Paint(object sender, PaintEventArgs e)
        {
            ValidateFields();
        }

        private void ValidateFields()
        {
            int empty_fields = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Text == "")
                {
                    empty_fields++;
                }
            }

            if (empty_fields == 0)
                btn_createFreight.Enabled = true;
            else
                btn_createFreight.Enabled = false;
        }

        private void btn_createFreight_Click(object sender, EventArgs e)
        {
            bool trace = false;
            if (cb_track.Text == "Sim")
                trace = true;

            CreateFreight(cb_startingPointCity.Text, cb_destinationCity.Text, double.Parse(tb_distance.Text.Replace("Km", "")), double.Parse(tb_valuePerKm.Text), tb_load.Text, trace, tb_obs.Text);
        }
    }
}
