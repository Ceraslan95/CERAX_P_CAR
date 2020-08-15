#include <Arduino.h>

#ifndef SysProteciton_h
#define SysProteciton_h

#include "SendCenter.h"

#define TID_AP_Protection 0x00
#define FrontMiddle 0x01
#define FrontRight 0x02
#define FrontLeft 0x03
#define RightFront 0x04
#define LeftFront 0x05
#define RightBack 0x06
#define LeftBack 0x07
#define BackRight 0x08
#define BackLeft 0x09

#define TID_ProWX1 0x0A
#define TID_ProWX2 0x0B
#define TID_ProMode 0x0C

class SysProtection
{
  public:

    SysProtection();
    void LocalLoop();
    void SolveData(byte TID ,byte value);

  private:
    
    SendCenter sendC;
    void Set_protectionWidth_X2(byte value);
    void Set_protectionMode(byte value);
    void Set_AP_Protection(byte value);
    void Set_DistanceBuffer();
    bool Get_AP_Protection();
    byte Get_protectionMode();
    unsigned char Get_protectionWidth_X2();
    unsigned char CheckDistance(unsigned char TP, unsigned char EP);


    int HZ_ProtectionSys = 0;

    const unsigned char U_FrontFront_T = 35;
    const unsigned char U_FrontFront_E = 37;

    const unsigned char U_FrontLeft_T = 39;
    const unsigned char U_FrontLeft_E = 41;
    const unsigned char U_FrontRight_T = 45;
    const unsigned char U_FrontRight_E = 43;

    const unsigned char U_RightFront_T = 47;
    const unsigned char U_RightFront_E = 49;
    const unsigned char U_RightBack_T = 53;
    const unsigned char U_RightBack_E = 51;

    const unsigned char U_LeftFront_T = 31;
    const unsigned char U_LeftFront_E = 33;
    const unsigned char U_LeftBack_T = 25;
    const unsigned char U_LeftBack_E = 23;

    const unsigned char U_BackLeft_T = 32;
    const unsigned char U_BackLeft_E = 30;
    const unsigned char U_BackRight_T = 36;
    const unsigned char U_BackRight_E = 34;

    volatile float distance;
    volatile float duration;
    unsigned char distances[9];
    //0 FrontMiddle
    //1 FrontRight
    //2 FrontLeft
    //3 RightFront
    //4 LeftFront
    //5 RightBack
    //6 LeftBack
    //7 BackRight
    //8 BackLeft
    unsigned char distanceBufferCount=0;

    boolean AP_Protection = false;
    unsigned char protectionWidth_X1 = 10;
    unsigned char protectionWidth_X2 = 20;
    byte protectionMode = 0x00;
    unsigned char widthFront = 0;

};

#endif
