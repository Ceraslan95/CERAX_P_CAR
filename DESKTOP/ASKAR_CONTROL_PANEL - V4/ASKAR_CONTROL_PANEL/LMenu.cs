using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ASKAR_CONTROL_PANEL.ASKAR_UI_FORM;

namespace ASKAR_CONTROL_PANEL
{
    public partial class LMenu : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public LMenu(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnConnectionSettings_Click(object sender, EventArgs e)
        {
            
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_ComSettingsMenu);
        }

        private void BtnExitPage_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_Exit);
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_Help);
        }

        private void BtnTechSettings_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_TechSettings);
        }
    }
}
