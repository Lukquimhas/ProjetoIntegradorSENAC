using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controls.Login
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_password.UseSystemPasswordChar)
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

        private string ValidateLogin(string username, string password)
        {
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    var command = new SqlCommand
                    {
                        Connection = conn,
                        CommandText = $"SELECT IdUsuario, username, senha FROM usuarios WHERE username='{username}'"
                    };
                    conn.Open();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (username == reader["username"].ToString() && password == reader["senha"].ToString())
                            return reader["IdUsuario"].ToString();
                        else
                            MessageBox.Show("A senha digitada está incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "";
        }
    }
}
