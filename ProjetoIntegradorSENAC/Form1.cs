using ProjetoIntegradorSENAC.Login;

namespace ProjetoIntegradorSENAC
{
    public partial class Form1 : Form
    {
        UC_Login tela_login;
        
        public Form1()
        {
            InitializeComponent();
            tela_login = new UC_Login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tela_login.Dock = DockStyle.Fill;
            pn_login.Controls.Add(tela_login);
            tela_login.BringToFront();
        }
    }
}