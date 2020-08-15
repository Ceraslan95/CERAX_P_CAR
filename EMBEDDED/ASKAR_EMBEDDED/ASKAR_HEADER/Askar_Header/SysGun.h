#include <Arduino.h>

#ifndef SysGun_h
#define SysGun_h

#include <Servo.h>
#define p_ServoTop 11
#define p_ServoBottom 10

#define A_AP_sysGun 0x00
#define A_servoTop 0x02
#define A_servoBottom 0x03


class SysGun
{
  public:
  SysGun();
  void SolveData(byte TID,byte value);
  
  private:
  Servo servoTop;
  Servo servoBottom;
  bool AP_sysGun = false;






  
};
#endif
