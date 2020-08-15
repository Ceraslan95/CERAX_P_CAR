#include <Arduino.h>

#ifndef SendCenter_h
#define SendCenter_h

#define DataLength 5
#define DataCheckSum 0x16

class SendCenter
{
   public:
     void Send(byte ID,byte MID,byte TID,byte value);
   private:    
     byte sendData[DataLength];  
};

#endif
