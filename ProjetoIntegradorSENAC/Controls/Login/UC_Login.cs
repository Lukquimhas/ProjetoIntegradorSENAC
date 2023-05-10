using System.Data.SqlClient;
using Sql;
using Sql.Query;


namespace ProjetoIntegradorSENAC.Login
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }


        private void ShowOrHidePassword(Button btn)
        {
            if (tb_password.UseSystemPasswordChar)
            {
                tb_password.UseSystemPasswordChar = false;
                btn.ImageIndex = 1;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
                btn.ImageIndex = 0;
            }
        }

        private void ValidadeLogin(string username, string password)
        {
            try
            {
                var db = new DataBase();
                var script = new ScriptSelect();

                var query = script.ScriptValidateLogin(username);
                var userInfo = db.ExecuteSelectQuery(query);

                if (userInfo.Contains(username) && userInfo.Contains(password))
                    ShowMainForm(userInfo[0]);
                else if (userInfo.Count > 0)
                    MessageBox.Show("A senha digitada está incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Usuário não cadastrado, tente novamente ou contate o suporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowMainForm(string userId)
        {
            var _frmMain = new frmMain(userId);
            _frmMain.Show();
            this.FindForm().Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            VerifyLoginWhiteSpace();
        }

        private void VerifyLoginWhiteSpace()
        {
            if (tb_username.Text != "" && tb_password.Text != "")
                ValidadeLogin(tb_username.Text, tb_password.Text);
            else
                MessageBox.Show("Por favor preencha todos os campos");
        }

        private void btn_showPassword_MouseHover(object sender, EventArgs e)
        {
            ShowOrHidePassword((sender as Button));
        }

        private void btn_showPassword_MouseLeave(object sender, EventArgs e)
        {
            ShowOrHidePassword((sender as Button));
        }
    }
}
