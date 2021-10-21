using CERAXCAR.Concrete;
using CERAXCAR.Concrete.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CERAXCAR.GearBox;

namespace CERAXCAR
{
    public partial class UI : Form
    {
        GearBox gearBox;
        HandBreak handBreak;
        Motor motor;
        public UI()
        {          
            InitializeComponent();
            motor = new Motor(this);
            gearBox = new GearBox(this);
            handBreak = new HandBreak(this);
        }

        private void UI_Load(object sender, EventArgs e)
        {
            
        }

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        if (MessageBox.Show("Kontrol paneli kapatılsın mı?", "CERAX CAR SYSTEM",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            this.Close();                          
                        }
                    }
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
                    {
                        if(timerRightSignal.Enabled)
                        {
                            StopRightSignal();
                        }
                        else
                        {
                            StartRightSignal();
                        }
                    
                    }
                    break;
                case Keys.Q:
                    {
                        if (timerLeftSignal.Enabled)
                        {
                            StopLeftSignal();
                        }
                        else
                        {
                            StartLeftSignal();
                        }
                    }
                    break;
                case Keys.F:
                    {                                             
                        pFourAlert.Visible = !pFourAlert.Visible;
                        if (Timer4Signal.Enabled)
                        {
                            Stop4Signal();
                        }
                        else
                        {
                            Start4Signal();
                        }
                    
                    }
                    break;
                case Keys.R:
                    {
                        if (gearBox.GetGearValue() == Gears.Zero)
                        {
                            gearBox.SetGearValue(Gears.R);
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
                    { 
                        if (!motor.GetGoStatus())
                        {
                            if (!handBreak.GetStatus())
                            {
                                handBreak.SetStatus(true);
                            }
                            else
                            {
                                handBreak.SetStatus(false);
                            }
                        }
                                            
                    }
                    break;
                case Keys.V:
                    {
                        if (!motor.GetGoStatus())
                        {
                            gearBox.SetGearValue(Gears.Zero);
                        }
                    }
                    break;
                case Keys.Space:
                    { pABS.Visible = true; }
                    break;
                case Keys.NumPad5:
                    { pHorn.Visible = true; }
                    break;
                case Keys.M:
                    { pTurbo.Visible = !pTurbo.Visible; }
                    break;
                case Keys.W:
                    {
                        Console.WriteLine("w");
                    }
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


        public void Start4Signal()
        {
            if (timerRightSignal.Enabled) StopRightSignal();
            if (timerLeftSignal.Enabled) StopLeftSignal();
            pRightSignal.Visible = false;
            pLeftSignal.Visible = false;
           
            Timer4Signal.Start();
        }

        public void Stop4Signal()
        {
            Timer4Signal.Stop();
            pRightSignal.Visible = false;
            pLeftSignal.Visible = false;
                      
        }

        public void StartRightSignal()
        {
            if (!Timer4Signal.Enabled)
            {
                if (timerLeftSignal.Enabled) { StopLeftSignal(); }
                timerRightSignal.Start();
            }
            
        }

        public void StopRightSignal()
        {
            timerRightSignal.Stop();
            pRightSignal.Visible = false;
            
        }

        public void StartLeftSignal()
        {
            if (!Timer4Signal.Enabled)
            {
                if (timerRightSignal.Enabled) { StopRightSignal(); }
                timerLeftSignal.Start();
            }

        }

        public void StopLeftSignal()
        {
            timerLeftSignal.Stop();
            pLeftSignal.Visible = false;
        }

        //UI Timers 


        private void Timer4Signal_Tick(object sender, EventArgs e)
        {
            pRightSignal.Visible = !pRightSignal.Visible;
            pLeftSignal.Visible = !pLeftSignal.Visible;
        }

        private void timerInit_Tick(object sender, EventArgs e)
        {
            pLeftSignal.Visible = false;
            pRightSignal.Visible = false;
            pFourAlert.Visible = false;
            pShortLed.Visible = false;
            pLongLed.Visible = false;
            pFog.Visible = false;
            pBluetooth.Visible = false;
            pABS.Visible = false;
            pBattery.Visible = false;
            pCruise.Visible = false;
            pEngine.Visible = false;
            pESP.Visible = false;
            pHighTemp.Visible = false;
            pOil.Visible = false;
            pNitro.Visible = false;
            pHorn.Visible = false;
            pSecurity.Visible = false;
            pTurbo.Visible = false;
            pTopLed.Visible = false;
            pTarget.Visible = false;

            timerInit.Stop();
        }

        private void timerRightSignal_Tick(object sender, EventArgs e)
        {
            pRightSignal.Visible = !pRightSignal.Visible;
        }

        private void timerLeftSignal_Tick(object sender, EventArgs e)
        {
            pLeftSignal.Visible = !pLeftSignal.Visible;
        }

        
    }
}
