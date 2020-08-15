using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASKAR_CONTROL_PANEL
{
    public partial class WelcomeStart : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public WelcomeStart(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
            
        }

        internal void LoadWC()
        {
           
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            MainUI.panelMainTopEdge.Controls.Remove(MainUI.welcomeStart);
            count = MainUI.panelMainTopEdge.Height;
          
            timer1.Start();
        }
        int count;
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (MainUI.panelMainTopEdge.Height <= 40)
            {
                MainUI.panelMainTopEdge.Height = 40;
                MainUI.panelMiddleArea.Visible = true;
                MainUI.panelBottomArea.Visible = true;
                timer1.Stop();
            }
            else
            {
                count = count - 20;
                MainUI.panelMainTopEdge.Height = count;
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if(txtBxID.Text=="38539001458" && txtBxPassword.Text == "38539001458")
            {
                btnEnter.BackColor = Color.Lime;
                btnEnter.Text = "Başarılı";
                buttonStart.Visible = true;
            }
            else
            {
                btnEnter.BackColor = Color.Red;
                btnEnter.Text = "Başarısız";
                buttonStart.Visible = false;
            }
        }


       
    }
}
