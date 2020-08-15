
// CERAS CAR SYSTEMS HEADER


// paket icerigi    =>  0       |  1              |  2          |  3          | 4
//                     checksum |  ID             | MID         |  TID        | VALUE
//                      0x16    |0:Header,1:Remote| 0-255       |  0-255      | 0-255
//
//0:
//1:SystemLed
//2:SystemGun

//includes----------------------------
#include "ESP8266.h"
#include <SoftwareSerial.h>
#include "SysLed.h"
#include "SysGun.h"

#define SSID        "TTNET_TPLINK_7326"
#define PASSWORD    "wvu6b4jy"
#define HOST_NAME   "192.168.1.4"
#define HOST_PORT   (80)

 
SoftwareSerial BT(6,7); // TX | RX
//SoftwareSerial SR(0,1); // TX | RX
SoftwareSerial mySerial(3, 2); /* RX:D4, TX:D3 */
ESP8266 wifi(mySerial,115200);
//mySerial.setNoDelay(1);

uint8_t receivedBuffer[5] = {0};  
uint8_t sendBuffer[5] = {0}; 
uint8_t DataLength = 5;
//USINGS------------------------------
SysLed sysLed;
SysGun sysGun();

   
//MAddress-----------
#define MID_SysLed 0x01
#define MID_SysGun 0x02
//Fields------------------------------
bool IsSerial = false;

enum Route
{
  R_BT,
  R_WF
};
Route route = R_WF;

#define HZ_COM 100
unsigned long T_SR= 0,T_WF= 0,T_BT = 0;






//SETUP------------------------------SETUP
void setup() {
  
  Initialize_Serial();
  
  Initialize_Wifi();
  
  //Initialize_Bluetooth();
 
}


//LOOP------------------------------LOOP
void loop()
{    
    ListenSerial();
  
//    ListenWifi();   

    //ListenBluetooth();  
}




//INITIALIZE------------------------------INITIALIZE
void Initialize_Serial()
{ 
  Serial.begin(9600);
}

void Initialize_Bluetooth()
{
//  BT.begin(9600);
//  BT.setTimeout(10); 
}

void Initialize_Wifi()
{
  while (true)
  {
    if (wifi.joinAP(SSID, PASSWORD))
    {      
      if (wifi.disableMUX()) 
      {        
        break;
      }      
    } 
    delay(5000);
  }
  while(true)
  {
    if (wifi.createTCP(HOST_NAME, HOST_PORT)) 
    {
      break;
    }   
    delay(3000);
  }
}

//RECEIVEAREA------------------------------RECEIVEAREA


byte MID,TID,Value;
void SolveData(byte data[])
{
  if(data[0] == 0x16)
  {
     MID = data[2];
     TID = data[3];
     Value = data[4];     
     if(IsSerial)
     {
        if(data[1] == 0x00) // ID 
        {
          switch(MID)
          {
            case MID_SysLed:
            {
              sysLed.SolveData(TID,Value);
            }break;
            case MID_SysGun:
            {
//              sysGun.SolveData(TID,Value);
            }break;
          }         
        }
        else
        {
            if(route == R_BT ) //send remote via Bluetooth
            {
               SendData_via_BLUETOOTH(data);
            }
            else // send remote via Wifi
            {
               SendData_via_WIFI(data);
            }
        }
     }
     else // BT || WF
     {     
        if(data[1] == 0x00) // ID HEADER
        {
         switch(MID)
          {
            case MID_SysLed:
            {             
              sysLed.SolveData(TID,Value);
            }break;
            case MID_SysGun:
            {
//              sysGun.SolveData(TID,Value);
            }break;
          }
        }
        else // ID MAIN
        {
          SendData_via_SERIAL(data);
        }
     }
  }
}

uint8_t len_SR = 0;
void ListenSerial()
{
  if (millis() - T_SR > HZ_COM)
  {   
     if(Serial.available())
     {  
      len_SR = Serial.readBytes(receivedBuffer,DataLength);
      if(len_SR > 0)
      {
        IsSerial = true;
        Serial.println(receivedBuffer[0]);
        Serial.println(receivedBuffer[1]);
        Serial.println(receivedBuffer[2]);
        Serial.println(receivedBuffer[3]);
        Serial.println(receivedBuffer[4]);
        SolveData(receivedBuffer);
      }  
     }
    T_SR = millis();
  }  
 
}

uint8_t len_WF = 0;
void ListenWifi()
{  
  if (millis() - T_WF > HZ_COM)
  {   
    len_WF = wifi.recv(receivedBuffer, sizeof(receivedBuffer), 0);
    if (len_WF > 0)
    {
      route = R_WF;
      IsSerial = false;
      SolveData(receivedBuffer);      
    } 
    T_WF = millis();
  }  
    
}

uint8_t len_BT = 0;
void ListenBluetooth()
{
//  if (millis() - T_COM > HZ_COM)
//  {   
//    
//    T_COM = millis();
//  }  
//  if(BT.available()
//  {
//    len_BT = SR.readBytes(receivedData,DataLength);
//    if (len > 0)
//    {
//      route = R_BT;
//      IsSerial = false;     
//      SolveData(receivedBuffer);   
//    }
//  }    
}


void SendData_via_WIFI(byte data[])
{
//  if(wifi.createTCP(HOST_NAME, HOST_PORT))
//  {   
    sendBuffer[0] = data[0];
    sendBuffer[1] = data[1];
    sendBuffer[2] = data[2];
    sendBuffer[3] = data[3];
    sendBuffer[4] = data[4];
    if(wifi.send(sendBuffer, sizeof(sendBuffer)))
    {
        Serial.println("sendwifi ok");
        Serial.println(sendBuffer[0]);
        Serial.println(sendBuffer[1]);
        Serial.println(sendBuffer[2]);
        Serial.println(sendBuffer[3]);
        Serial.println(sendBuffer[4]); 
//        wifi.releaseTCP(); 
    } 
    else
    {
      Serial.println("sendwifi Not ok");  
    }
//  }
//  else
//  {
//    Serial.println("sendwifi Not create");  
//  }
}
void SendData_via_BLUETOOTH(byte data[])
{
//  if(BT.available())
//  {
//    BT.write(data,sizeof(data));
//  }
}
void SendData_via_SERIAL(byte data[])
{
  if(Serial.available())
  {
    Serial.write(data,DataLength);
    Serial.flush();
  } 
}

void CloseConnection_Wifi()
{
  if (wifi.releaseTCP()) 
  {
    Serial.println("Release tcp [OK]");
  } 
  else 
  {
    Serial.println("Release tcp [ERR]");
  }
}
