using ProjetoIntegradorSENAC.Controls.Freight;
using ProjetoIntegradorSENAC.Controls.Main.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC
{
    public partial class frmMain : Form
    {
        UC_Home uc_home;
        UC_FreightDataGrid uc_freight;

        public frmMain()
        {
            InitializeComponent();
            uc_home = new UC_Home();
            uc_freight = new UC_FreightDataGrid();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ChangePage(uc_home);
        }

        private void btn_Freight_Click(object sender, EventArgs e)
        {
            ChangeLeftPanelIcon((sender as Button), 5);
            ChangePage(uc_freight);

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            ChangeLeftPanelIcon((sender as Button), 1);
        }

        private void ChangeLeftPanelIcon(Button button, int imageIndex)
        {
            foreach (Button btn in pn_Left.Controls)
            {
                if (btn.ImageIndex % 2 != 0 && btn.ImageIndex > 0)
                    btn.ImageIndex = btn.ImageIndex - 1;
            }

            button.ImageIndex = imageIndex;
        }

        private void ChangePage(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pn_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ChangeLeftPanelIcon((sender as Button), 3);
        }
    }
}
