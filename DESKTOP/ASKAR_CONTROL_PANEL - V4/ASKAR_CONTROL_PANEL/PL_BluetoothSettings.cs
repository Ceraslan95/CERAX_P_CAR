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
    public partial class PL_BluetoothSettings : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public PL_BluetoothSettings(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.L, Pages.PL_ComSettingsMenu);
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Ortam Taranıyor...";
            DisabledAllButtons();

            MainUI.scanWorker.RunWorkerAsync();
        }

        private void DisabledAllButtons()
        {
            
            btnScan.Visible = false;
            btnConnect.Visible = false;
            btnDisconnect.Visible = false;
           
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Bağlanıyor...";
            DisabledAllButtons();

            MainUI.connectionWorker.RunWorkerAsync();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Bağlantı Koparıldı.";
            MainUI.BT_Disconnect();

            DisabledAllButtons();

            btnScan.Visible = true;
            btnConnect.Visible = true;
            MainUI.icoBluetooth.BackgroundImage=null;
        }

       
    }
}
