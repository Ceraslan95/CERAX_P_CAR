#include "SysGun.h"


SysGun::SysGun()
{
  servoTop.attach(p_ServoTop);
  servoBottom.attach(p_ServoBottom);
  servoTop.write(10);
  servoBottom.write(90);
}


void SysGun::SolveData(byte TID,byte value)
{
  switch(TID)
  {
    case A_AP_sysGun:
    {
      if(value == 0x01){AP_sysGun =true;} else {AP_sysGun = false; }
    }break;
    case A_servoTop:
    {
      Serial.println("ang");
      uint8_t ang = (uint8_t)value;
      if(ang>10 && ang<100){servoTop.write(ang); }
    }break;
    case A_servoBottom:
    {
      uint8_t ang = (uint8_t)value;
      if(ang>10 && ang<170){servoBottom.write(ang); }
    }break;
    
  }
}
