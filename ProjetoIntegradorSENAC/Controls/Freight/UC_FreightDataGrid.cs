﻿using Entitys;
using Sql;
using Sql.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Controls.Freight
{
    public partial class UC_FreightDataGrid : UserControl
    {
        string UserId;

        DataBase db;
        _user UserLogged;

        public UC_FreightDataGrid(string userId)
        {
            InitializeComponent();
            UserId = userId;

            db = new DataBase();
            UserLogged = GetLoggedUser(userId);
        }

        private void AddFreightDataGrid()
        {
            var ss = new ScriptSelect();

            var query = ss.ScriptGetFreight(UserLogged.IdCompany);
            var freights = db.ExecuteFreightSelectQuery(query);

            foreach(var freight in freights)
            {
                dgv_Freight.Rows.Add(freight.ToString().Split(";"));

                /*dgv_Freight.Rows.Add(freight.IdFreight, freight.From, freight.To, freight.Distance + "Km", 
                    freight.ValueKm.ToString("C2", new CultureInfo("pt-BR")), 
                    freight.TotalValue.ToString("C2", new CultureInfo("pt-BR")), 
                    freight.Load, freight.Trace, freight.Obs, freight.Driver, freight.Client, freight.Concluded);*/
            }
        }

        private void UC_FreightDataGrid_Load(object sender, EventArgs e)
        {
            AddFreightDataGrid();
        }

        private void btn_createFreight_Click(object sender, EventArgs e)
        {
            var frmcreateFreight = new frmCreateFreight(UserId);
            frmcreateFreight.Show();
        }

        private _user GetLoggedUser(string userId)
        {
            var select = new ScriptSelect();
            var query = select.ScriptSelectUserInfo(userId);

            return db.ExecuteUserLoggedSelectQuery(query);
        }
    }
}
