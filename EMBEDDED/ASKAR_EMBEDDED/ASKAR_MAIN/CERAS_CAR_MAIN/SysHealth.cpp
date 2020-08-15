#include "SysHealth.h"


SysHealth::SysHealth()
{
  Serial.println("System Health initialized");
}

void SysHealth::LocalLoop()
 {
    //P_TempHum();
    P_LifeValue(); 
    //P_RunTime();
    //P_Battery();      
 }

void SysHealth::P_Battery()
{
  if (millis() - T_Battery > HZ_Battery)
    {        
      sendC.Send(ID_Remote,MID_SysHealth,TID_Battery,batteryValue); 
//      Serial.print("batteryValue:");Serial.println(batteryValue,DEC);      
      T_Battery = millis();
    }
}
void SysHealth::P_RunTime()
{
  if (millis() - T_RunTime > HZ_RunTime)
    { 
      runTime++;      
      sendC.Send(ID_Remote,MID_SysHealth,TID_RunTime,runTime); 
//      Serial.print("runTime:");Serial.println(runTime,DEC);     
      T_RunTime = millis();
    }
}
 
void SysHealth::P_LifeValue()
{
  if (millis() - T_LifeValue > HZ_LifeValue)
    {       
      sendC.Send(ID_Remote,MID_SysHealth,TID_LifeValue,lifeValue);
//      Serial.print("lifeValue:");Serial.println(lifeValue,DEC);      
      T_LifeValue = millis();
    }
}

void SysHealth::P_TempHum()
{
  if (millis() - T_Temperature > HZ_Temperature)
    {   
      sendC.Send(ID_Remote,MID_SysHealth,TID_Temperature,GetMotorTemperature());
//      Serial.print("temperature:");Serial.println(temperature,DEC);
      sendC.Send(ID_Remote,MID_SysHealth,TID_Humidity,GetMotorHumidity());
//      Serial.print("humidity:");Serial.println(humidity,DEC);     
      T_Temperature = millis();
    }
}

void SysHealth::SolveData(byte TID ,byte value)
  {
     switch(TID)
     {
       
     }
  }

byte SysHealth::GetMotorTemperature()
  {
    chk = DHT11.read(DHT11PIN);    
    temperature = (byte)DHT11.temperature;
    return  temperature;
  }
  
byte SysHealth::GetMotorHumidity()
  {
    chk = DHT11.read(DHT11PIN);
    humidity = (byte)DHT11.humidity;
    return humidity;
  }
