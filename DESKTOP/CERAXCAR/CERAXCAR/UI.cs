using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERAXCAR
{
    public partial class UI : Form
    {
        Motor motor; 
        public UI()
        {          
            InitializeComponent();
            motor = new Motor(this);
        }

        private void UI_Load(object sender, EventArgs e)
        {
            
        }

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    { this.Close(); }
                    break;
                case Keys.T:
                    { pTopLed.Visible = !pTopLed.Visible; }
                    break;
                case Keys.Y:
                    { pShortLed.Visible = !pShortLed.Visible; }
                    break;
                case Keys.U:
                    { pLongLed.Visible = !pLongLed.Visible; }
                    break;
                case Keys.I:
                    { pFog.Visible = !pFog.Visible; }
                    break;
                case Keys.O:
                    { pTarget.Visible = !pTarget.Visible; }
                    break;
                case Keys.J:
                    { pLongLed.Visible = true; }
                    break;
                case Keys.NumPad8:
                    { pNitro.Visible = true; }
                    break;
                case Keys.E:
                    { pRightSignal.Visible = !pRightSignal.Visible; }
                    break;
                case Keys.Q:
                    { pLeftSignal.Visible = !pLeftSignal.Visible; }
                    break;
                case Keys.F:
                    { pFourAlert.Visible = !pFourAlert.Visible; }
                    break;
                case Keys.R:
                    { 
                        if (motor.GetGearStatus()=="0")
                        {
                            motor.SetGearStatus("R");
                            KMUI.GaugeLabels.FindByName("lblGearBox").Text = "R";
                        }
                        else if (motor.GetGearStatus() == "R")
                        {
                            motor.SetGearStatus("0");
                            KMUI.GaugeLabels.FindByName("lblGearBox").Text = "0";
                        }
                    }
                    break;
                //case Keys.G:
                //    { pSecurity.Visible = !pSecurity.Visible; }
                //    break;
                case Keys.H:
                    { pCruise.Visible = !pCruise.Visible; }
                    break;
                case Keys.B:
                    { pHandBreak.Visible = !pHandBreak.Visible;
                        if (pHandBreak.Visible)
                        {
                            KMUI.GaugeLabels.FindByName("lblGearBox").Text = "0";
                        }                      
                    }
                    break;
                //case Keys.V:
                //    { pESP.Visible = !pESP.Visible; }
                //    break;
                case Keys.Space:
                    { pABS.Visible = true; }
                    break;
                case Keys.NumPad5:
                    { pHorn.Visible = true; }
                    break;
               
            }
        }

        private void UI_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.J:
                    { pLongLed.Visible = false; }
                    break;
                case Keys.NumPad8:
                    { pNitro.Visible = false; }
                    break;
                case Keys.Space:
                    { pABS.Visible = false; }
                    break;
                case Keys.NumPad5:
                    { pHorn.Visible = false; }
                    break;
            }
        }
    }
}
