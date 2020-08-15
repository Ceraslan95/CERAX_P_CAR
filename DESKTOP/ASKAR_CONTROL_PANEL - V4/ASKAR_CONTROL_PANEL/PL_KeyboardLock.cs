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
    public partial class PL_KeyboardLock : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public PL_KeyboardLock(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_Help);
        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            MainUI.keyBoardLock = true;
            btnOn.BackColor = Color.Lime;
            btnOff.BackColor = Color.Transparent;
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            MainUI.keyBoardLock = false;
            btnOn.BackColor = Color.Transparent;
            btnOff.BackColor = Color.Red;
        }
    }
}
