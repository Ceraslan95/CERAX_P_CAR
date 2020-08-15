#include <Arduino.h>

#ifndef SysLed_h
#define SysLed_h

#define p_LedLongs A4 //ok
#define p_LedShorts A5 //ok
#define p_LedStopsDark A2 //ok
#define p_LedStopsLight A3 //ok
#define p_Lazer 13 //A6
#define p_LedSpots 12 //A7
#define p_LedLSignal 5 //ok
#define p_LedRSignal 4 //ok
//#define p_LedFLSignal 7 //ok
//#define p_LedFRSignal 6 //ok


#define A_LedAllOffOn 0x00
#define A_LedLongs 0x01
#define A_LedShorts 0x02
#define A_LedStopDark 0x04
#define A_LedStopLight 0x03
#define A_LedLeftsSignal 0x05
#define A_LedRightsSignal 0x06
//#define A_LedFLSignal 0x08
//#define A_LedFRSignal 0x07
//#define A_LedBLSignal 0x0C 
//#define A_LedBRSignal 0x09
#define A_Lazer 0x0A
#define A_LedSpots 0x0B



class SysLed
{

  public:
  SysLed();
  void SolveData(byte TID,byte value);
    
  private :
  void ChangeLED(int LED ,byte value,byte AD);
    
};

#endif
