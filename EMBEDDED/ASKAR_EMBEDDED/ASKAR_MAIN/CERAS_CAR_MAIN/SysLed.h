#include <Arduino.h>

#ifndef SysLed_h
#define SysLed_h

#define p_LedBack 40
#define p_LedBlue 24
#define p_LedFogs 31 // test edilecek


#define TID_LedAllOnOff 0x00
#define TID_LedBlue 0x01
#define TID_LedFogs 0x02
#define TID_LedBack 0x03


class SysLed
{
  public:
 
    SysLed();
    //void LocalLoop();
    void SolveData(byte TID ,byte value);
    void SetLedBack(byte value);
    void SetLedBlue(byte value);
    void SetLedFogs(byte value);
    
  private:
      
    void ChangeLED(int LED ,byte value);


    // selektor yap
    //yuksek hizda uzunlari ac
    //acil durumda 4luleri ac
    //geri cikma ledini yak 

};

#endif
