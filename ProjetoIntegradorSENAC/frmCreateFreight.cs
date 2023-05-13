using Entitys;
using Microsoft.VisualBasic.ApplicationServices;
using ProjetoIntegradorSENAC.Controls.Freight;
using Sql;
using Sql.Query;

namespace ProjetoIntegradorSENAC
{
    public partial class frmCreateFreight : Form
    {
        UC_CreateFreight uc_createFreight;

        public frmCreateFreight(string userId)
        {
            InitializeComponent();
            uc_createFreight = new UC_CreateFreight(userId);
        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {
            ChangePanel(uc_createFreight);
        }

        private void ChangePanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pn_main.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
