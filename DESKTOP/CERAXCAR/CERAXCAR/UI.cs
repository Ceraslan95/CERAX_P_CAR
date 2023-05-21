using CERAXCAR.Concrete;
using CERAXCAR.Concrete.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private bool keyboardlock = true;

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

            //FileStream fs = new FileStream("C:\\Users\\er_as\\Documents\\GitHub\\CERAX_P_CAR\\DESKTOP\\CERAXCAR\\KM.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            //StreamReader sr = new StreamReader(fs);
            //UInt64 km = Convert.ToUInt64(sr.ReadLine());
            //bluetooth.SetKM(km);
            //sr.Close();
        }

        private void UI_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboardlock)
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
                                bluetooth.SendLedAbs(motor.GetAbsValue());
                            }

                        }
                        break;
                    case Keys.H:
                        {
                            if (!hornlock)
                            {
                                hornlock = true;
                                pHorn.Visible = true;
                                bluetooth.SendHorn(pHorn.Visible);
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
                                bluetooth.SendLedLong(pLongLed.Visible);
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

           
        }

        private void UI_KeyUp(object sender, KeyEventArgs e)
        {
            if (!keyboardlock)
            {
                switch (e.KeyCode)
                {
                    case Keys.G:
                        {
                            pSecurity.Visible = !pSecurity.Visible;
                            bluetooth.SendSecurity(pSecurity.Visible);
                        }
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
                                bluetooth.SendLedAbs(handBreak.GetStatus());
                            }

                        }
                        break;
                    case Keys.V:
                        {
                            if (!motor.GetGoStatus())
                            {
                                motor.SetGoingDirection(true);
                                motor.SetGearValue(Gears.Zero);
                                bluetooth.SendLedR(false);
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
                                motor.SetGoingDirection(false);
                                motor.SetGearValue(Gears.R);
                                bluetooth.SendLedR(true);
                            }
                        }
                        break;
                    case Keys.J:
                        {
                            longlock = false;
                            pLongLed.Visible = false;
                            bluetooth.SendLedLong(pLongLed.Visible);
                        }
                        break;
                    case Keys.N:
                        {
                            nitrolock = false;
                            motor.SetNitroValue(false);
                        }
                        break;
                    case Keys.Space:
                        {
                            abslock = false;
                            motor.SetAbsValue(false);
                            bluetooth.SendLedAbs(motor.GetAbsValue());
                        }
                        break;
                    case Keys.H:
                        {
                            hornlock = false;
                            pHorn.Visible = false;
                            bluetooth.SendHorn(pHorn.Visible);
                        }
                        break;
                    case Keys.W:
                        {
                            motorlock = false;
                            motor.SpeedDown();
                        }
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
                        {
                            pTopLed.Visible = !pTopLed.Visible;
                            bluetooth.SendLedTop(pTopLed.Visible);
                        }
                        break;
                    case Keys.I:
                        {
                            pShortLed.Visible = !pShortLed.Visible;
                            bluetooth.SendLedShort(pShortLed.Visible);
                        }
                        break;
                    case Keys.U:
                        {
                            pLongLed.Visible = !pLongLed.Visible;
                            bluetooth.SendLedLong(pLongLed.Visible);
                        }
                        break;
                    case Keys.O:
                        {
                            pFog.Visible = !pFog.Visible;
                            bluetooth.SendLedFog(pFog.Visible);
                        }
                        break;
                    case Keys.P:
                        {
                            pTarget.Visible = !pTarget.Visible;
                            bluetooth.SendLedPoint(pTarget.Visible);
                        }
                        break;
                    case Keys.Z:
                        {
                            if (motor.GetEspValue())
                            {
                                motor.SetEspValue(false);
                            }
                            else
                            {
                                motor.SetEspValue(true);
                            }
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
            bluetooth.SendSignalRight(pRightSignal.Visible);
            pLeftSignal.Visible = false;
            bluetooth.SendSignalLeft(pLeftSignal.Visible);
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
            bluetooth.SendSignalRight(pRightSignal.Visible);

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
            bluetooth.SendSignalLeft(pLeftSignal.Visible);
        }

        //UI Timers 

        private void Timer4Signal_Tick(object sender, EventArgs e)
        {
            pRightSignal.Visible = !pRightSignal.Visible;
            bluetooth.SendSignalRight(pRightSignal.Visible);
            pLeftSignal.Visible = !pLeftSignal.Visible;
            bluetooth.SendSignalLeft(pLeftSignal.Visible);
        }

        private void timerInit_Tick(object sender, EventArgs e)
        {
            ResetInit();
            keyboardlock = false;
            lblInfo.Text = "";
            bluetooth.StartConnection();
            timerInit.Stop();
            
        }

        public void ResetInit()
        {
            pLeftSignal.Visible = false;
            //bluetooth.SendSignalLeft(pLeftSignal.Visible);
            pRightSignal.Visible = false;
            //bluetooth.SendSignalRight(pRightSignal.Visible);
            pFourAlert.Visible = false;
            pShortLed.Visible = false;
            //bluetooth.SendLedShort(pShortLed.Visible);
            pLongLed.Visible = false;
            //bluetooth.SendLedLong(pLongLed.Visible);
            pFog.Visible = false;
            //bluetooth.SendLedFog(pFog.Visible);
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
            //bluetooth.SendHorn(pHorn.Visible);
            pSecurity.Visible = false;
            //bluetooth.SendSecurity(pSecurity.Visible);
            pTurbo.Visible = false;
            pTopLed.Visible = false;
            //bluetooth.SendLedTop(pTopLed.Visible);
            pTarget.Visible = false;
            //bluetooth.SendLedPoint(pTarget.Visible);
            pHandBreak.Visible = true;
            //bluetooth.SendLedAbs(pHandBreak.Visible);
        }

       

        private void timerRightSignal_Tick(object sender, EventArgs e)
        {
            pRightSignal.Visible = !pRightSignal.Visible;
            bluetooth.SendSignalRight(pRightSignal.Visible);
        }

        private void timerLeftSignal_Tick(object sender, EventArgs e)
        {
            pLeftSignal.Visible = !pLeftSignal.Visible;
            bluetooth.SendSignalLeft(pLeftSignal.Visible);
        }

        //Bluetooth

        private void KMUI_ValueChanged(object sender, EventArgs e)
        {
            bluetooth.SendKM(Convert.ToUInt64(KMUI.Value));
        }

        public void DirectionChanged(int value)
        {
            bluetooth.SendDirection(value);
            Console.WriteLine(value);
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            bluetooth.SaveKM();
        }
    }
}
