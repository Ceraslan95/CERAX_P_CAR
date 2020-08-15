#include <Arduino.h>

#ifndef SysHealth_h
#define SysHealth_h

#include "src/dht11.h" // sıcaklık sensoru
#include "SendCenter.h"

//IDs---------------------
#define ID_Header  0x00
#define ID_Remote  0x01
//MID---------------------
#define MID_SysHealth 0x06

#define DHT11PIN 22

#define lifeValue  0x01

#define TID_LifeValue 0x00
#define TID_Temperature 0x01
#define TID_Humidity 0x02
#define TID_Battery 0x03
#define TID_RunTime 0x04

#define HZ_Temperature 10000
#define HZ_LifeValue 3000
#define HZ_RunTime 60000
#define HZ_Battery 10000


class SysHealth
{
  public:
    
    SysHealth();
    void LocalLoop();
    void SolveData(byte TID ,byte value);

  private:
    
    SendCenter sendC;
    byte dataPacket[5];
    byte GetMotorTemperature();
    byte GetMotorHumidity();  
    void P_TempHum();
    void P_LifeValue();
    void P_RunTime();
    void P_Battery();
    unsigned long T_Temperature = 0;
    unsigned long T_LifeValue = 0;
    unsigned long T_RunTime = 0; 
    unsigned long T_Battery = 0; 
    byte* GetPacket(byte value);
    byte runTime = 0;
    byte batteryValue = 50;
    dht11 DHT11;
    int chk = 0;
    byte humidity = 0x00;
    byte temperature = 0x00;
};

#endif
