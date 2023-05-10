using ProjetoIntegradorSENAC.Login;

namespace ProjetoIntegradorSENAC
{
    public partial class Form1 : Form
    {
        UC_Login login_screen;
        
        public Form1()
        {
            InitializeComponent();
            login_screen = new UC_Login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddPanel(login_screen);
        }

        private void AddPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pn_login.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}