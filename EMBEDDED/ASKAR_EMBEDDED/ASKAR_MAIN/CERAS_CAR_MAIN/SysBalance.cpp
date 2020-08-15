#include "SysBalance.h"

SysBalance::SysBalance()
 {
  Wire.begin();
  balance.initialize();
  Serial.println("System Balance initialized");
 }
 

 void SysBalance::LocalLoop()
 {
    C_BalanceSystem();
 }

 void SysBalance::C_BalanceSystem()
 {
    if(AP_Balance)
    {
      if (millis() - T_Balance > HZ_Balance)
        {   
         Control();
         if(AP_BalanceSend){ sendC.Send(ID_Remote,MID_SysBalance,TID_SlopeAX,(byte)ax);}    
         T_Balance = millis();
        }
    }       
 }
 
 void SysBalance::SolveData(byte TID ,byte value)
 {
   switch(TID)
     {
       case TID_AP_Balance:
       {
         Set_AP_Balance(value);
       }break;
       case TID_AP_BalanceSend:
       {
         Set_AP_BalanceSend(value);
       }break;
     }
 }


 
 void SysBalance::Control()
  {
    balance.getMotion6(&ax, &ay, &az, &gx, &gy, &gz); // ivme ve gyro değerlerini okuma
    Serial.println("DEBUG : "+ax);
  }
 
 void SysBalance::Set_AP_Balance(byte value)
 {
     switch(value)
    {
        case 0x00:
        {
         AP_Balance = false;
        }break;
        case 0x01:
        {
         AP_Balance = true;
        }break;
    }
 }
 void SysBalance::Set_AP_BalanceSend(byte value)
 {
    if(AP_Balance)
    {
        switch(value)
      {
          case 0x00:
          {
           AP_BalanceSend = false;
          }break;
          case 0x01:
          {
           AP_BalanceSend = true;
          }break;
      }
    }
     
 }
