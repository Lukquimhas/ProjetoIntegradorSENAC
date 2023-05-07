using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
