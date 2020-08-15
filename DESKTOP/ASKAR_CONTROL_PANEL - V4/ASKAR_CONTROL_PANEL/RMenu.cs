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
    public partial class RMenu : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public RMenu(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnGraphs_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_Graphs);
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_Map);
            MainUI.DashBoardPagesVisible(PageAddress.B, Pages.PB_MapArea);

        }

        private void BtnMediaPlayer_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_MediaPlayer);
        }

        private void BtnInternet_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_Internet);
            MainUI.DashBoardPagesVisible(PageAddress.B, Pages.PB_Internet);
        }
    }
}
