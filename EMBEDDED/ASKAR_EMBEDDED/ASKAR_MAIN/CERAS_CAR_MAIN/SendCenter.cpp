#include "SendCenter.h"

void SendCenter::Send(byte ID,byte MID,byte TID,byte value)
{  
  
    sendData[0]=DataCheckSum;
    sendData[1]=ID;// ID = Header:0 | Remote:1
    sendData[2]=MID;//MID Module ID Systems
    sendData[3]=TID;//TID Target ID Units
    sendData[4]=value;//Value
    Serial2.write(sendData,DataLength);  
    Serial2.flush();        
}
