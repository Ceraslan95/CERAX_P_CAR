using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace CERAXCAR.Concrete.Engine
{
    public class Motor
    {
        UI _ui;
        int km;

        private bool motorStatus;
        
        private int speed;
        private bool goingDirection;
        private Direction direction;

        private int directionValue = 90;
        private const int directionMaxLeftValue = 45;
        private const int directionMiddleValue = 90;
        private const int directionMaxRightValue = 135;

        private const int directionESPMaxLeftValue = 60;
        private const int directionESPMaxRightValue = 120;
        private const int directionESPActiveValue = 180;


        private bool speedUpDown;

        public Timer speedTimer;
        public Timer directionTimer;
        private const int speedMaxValue = 240;
        private const int speedMinValue = 0;

        private const int speedRMaxValue = 100;

        //--------------------------------

        private Gears gearValue;
        private const int gearIntervalZero = 0;
        private const int gearIntervalOne = 30;
        private const int gearIntervalTwo = 50;
        private const int gearIntervalThree = 70;
        private const int gearIntervalFour = 90;
        private const int gearIntervalFive = 120;
        private const int gearIntervalSix = 160;

        private const int speedIntervalR = 12;
        private const int speedIntervalOne = 12;
        private const int speedIntervalTwo = 18;
        private const int speedIntervalThree = 24;
        private const int speedIntervalFour = 30;
        private const int speedIntervalFive = 36;
        private const int speedIntervalSix = 42;
        private const int speedIntervalSeven = 48;

        //----------------------------------

        private bool turbo = false;
        private const int turboAdditive = 10;

        private bool nitro = false;
        private const int nitroAdditive = 14;

        private bool abs = false;
        private const int absAdditive = 1;

        private bool esp = false;

        private bool cruise = false;

        public enum Direction
        {
            Left = -1,
            Middle = 0,
            Right = 1
        }
        public enum Gears
        {
            R = -1,
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7


        }

        
        
        public Motor(UI ui)
        {
            _ui = ui;
            motorStatus = false;
            
            goingDirection = true;
            speedUpDown = false;

            direction = Direction.Middle;

            speedTimer = new Timer();
            speedTimer.Interval = 15;
            speedTimer.Elapsed += new ElapsedEventHandler(SpeedTimer_Tick);

            directionTimer = new Timer();
            directionTimer.Interval = 50;
            directionTimer.Elapsed += new ElapsedEventHandler(DirectionTimer_Tick);

            gearValue = Gears.Zero;
        }

        private void DirectionTimer_Tick(object sender, ElapsedEventArgs e)
        {
            switch (direction)
            {
                case Direction.Left:
                    {
                        TurnDirectionLeft();
                    }
                    break;
                case Direction.Middle:
                    {
                        TurnDirectionMiddle();
                    }
                    break;
                case Direction.Right:
                    {
                        TurnDirectionRight();
                    }
                    break;
            }
            _ui.DirectionChanged(directionValue);
        }

        private void TurnDirectionRight()
        {
            if (GetEspValue())
            {
                if (speed > directionESPActiveValue)
                {
                    if (directionValue < directionESPMaxRightValue)
                    {
                        directionValue++;
                    }
                }
                else
                {
                    if (directionValue < directionMaxRightValue)
                    {
                        directionValue++;
                    }
                }
            }
            else
            {
                if (directionValue < directionMaxRightValue)
                {
                    directionValue++;
                }
            }
            
        }

        private void TurnDirectionMiddle()
        {
            if (directionValue < directionMiddleValue)
            {
                directionValue++;               
            }
            else
            {
                directionValue--;                
            }
            if (directionValue == directionMiddleValue) { directionTimer.Stop(); }
        }
        private void TurnDirectionLeft()
        {
            if (GetEspValue())
            {
                if (speed > directionESPActiveValue)
                {
                    if (directionValue > directionESPMaxLeftValue)
                    {
                        directionValue--;
                    }
                }
                else
                {
                    if (directionValue > directionMaxLeftValue)
                    {
                        directionValue--;
                    }
                }
            }
            else
            {
                if (directionValue > directionMaxLeftValue)
                {
                    directionValue--;
                }
            }
            
        }
        public void SetEspValue(bool value)
        {
            esp = value;
            _ui.pESP.Visible = value;
        }
        public bool GetEspValue()
        {
            return esp;
        }
        public void SpeedUp()
        {
            if (!speedTimer.Enabled)
            {
                speedTimer.Start();
                Console.WriteLine("speed timer status :" + speedTimer.Enabled);
            }

            SetSpeedUpDown(true);
        }

        public void SpeedDown()
        {
            SetSpeedUpDown(false);
        }
        private void IncreaseSpeed()
        {
            if (GetGoingDirection())
            {
                if (speed < speedMaxValue)
                {
                    speed++;
                    _ui.KMUI.Value = speed;
                }
            }
            else
            {
                if (speed < speedRMaxValue)
                {
                    speed++;
                    _ui.KMUI.Value = speed;
                }
            }
                                  
        }
        private void DecreaseSpeed()
        {
            if(speed > speedMinValue)
            {
                
                speed--;
                _ui.KMUI.Value = speed;
                if (speed == speedMinValue) 
                {
                    ControlGear();
                    speedTimer.Stop();
                    Console.WriteLine("speed timer status :"+speedTimer.Enabled);                
                }
            }
            
        }
        public void SetSpeedUpDown(bool value)
        {
            speedUpDown = value;
        }
        public bool GetSpeedUpDown()
        {
            return speedUpDown;
        }
        private void SpeedTimer_Tick(object sender, EventArgs e)
        {
            if (speedUpDown)
            {
                IncreaseSpeed();
            }
            else
            {
                DecreaseSpeed();
            }
            ControlGear();
        }

        private void ControlGear()
        {
            ControlGear(speed);

        }

        public bool GetMotorStatus()
        {
            return motorStatus;
        }
        public bool GetGoStatus()
        {
            return speedTimer.Enabled;
        }

        public bool GetGoingDirection()
        {
            return goingDirection;
        }

        public void SetGoingDirection(bool value)
        {
            goingDirection = value;
        }

        public void SetSpeedTimerInverval(int value)
        {
            if (GetSpeedUpDown())
            {
                if (GetNitroValue())
                {
                    speedTimer.Interval = value / 6;
                }
                else
                {
                    if (GetTurboValue())
                    {
                        speedTimer.Interval = value / 2;
                    }
                    else
                    {
                        speedTimer.Interval = value;
                    }

                }
            }
            else
            {
                if (GetAbsValue())
                {
                    speedTimer.Interval = absAdditive;
                }
                else
                {
                    speedTimer.Interval = value;
                }
                
            }
           
            
        }

        public bool GetTurboValue()
        {
            return turbo;
        }

        public void SetTurboValue(bool value)
        {
            turbo = value;
            if (turbo)
            {
                _ui.pTurbo.Visible = true;
            }
            else
            {
                _ui.pTurbo.Visible = false;
            }
        }

        public bool GetNitroValue()
        {
            return nitro;
        }

        public void SetNitroValue(bool value)
        {
            nitro = value;
            if (nitro)
            {
                _ui.pNitro.Visible = true;
            }
            else
            {
                _ui.pNitro.Visible = false;
            }
        }

        public bool GetAbsValue()
        {
            return abs;
        }

        public void SetAbsValue(bool value)
        {
            abs = value;
            if (abs)
            {
                if (!speedTimer.Enabled) { speedTimer.Start(); SetSpeedUpDown(false); }
                _ui.pABS.Visible = true;
            }
            else
            {
                _ui.pABS.Visible = false;
            }
        }

        public bool GetCruiseValue()
        {
            return cruise;
        }

        public void SetCruiseValue(bool value)
        {
            cruise = value;
            if (cruise)
            {
                speedTimer.Stop();
                _ui.pCruise.Visible = true;
            }
            else
            {
                _ui.pCruise.Visible = false;
            }
        }
        //----------

        public Gears GetGearValue()
        {
            return gearValue;
        }

        public void SetGearValue(Gears gear)
        {
            gearValue = gear;
            switch (gear)
            {
                case Gears.R:
                    {
                        SetSpeedTimerInverval(speedIntervalR);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.ToString();
                    }
                    break;
                case Gears.Zero:
                    {
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.One:
                    {
                        SetSpeedTimerInverval(speedIntervalOne);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.Two:
                    {
                        SetSpeedTimerInverval(speedIntervalTwo);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.Three:
                    {
                        SetSpeedTimerInverval(speedIntervalThree);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.Four:
                    {
                        SetSpeedTimerInverval(speedIntervalFour);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.Five:
                    {
                        SetSpeedTimerInverval(speedIntervalFive);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.Six:
                    {
                        SetSpeedTimerInverval(speedIntervalSix);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;
                case Gears.Seven:
                    {
                        SetSpeedTimerInverval(speedIntervalSeven);
                        _ui.KMUI.GaugeLabels.FindByName("lblGearBox").Text = gear.GetHashCode().ToString();
                    }
                    break;

            }

        }

        public void ControlGear(int speed)
        {
            if (GetGoingDirection())
            {
                if (speed == gearIntervalZero)
                {
                    SetGearValue(Gears.Zero);
                }
                else if (speed > gearIntervalZero && speed <= gearIntervalOne)
                {
                    SetGearValue(Gears.One);
                }
                else if (speed > gearIntervalOne && speed <= gearIntervalTwo)
                {
                    SetGearValue(Gears.Two);
                }
                else if (speed > gearIntervalTwo && speed <= gearIntervalThree)
                {
                    SetGearValue(Gears.Three);
                }
                else if (speed > gearIntervalThree && speed <= gearIntervalFour)
                {
                    SetGearValue(Gears.Four);
                }
                else if (speed > gearIntervalFour && speed <= gearIntervalFive)
                {
                    SetGearValue(Gears.Five);
                }
                else if (speed > gearIntervalFive && speed <= gearIntervalSix)
                {
                    SetGearValue(Gears.Six);
                }
                else if (speed > gearIntervalSix)
                {
                    SetGearValue(Gears.Seven);
                }
            }
            else
            {
                SetGearValue(Gears.R);
            }


        }

        public Direction GetDirectionStatus()
        {
            return direction;
        }

        public void SetDirectionStatus(Direction value)
        {
            direction = value;
            if (!directionTimer.Enabled) { directionTimer.Start(); }
        }

        public void SetDirectionValue(int value)
        {
            directionValue = value;
        }
        public int GetDirectionValue()
        {
            return directionValue;
        }
    }
}
