#include "SysLed.h"

SysLed::SysLed()
 {
     pinMode(p_LedBack,OUTPUT);
     pinMode(p_LedBlue,OUTPUT);
     pinMode(p_LedFogs,OUTPUT);

     digitalWrite(p_LedBack, LOW);
     digitalWrite(p_LedBlue, LOW);
     digitalWrite(p_LedFogs, LOW);
     Serial.println("System Led initialized");
 }

// void SysLed::LocalLoop()
// {
//
// }

 void SysLed::SetLedBack(byte value)
 {
   ChangeLED(p_LedBack,value);
 }
 void SysLed::SetLedBlue(byte value)
 {
   ChangeLED(p_LedBlue,value);
 }
 void SysLed::SetLedFogs(byte value)
 {
   ChangeLED(p_LedFogs,value);
 }

 void SysLed::SolveData(byte TID ,byte value)
 {
     switch(TID)//ADDRESS
    {
      case TID_LedBack:
      {
        ChangeLED(p_LedBack,value);
      }break;
      case TID_LedBlue:
      {
        ChangeLED(p_LedBlue,value);
      }break;
       case TID_LedFogs:
      {
        ChangeLED(p_LedFogs,value);
      }break;
      case TID_LedAllOnOff:
      {
        ChangeLED(p_LedBack,value);
        ChangeLED(p_LedBlue,value);
        ChangeLED(p_LedFogs,value);
      }break;
      
    }
 }

void SysLed::ChangeLED(int LED ,byte value)
{
    switch(value)
    {
      case 0x00:
      {
       digitalWrite(LED, LOW);    
      }break;
      case 0x01:
      {
       digitalWrite(LED, HIGH);
      }break;
    }
    
  }
