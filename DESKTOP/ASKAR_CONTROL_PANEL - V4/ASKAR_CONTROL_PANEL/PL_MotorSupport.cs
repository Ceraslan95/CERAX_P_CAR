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
    public partial class PL_MotorSupport : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public PL_MotorSupport(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnCarTurbo_Click(object sender, EventArgs e)
        {
            if (MainUI.MotorTurbo == false)
            {
                btnCarTurbo.BackColor = Color.Lime;
                MainUI.MotorTurbo = true;
            }
            else
            {
                btnCarTurbo.BackColor = Color.Red;
                MainUI.MotorTurbo = false;
            }
        }

        private void BtnCarNitro_Click(object sender, EventArgs e)
        {
            if (MainUI.MotorNitro == false)
            {
                btnCarNitro.BackColor = Color.Lime;
                MainUI.MotorNitro = true;
            }
            else
            {
                btnCarNitro.BackColor = Color.Red;
                MainUI.MotorNitro = false;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_TechSettings);
        }
    }
}
