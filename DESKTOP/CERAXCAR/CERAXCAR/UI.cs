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
using static CERAXCAR.Concrete.Engine.Motor;


namespace CERAXCAR
{
    public partial class UI : Form
    {
       
        HandBreak handBreak;
        Motor motor;
        private bool motorlock = false;
        private bool nitrolock = false;
        private bool abslock = false;
        public UI()
        {          
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            motor = new Motor(this);
            
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
                    {
                        if (!nitrolock)
                        {
                            nitrolock = true;
                            motor.SetNitroValue(true);
                        }
                    }
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
                        if (motor.GetGearValue() == Gears.Zero)
                        {
                            motor.SetGearValue(Gears.R);
                        }
                    }
                    break;
                //case Keys.G:
                //    { pSecurity.Visible = !pSecurity.Visible; }
                //    break;
               
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
                            motor.SetGearValue(Gears.Zero);
                        }
                    }
                    break;
                case Keys.Space:
                    {   
                        if (!abslock)                         
                        {
                            abslock = true;
                            motor.SetCruiseValue(false);
                            motor.SetAbsValue(true);
                        }
                    
                    }
                    break;
                case Keys.NumPad5:
                    { pHorn.Visible = true; }
                    break;
               
                case Keys.W:
                    {
                        if (!motorlock) 
                        {
                            motorlock = true;
                            motor.SetCruiseValue(false);
                            motor.SpeedUp();
                            Console.WriteLine("speed up");
                        }                       
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
                    { nitrolock = false; motor.SetNitroValue(false); }
                    break;
                case Keys.Space:
                    { abslock = false; motor.SetAbsValue(false); }
                    break;
                case Keys.NumPad5:
                    { pHorn.Visible = false; }
                    break;
                case Keys.W:
                    { motorlock = false; motor.SpeedDown(); Console.WriteLine("speed down"); }
                    break;
                case Keys.M:
                    {
                        if (motor.GetTurboValue())
                        {
                            motor.SetTurboValue(false);
                        }
                        else
                        {
                            motor.SetTurboValue(true);
                        }
                    }
                    break;
                case Keys.H:
                    {
                        if (motor.GetCruiseValue())
                        {
                            motor.SetCruiseValue(false);
                        }
                        else
                        {
                            motor.SetCruiseValue(true);
                        }
                            
                    }
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
