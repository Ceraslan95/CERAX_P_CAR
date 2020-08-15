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
    public partial class PR_Graphs : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public PR_Graphs(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.RMenu);
        }

        private void BtnBatteryGraph_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_GraphBattery);
            MainUI.DashBoardPagesVisible(PageAddress.B, Pages.PB_BatteryArea);
        }

        private void BtnLandSlopeGraph_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_GraphLandSlope);
        }

        private void BtnParkSensorGraph_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_GraphParkSensor);
        }

        private void BtnRpmGraph_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_GraphRpm);
        }

        private void BtnTempStateGraph_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_GraphTempState);
            MainUI.DashBoardPagesVisible(PageAddress.B, Pages.PB_TempArea);
        }
    }
}
