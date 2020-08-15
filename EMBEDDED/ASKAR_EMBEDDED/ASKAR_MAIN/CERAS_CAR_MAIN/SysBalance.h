#include <Arduino.h>

#ifndef SysBalance_h
#define SysBalance_h

#include <Wire.h> // Ivme sensorunun
#include "src/I2Cdev.h" //I2C kütüphanesini ekledik
#include "src/MPU6050.h" //Mpu6050 kütüphanesi ekledik
#include "SendCenter.h"

#define ID_Remote  0x01

#define MID_SysBalance 0x05

#define TID_AP_Balance 0x00
#define TID_SlopeAX 0x03
#define TID_AP_BalanceSend 0x01

#define HZ_Balance 250

class SysBalance
{

  public:
  
    SysBalance();
    void LocalLoop();
    void SolveData(byte TID ,byte value);

  private:
    
    SendCenter sendC;
    void Control();
    void C_BalanceSystem();
    void Set_AP_Balance(byte value);
    void Set_AP_BalanceSend(byte value);
    unsigned long T_Balance = 0;

    
    MPU6050 balance; // sensörümüze ivme_sensor adını verdik
    int16_t ax, ay, az; //ivme tanımlama
    int16_t gx, gy, gz; //gyro tanımlama

    bool AP_Balance = true;
    bool AP_BalanceSend = false;
};

#endif
