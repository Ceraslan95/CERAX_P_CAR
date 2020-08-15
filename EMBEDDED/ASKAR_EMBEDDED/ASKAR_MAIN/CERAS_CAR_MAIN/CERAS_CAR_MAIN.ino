// CERAS CAR MAIN 

// paket icerigi    =>  0       |  1              |  2          |  3          | 4
//                     checksum |  ID             | MID         |  TID        | VALUE
//                      0x16    |0:Header,1:Remote| 0-255       |  0-255      | 0-255
//
//0:
//1:SystemMain
//2:SystemMotor
//3:SystemProtection
//4:SystemLed
//5:SystemBalance
//6:SystemHealth

//Libraries---------------

#include "SysBalance.h"
#include "SysHealth.h"
#include "SysLed.h"
#include "SysMotor.h"
#include "SysProtection.h"
//#include "SysWay.h"
//#include "AFMotor.h"
//#include <Arduino.h>



//IDs---------------------
#define ID_Header  0x00
#define ID_Remote  0x01

//MAddress----------------
#define MID_Special 0x00
#define MID_SysMain 0x01
#define MID_SysMotor  0x02
#define MID_SysProtection  0x03
#define MID_SysLed 0x04
#define MID_SysBalance 0x05
#define MID_SysHealth 0x06
#define MID_SysWay 0x07

#define DataLength 5

//Usings---------------------
//SysBalance sysBalance;
////SysMotor sysMotor;
SysProtection sysProtection;
SysHealth sysHealth;
//SysLed sysLed;
////SysWay sysWay;

//Fields---------------------
byte MID,TID,value;
byte receivedData[DataLength];
//Timers
unsigned long T_Serial = 0;
int HZ_Serial = 10;


void setup()
{  
  Serial.begin(9600);
  Serial2.begin(9600); //Seri haberleşme başlatılır
    
}
void loop()
{   
    ConnectionSerial();
//  sysBalance.LocalLoop(); 
//  //sysMotor.LocalLoop();
  sysProtection.LocalLoop();
  sysHealth.LocalLoop();

//  //sysWay.LocalLoop();
  
}


void ConnectionSerial()
{
  if (millis() - T_Serial > HZ_Serial)
  {   
    if(Serial2.available())//SERIAL CONNECTION
    {
      Serial2.readBytes(receivedData,DataLength);
      SolveData(receivedData);      
    }
    T_Serial = millis();
  }     
}


void SolveData(byte *data)
{
  
  MID = data[2];
  TID = data[3];
  value = data[4]; 
  switch(MID)
  {
    case MID_SysMain:
    {
    //sysMotor.SolveData(TID,value);
    }break;
    case MID_SysMotor:
    {
    //sysMotor.SolveData(TID,value);
    }break;
    case MID_SysProtection:
    {
     // sysProtection.SolveData(TID,value);
    }break;
    case MID_SysLed:
    {
      //sysLed.SolveData(TID,value);
    }break;
    case MID_SysBalance:
    {
     // sysBalance.SolveData(TID,value);
    }break;
    case MID_SysHealth:
    {
     // sysHealth.SolveData(TID,value);
    }break;
    case MID_SysWay:
    {
    //sysWay.SolveData(TID,value);
    }break;
    
  }
}
