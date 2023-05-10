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
        DataBase db;

        string UserId;
        public UC_Profile(string userId)
        {
            InitializeComponent();

            UserId = userId;
            db = new DataBase();
            userLogged = GetLoggedUser(userId);
        }

        private User GetLoggedUser(string userId)
        {
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

        private void ChangePassword()
        {
            var currentPassword = tb_currentPassword.Text;
            var newPassword = tb_newPassword.Text;
            var confirmPassword = tb_confirmedPassword.Text;

            var update = new ScriptUpdate();
            var query = update.ScriptChangePassword(UserId, newPassword);

            if (VerifyCurrentPassword(currentPassword) && ValidateNewPassword(newPassword, confirmPassword))
            {
                userLogged.Password = newPassword;
                MessageBox.Show("Senha alterada com sucesso!");
                db.ExecuteQuery(query);
                ClearTextBox();
            }
        }

        private bool VerifyCurrentPassword(string password)
        {
            if(password != userLogged.Password)
                return false;
            return true;
        }

        private bool ValidateNewPassword(string password, string confirmedPassword)
        {
            if (password != confirmedPassword || password == "")
                return false;
            return true;
        }


        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void tb_currentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tb_currentPassword.Text != userLogged.Password)
                errorProvider1.SetError(tb_currentPassword, "Senha incorreta");
            else
                errorProvider1.SetError(tb_currentPassword, "");
        }

        private void tb_newPassword_Validating(object sender, CancelEventArgs e)
        {
            var confirmPassword = tb_confirmedPassword.Text;
            ErrorProviderValidatingConfirmPassword((sender as TextBox), confirmPassword);
        }

        private void ErrorProviderValidatingConfirmPassword(TextBox tb, string password)
        {
            if (password != "" && password != tb.Text)
                errorProvider1.SetError(tb, "As duas senhas não coincidem");
            else
                errorProvider1.SetError(tb, "");
        }

        private void tb_confirmedPassword_Validating(object sender, CancelEventArgs e)
        {
            var newPassword = tb_newPassword.Text;
            ErrorProviderValidatingConfirmPassword((sender as TextBox), newPassword);
        }

        private void ClearTextBox()
        {
            tb_currentPassword.Text = "";
            tb_confirmedPassword.Text = "";
            tb_newPassword.Text = "";
        }
    }
}
