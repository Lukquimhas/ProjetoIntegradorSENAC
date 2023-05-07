using System.Data.SqlClient;
using Sql;


namespace Control.Login
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
    }
}
