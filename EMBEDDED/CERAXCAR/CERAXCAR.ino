

int len_BT = 0;
byte receivedBuffer[3] = {0};  
byte sendBuffer[3] = {0}; 
int DataLength = 3;

void setup()
{
  Serial.begin(9600);
  Serial3.begin(9600); // Bluetooth
  pinMode(13,OUTPUT);
  sendBuffer[0] = 0x10;
}

void loop() 
{
  ListenBluetooth();
  PeriodicSend_5000();
  PeriodicSend_3000(); 
}


void ListenBluetooth()
{  
  if(Serial3.available())
  {
           
    len_BT = Serial3.readBytes(receivedBuffer,DataLength);
    if (len_BT > 0)
    {
        int value = (int)receivedBuffer[2];
        digitalWrite(13,value);         
    }
  }    
}

unsigned long T_PC_5000 = 0;
void PeriodicSend_5000()
{
  if (millis() - T_PC_5000 > 5000)
    {
      //Functions Area----------
      
      SendBatteryValue();
      SendMotorTempValue();
      SendEngineStatus();
      SendOilStatus();
      //Functions Area----------     
      T_PC_5000 = millis();
    }
}


unsigned long T_PC_3000 = 0;
void PeriodicSend_3000()
{
  if (millis() - T_PC_3000 > 3000)
    {
      //Functions Area----------
      
      //SendEngineStatus();
      
      //Functions Area----------     
      T_PC_3000 = millis();
    }
}

//---------------------------

void SendCenter(byte sendBuffer[])
{
  if(Serial3.availableForWrite())
  {  
    Serial3.write(sendBuffer,DataLength);
    Serial3.flush();
  }
}


void SendBatteryValue()
{        
    int r = random(0,240);             
    sendBuffer[1] = 0x05;
    sendBuffer[2] = (byte)r;
    SendCenter(sendBuffer);                       
}

void SendMotorTempValue()
{        
    int r = random(0,240);             
    sendBuffer[1] = 0x06;
    sendBuffer[2] = (byte)r;
    SendCenter(sendBuffer);        
}

bool x = false;
void SendEngineStatus()
{  
    x = !x;      
    sendBuffer[1] = 0x04;
    sendBuffer[2] = (byte)x; 
    SendCenter(sendBuffer);           
}
void SendOilStatus()
{            
    sendBuffer[1] = 0x03;
    sendBuffer[2] = (byte)x; 
    SendCenter(sendBuffer);           
}
