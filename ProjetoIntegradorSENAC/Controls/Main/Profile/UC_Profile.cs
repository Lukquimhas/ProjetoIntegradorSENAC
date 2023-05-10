using Sql;
using Sql.Query;
using Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Controls.Main.Profile
{
    public partial class UC_Profile : UserControl
    {
        User userLogged;

        string UserId;
        public UC_Profile(string userId)
        {
            InitializeComponent();

            UserId = userId;
            userLogged = GetLoggedUser(userId);
        }

        private User GetLoggedUser(string userId)
        {
            var db = new DataBase();
            var select = new ScriptSelect();

            var query = select.ScriptSelectUserInfo(userId);

            return db.ExecuteUserLoggedSelectQuery(query);
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            SetUserInfo();
        }

        private void SetUserInfo()
        {
            lbl_Name.Text = userLogged.Name;
            lbl_Email.Text = userLogged.Email;
            lbl_Username.Text = userLogged.Username;
        }
    }
}
