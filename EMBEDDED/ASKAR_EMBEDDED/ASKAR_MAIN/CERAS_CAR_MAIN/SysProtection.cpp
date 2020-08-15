#include "SysProtection.h"


SysProtection::SysProtection()
{
    //**********Distance Sensors****************
  pinMode(U_FrontFront_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_FrontFront_E, INPUT);
  pinMode(U_FrontLeft_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_FrontLeft_E, INPUT);
  pinMode(U_FrontRight_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_FrontRight_E, INPUT);

  pinMode(U_RightFront_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_RightFront_E, INPUT);
  pinMode(U_RightBack_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_RightBack_E, INPUT);

  pinMode(U_LeftFront_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_LeftFront_E, INPUT);
  pinMode(U_LeftBack_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_LeftBack_E, INPUT);

  pinMode(U_BackLeft_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_BackLeft_E, INPUT);
  pinMode(U_BackRight_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_BackRight_E, INPUT);
  Serial.println("System Protection initialized");
}

 void SysProtection::LocalLoop()
 {
  
 }

void SysProtection::SolveData(byte TID ,byte value)
{
  switch(TID)
  {
    case TID_AP_Protection:
    {
      Set_AP_Protection(value);
    }break;
    case TID_ProWX2:
    {
      Set_protectionWidth_X2(value);
    }break;
    case TID_ProMode:
    {
      Set_protectionMode(value);
    }break;
  }
}

void SysProtection::Set_protectionWidth_X2(byte value)
{
  if((unsigned char)value>10){protectionWidth_X2 = (unsigned char)value; }
}

void SysProtection::Set_protectionMode(byte value)
{
  switch(value)
  {
    case 0x00:
    {
     protectionMode = 0x00;
    }break;
    case 0x01:
    {
     protectionMode = 0x01;
    }break;
  }
}

void SysProtection::Set_AP_Protection(byte value)
{
  switch(value)
  {
    case 0x00:
    {
     AP_Protection = false;
    }break;
    case 0x01:
    {
     AP_Protection = true;
    }break;
  }
}

void SysProtection::Set_DistanceBuffer()
{
  do{
    switch(distanceBufferCount)
    {
      case 0:
      {
        distances[0] = CheckDistance(U_FrontFront_T,U_FrontFront_E);
      }break;
      case 1:
      {
      distances[1] = CheckDistance(U_FrontRight_T,U_FrontRight_E);
      }break;
      case 2:
      {
      distances[2] = CheckDistance(U_FrontLeft_T,U_FrontLeft_E);
      }break;
      case 3:
      {
      distances[3] = CheckDistance(U_RightFront_T,U_RightFront_E);
      }break;
      case 4:
      {
      distances[4] = CheckDistance(U_LeftFront_T,U_LeftFront_E);
      }break;
      case 5:
      {
      distances[5] = CheckDistance(U_RightBack_T,U_RightBack_E);
      }break;
      case 6:
      {
      distances[6] = CheckDistance(U_LeftBack_T,U_LeftBack_E);
      }break;
      case 7:
      {
      distances[7] = CheckDistance(U_BackRight_T,U_BackRight_E);
      }break;
      case 8:
      {
      distances[8] = CheckDistance(U_BackLeft_T,U_BackLeft_E);
      }break;
    }
    distanceBufferCount++;
    }while(distanceBufferCount<=8);

}

bool SysProtection::Get_AP_Protection()
{
 return AP_Protection;
}

byte SysProtection::Get_protectionMode()
{
  return protectionMode;
}

unsigned char SysProtection::Get_protectionWidth_X2()
{
  return protectionWidth_X2;
}

unsigned char SysProtection::CheckDistance(unsigned char TP, unsigned char EP)
 {
  digitalWrite(TP, LOW);  //para generar un pulso limpio ponemos a LOW 4us
  delayMicroseconds(4);
  digitalWrite(TP, HIGH);  //generamos Trigger (disparo) de 10us
  delayMicroseconds(10);
  digitalWrite(TP, LOW);
  duration = pulseIn(EP, HIGH);
  distance = duration * 10 / 292 / 2;  //convertimos a distancia, en cm
  return (unsigned char)distance;
}
