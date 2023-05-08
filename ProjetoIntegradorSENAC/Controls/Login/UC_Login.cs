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

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar)
            {
                tb_password.UseSystemPasswordChar = false;
                (sender as Button).ImageIndex = 1;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
                (sender as Button).ImageIndex = 0;
            }
        }

        private void ValidadeLogin(string username, string password)
        {
            try
            {
                DataBase db = new DataBase();
                ScriptSelect script = new ScriptSelect();

                string query = script.ScriptValidateLogin(username);
                var userInfo = db.ExecuteSelectQuery(query);

                if (userInfo.Contains(username) && userInfo.Contains(password))
                    ShowMainForm();
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

        private void ShowMainForm()
        {
            frmMain _frmMain = new frmMain();
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
    }
}
