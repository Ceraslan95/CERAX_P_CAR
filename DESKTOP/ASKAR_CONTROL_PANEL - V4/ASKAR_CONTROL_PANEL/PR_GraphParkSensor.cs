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
    public partial class PR_GraphParkSensor : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public PR_GraphParkSensor(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_Graphs);
        }
    }
}
