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
        Bluetooth bluetooth;
        private bool motorlock = false;
        private bool nitrolock = false;
        private bool abslock = false;
        private bool hornlock = false;
        private bool longlock = false;

        private bool rightlock = false;
        private bool leftlock = false;

        public UI()
        {          
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            motor = new Motor(this);
            handBreak = new HandBreak(this);
            bluetooth = new Bluetooth(this);

        }

        private void UI_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Lütfen Bekleyiniz !";
        }

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            

            switch (e.KeyCode)
            {                              
                case Keys.N:
                    {
                        if (!nitrolock)
                        {
                            nitrolock = true;
                            motor.SetNitroValue(true);
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
                case Keys.H:
                    {
                        if (!hornlock)
                        {
                            hornlock = true;
                            pHorn.Visible = true;
                        }
                        
                    }
                    break;              
                case Keys.W:
                    {
                        if (!handBreak.GetStatus())
                        {
                            if (!motorlock)
                            {
                                motorlock = true;
                                motor.SetCruiseValue(false);
                                motor.SpeedUp();                               
                            }
                        }
                                       
                    }
                    break;
                case Keys.J:
                    {
                        if (!longlock)
                        {
                            longlock = true;
                            pLongLed.Visible = true;
                        }
                        
                    }
                    break;
                case Keys.A:
                    {
                        if (!leftlock)
                        {
                            leftlock = true;
                            rightlock = true;
                            motor.SetDirectionStatus(Direction.Left);
                        }
                    }
                    break;
                case Keys.D:
                    {
                        if (!rightlock)
                        {
                            rightlock = true;
                            leftlock = true;
                            motor.SetDirectionStatus(Direction.Right);
                        }
                    }
                    break;

            }
        }

        private void UI_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.G:
                    { pSecurity.Visible = !pSecurity.Visible; }
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
                            motor.SetGearValue(Gears.Zero);
                        }
                    }
                    break;
                case Keys.Escape:
                    {
                        if (MessageBox.Show("Kontrol paneli kapatılsın mı?", "CERAX CAR SYSTEM",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    break;
                case Keys.E:
                    {
                        if (timerRightSignal.Enabled)
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
                case Keys.J:
                    { longlock = false; pLongLed.Visible = false; }
                    break;
                case Keys.N:
                    { nitrolock = false; motor.SetNitroValue(false); }
                    break;
                case Keys.Space:
                    { abslock = false; motor.SetAbsValue(false); }
                    break;
                case Keys.H:
                    { hornlock = false; pHorn.Visible = false; }
                    break;
                case Keys.W:
                    { motorlock = false; motor.SpeedDown(); }
                    break;
                case Keys.T:
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
                case Keys.C:
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
                case Keys.Y:
                    { pTopLed.Visible = !pTopLed.Visible; }
                    break;
                case Keys.I:
                    { pShortLed.Visible = !pShortLed.Visible; }
                    break;
                case Keys.U:
                    { pLongLed.Visible = !pLongLed.Visible; }
                    break;
                case Keys.O:
                    { pFog.Visible = !pFog.Visible; }
                    break;
                case Keys.P:
                    { pTarget.Visible = !pTarget.Visible; }
                    break;
                case Keys.Z:
                    {
                        pESP.Visible = !pESP.Visible;
                    }
                    break;
                case Keys.K:
                    {
                        bluetooth.StartConnection();
                    }
                    break;
                case Keys.A:
                    {
                        leftlock = false;
                        rightlock = false;
                        motor.SetDirectionStatus(Direction.Middle);
                    }
                    break;
                case Keys.D:
                    {
                        rightlock = false;
                        leftlock = false;
                        motor.SetDirectionStatus(Direction.Middle);
                    }
                    break;
            }
        }



        //Signals
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
            lblInfo.Text = "";
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




        //Bluetooth

        private void KMUI_ValueChanged(object sender, EventArgs e)
        {
            bluetooth.SendKM((int)KMUI.Value);
        }


    }
}
