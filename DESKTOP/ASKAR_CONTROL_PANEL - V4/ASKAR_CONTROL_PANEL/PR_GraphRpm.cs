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
    public partial class PR_GraphRpm : UserControl
    {
        //Fields
        ASKAR_UI_FORM MainUI;
        private int value_SPEED;
        private int value_GEAR_BOX;
        private int value_GEAR_NUMBER;
        private int value_RPM;
        bool AutoGear = false;
        int limitTurbo = 33;



        public PR_GraphRpm(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
            value_GEAR_BOX = 0;
            value_GEAR_NUMBER = 0;
        }
        public PR_GraphRpm()
        {
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainUI.DashBoardPagesVisible(PageAddress.R, Pages.PR_Graphs);
        }
        private void AG_RPM_ValueChanged(object sender, EventArgs e)
        {
            switch (MainUI.speedUpDown)
            {
                case true:
                    if (value_GEAR_NUMBER!=6)
                    {
                        if (AG_RPM.Value >= 61 && AG_RPM.Value <= 70) { pbGearUP.BackColor = Color.Maroon; }
                        else if (AG_RPM.Value >= 35 && AG_RPM.Value <= 60) { pbGearUP.BackColor = Color.DarkGoldenrod; }
                        else { pbGearUP.BackColor = Color.Transparent; }
                        pbGearDOWN.BackColor = Color.Transparent;
                    }
                    else
                    {
                        pbGearUP.BackColor = Color.Transparent;
                        pbGearDOWN.BackColor = Color.Transparent;
                    }                 
                    break;
                case false:
                    if (value_GEAR_NUMBER > 1 )
                    {
                        if (AG_RPM.Value >= 10 && AG_RPM.Value <= 20) { pbGearDOWN.BackColor = Color.DarkGoldenrod; }
                        else if (AG_RPM.Value >= 5 && AG_RPM.Value <= 9) { pbGearUP.BackColor = Color.Maroon; }
                        else { pbGearDOWN.BackColor = Color.Transparent; }
                        pbGearUP.BackColor = Color.Transparent;
                    }
                    else
                    {
                        pbGearUP.BackColor = Color.Transparent;
                        pbGearDOWN.BackColor = Color.Transparent;
                    }
                    break;
            }
            if (AG_RPM.Value == 0)
            {
                pbMotorRunning.Visible = false;
            }
            else
            {
                pbMotorRunning.Visible = true;
            }
            if (MainUI.MotorTurbo && MainUI.speedUpDown)
            {
                if (AG_RPM.Value > limitTurbo && (value_GEAR_NUMBER>1 && value_GEAR_NUMBER<6))
                {
                    pbMotorTurbo.Visible = true;
                }
                else
                {
                    pbMotorTurbo.Visible = false;
                }
            }
          
        }

        //GetSet
        public int ValueSPEED
        {
            get => value_SPEED;
            set
            {
                if (value <= 250 && value >= 0) //Speed Control
                {

                    if (AutoGear) //Auto Gear
                    {
                        value_SPEED = value;

                        if (MainUI.brakeActive)
                        {
                            if (value_SPEED >= 30) { Value_RPM = Convert.ToInt32((value_SPEED - 30) / 3); }
                        }
                        else
                        {
                            if (0 <= value_SPEED && value_SPEED <= 55) { Value_RPM = value_SPEED; Value_GEAR_NUMBER = 1; }
                            else if (55 < value_SPEED && value_SPEED <= 95) { Value_RPM = value_SPEED % 55 + 5; Value_GEAR_NUMBER = 2; }
                            else if (95 < value_SPEED && value_SPEED <= 130) { Value_RPM = value_SPEED % 95 + 10; Value_GEAR_NUMBER = 3; }
                            else if (130 < value_SPEED && value_SPEED <= 165) { Value_RPM = value_SPEED % 130 + 10; Value_GEAR_NUMBER = 4; }
                            else if (165 < value_SPEED && value_SPEED <= 200) { Value_RPM = value_SPEED % 165 + 10; Value_GEAR_NUMBER = 5; }
                            else if (200 < value_SPEED) { Value_RPM = value_SPEED - 190; Value_GEAR_NUMBER = 6; }
                        }

                      
                    }
                    else          //Manuel Gear
                    {
                        if (MainUI.speedUpDown) // Gas Press
                        {
                            switch (value_GEAR_NUMBER)
                            {
                                case 0:
                                    if (value <= 55) { value_SPEED = value; Value_RPM = value_SPEED; }
                                    break;
                                case 1:
                                    if ( value <= 55) { value_SPEED = value; Value_RPM = value_SPEED; } 
                                    break;
                                case 2:
                                    if (value > 45 && value <= 95) { value_SPEED = value; Value_RPM = value_SPEED -35; } else if (value <= 45) { value_SPEED = value; Value_RPM = Convert.ToInt32(value_SPEED / 5); }
                                    break;
                                case 3:
                                    if (value > 85 && value <= 130) { value_SPEED = value; Value_RPM = value_SPEED - 75; } else if (value <= 85) { value_SPEED = value; Value_RPM = Convert.ToInt32(value_SPEED / 9); }
                                    break;
                                case 4:
                                    if (value > 120 && value <= 165) { value_SPEED = value; Value_RPM = value_SPEED - 110; } else if (value <= 120) { value_SPEED = value; Value_RPM = Convert.ToInt32(value_SPEED / 12); }
                                    break;
                                case 5:
                                    if (value > 155 && value <= 200) { value_SPEED = value; Value_RPM = value_SPEED - 145; } else if (value <= 155) { value_SPEED = value; Value_RPM = Convert.ToInt32(value_SPEED / 15); }
                                    break;
                                case 6:
                                    if (value > 190 && value <= 250) { value_SPEED = value; Value_RPM = value_SPEED - 180; } else if (value <= 190) { value_SPEED = value; Value_RPM = Convert.ToInt32(value_SPEED / 19); }
                                    break;
                            }

                        }
                        else //Gas Not Press
                        {
                            value_SPEED = value;
                            if (value_GEAR_NUMBER > 1)
                            {
                                Value_RPM = Convert.ToInt32(value_SPEED / 3);
                            }
                            else
                            {
                                Value_RPM = value_SPEED;
                            }
                            
                            
                        }
                                                
                    }



                    if (value_SPEED >= 30 && value_GEAR_NUMBER != 0)
                    {
                        MainUI.AG_KM.Value = value_SPEED - 30;

                    }
                    RPMLocalSendingCenter();
                }
            }
        }
        public int Value_GEAR_NUMBER
        {
            get => value_GEAR_NUMBER;
            set
            {
                if(value_GEAR_BOX==2 || value_GEAR_BOX == 3)
                {
                    if (value >= 0 && value <= 6)
                    {
                        value_GEAR_NUMBER = value;
                        MainUI.AG_KM.GaugeLabels[0].Text = value_GEAR_NUMBER.ToString();
                        if (MainUI.brakeActive)
                        {
                            MainUI.timerMotor.Interval = 5;
                        }
                        else
                        {
                            if (pbNitro.Visible)
                            {
                                MainUI.timerMotor.Interval = 5;
                            }
                            else
                            {
                                switch (Value_GEAR_NUMBER)
                                {
                                    case 0:
                                        MainUI.timerMotor.Interval = 9;
                                        break;
                                    case 1:
                                        MainUI.timerMotor.Interval = 10;
                                        break;
                                    case 2:
                                        MainUI.timerMotor.Interval = 20;
                                        break;
                                    case 3:
                                        MainUI.timerMotor.Interval = 35;
                                        break;
                                    case 4:
                                        MainUI.timerMotor.Interval = 50;
                                        break;
                                    case 5:
                                        MainUI.timerMotor.Interval = 65;
                                        break;
                                    case 6:
                                        MainUI.timerMotor.Interval = 90;
                                        break;

                                }
                            }
                           
                        }
                       
                    }
                }
               

            }


        }
        public int Value_RPM
        {
            get => value_RPM;
            set
            {
                if (value >= 0 && value <= 65)
                {
                    value_RPM = value;
                    AG_RPM.Value = value_RPM + 5;
                }
            }
        }
        public int Value_GEAR_BOX
        {
            get => value_GEAR_BOX;

            set
            {
                if(value_SPEED==0 || (value_SPEED>0 && (value==2 || value==3)))
                {
                    if (value >= 0 && value <= 3)
                    {
                        value_GEAR_BOX = value;
                        switch (value)
                        {
                            case 0:
                                MainUI.PBxGear.BackgroundImage = Properties.Resources.pvites2;
                                MainUI.AG_KM.GaugeLabels[0].Text = "0";
                                value_GEAR_NUMBER = 0;
                                CarBackLight(false);
                                break;
                            case 1:
                                MainUI.PBxGear.BackgroundImage = Properties.Resources.rvites;
                                MainUI.AG_KM.GaugeLabels[0].Text = "R";
                                value_GEAR_NUMBER = 1;
                                CarBackLight(true);
                                break;
                            case 2:
                                MainUI.PBxGear.BackgroundImage = Properties.Resources.nvites;
                                MainUI.AG_KM.GaugeLabels[0].Text = value_GEAR_NUMBER.ToString();
                                AutoGear = false;
                                CarBackLight(false);
                                break;
                            case 3:
                                MainUI.PBxGear.BackgroundImage = Properties.Resources.dvites;
                                AutoGear = true;
                                break;
                        }
                    }
                }
                else
                {
                    MainUI.InfoArea.Text = "Hareket halinde Değişim Yapılamaz";
                }
               
            }


        }

        //Functions
        private void RPMLocalSendingCenter()
        {
            //sending...
            if (value_GEAR_NUMBER != 0)
            {
                if ((value_GEAR_NUMBER == 1 && MainUI.speedUpDown) || (pbMotorTurbo.Visible))
                {
                    MainUI.sendData[2] = Convert.ToByte(value_SPEED + 40);
                }
                else
                {
                    MainUI.sendData[2] = Convert.ToByte(value_SPEED);
                }
            }
            else
            {
                MainUI.sendData[2] = Convert.ToByte(0);
            }
            MainUI.sendData[1] = 0x10;//Address
            if (value_GEAR_BOX == 1)
            {
                MainUI.sendData[3] = 0x00;
            }
            else
            {
                MainUI.sendData[3] = 0x01;
            }
            MainUI.MainSendDataCenter(MainUI.sendData);
        }
        private void CarBackLight(bool valueLight)
        {
            MainUI.sendData[1] = 0x08;//Address
            if (valueLight)
            {
                MainUI.sendData[2] = 0x01;
            }
            else
            {
                MainUI.sendData[2] = 0x00;
            }           
            MainUI.MainSendDataCenter(MainUI.sendData);
        }
        public void ChangeGearNumber(bool UpDownValue)
        {
            if (UpDownValue)
            {
                Value_GEAR_NUMBER++;
            }
            else
            {
                Value_GEAR_NUMBER--;
            }

        }
        public void ChangeGearBox(bool HomeEnd)
        {
            if (HomeEnd)
            {
                Value_GEAR_BOX++;
            }
            else
            {
                Value_GEAR_BOX--;
            }
        }
    }
}
