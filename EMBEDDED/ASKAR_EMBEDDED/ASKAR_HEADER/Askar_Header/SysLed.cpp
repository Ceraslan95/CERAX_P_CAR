#include "SysLed.h"

SysLed::SysLed()
{
    pinMode(p_LedLongs,OUTPUT);
    pinMode(p_LedShorts,OUTPUT);
    pinMode(p_LedStopsDark,OUTPUT);
    pinMode(p_LedStopsLight,OUTPUT);
    pinMode(p_LedBLSignal,OUTPUT);
    pinMode(p_LedBRSignal,OUTPUT);
    pinMode(p_LedFLSignal,OUTPUT);
    pinMode(p_LedFRSignal,OUTPUT);
    pinMode(p_Lazer,OUTPUT);
    pinMode(p_LedSpots,OUTPUT);

    analogWrite(p_LedLongs, 0);
    analogWrite(p_LedShorts, 0);
    analogWrite(p_LedStopsDark, 0);
    analogWrite(p_LedStopsLight, 0);
    analogWrite(p_Lazer, 0);
    analogWrite(p_LedSpots, 0);
    digitalWrite(p_LedBLSignal, LOW);
    digitalWrite(p_LedBRSignal, LOW);
    digitalWrite(p_LedFLSignal, LOW);
    digitalWrite(p_LedFRSignal, LOW);
}


void SysLed::SolveData(byte TID,byte value)
  {
    switch(TID)//ADDRESS
    {
      case A_LedLongs:
      {
        Serial.println("A_LedLongs");       
        ChangeLED(p_LedLongs,value,0x00);
      }break;
      case A_LedShorts:
      {
        ChangeLED(p_LedShorts,value,0x00);
      }break;
      case A_LedStopDark:
      {
        ChangeLED(p_LedStopsDark,value,0x00);
      }break;
      case A_LedStopLight:
      {
        ChangeLED(p_LedStopsLight,value,0x00);
      }break;
      case A_Lazer:
      {
        ChangeLED(p_Lazer,value,0x01);
      }break;
      case A_LedSpots:
      {
        ChangeLED(p_LedSpots,value,0x01);
      }break;
      case A_LedLeftsSignal:
      {
        ChangeLED(p_LedLSignal,value,0x01);
       
      }break;
      case A_LedRightsSignal:
      {
        ChangeLED(p_LedRSignal,value,0x01);
        
      }break;
      case A_LedAllOffOn:
      {
        ChangeLED(p_LedLongs,value,0x00);
        ChangeLED(p_LedShorts,value,0x00);
        ChangeLED(p_LedStopsDark,value,0x00);
        ChangeLED(p_LedStopsLight,value,0x00);
        ChangeLED(p_LedLSignal,value,0x01);
        
        ChangeLED(p_LedRSignal,value,0x01);
       
        ChangeLED(p_Lazer,value,0x01);
        ChangeLED(p_LedSpots,value,0x01);
      }
    }
  }


  void SysLed::ChangeLED(int LED ,byte value,byte AD)
  {//Analog 0x00 Digital 0x01
    switch(value)
    {
      case 0x01:
      {
       if(AD == 0x00){ analogWrite(LED, 255);}else { digitalWrite(LED, HIGH);}      
      }break;
      case 0x00:
      {
       if(AD == 0x00){ analogWrite(LED, 0);}else { digitalWrite(LED, LOW);}  
      }break;
    }
    
  }
