

void setup()
{
  Serial.begin(9600);
  Serial3.begin(9600); // Bluetooth
  pinMode(13,OUTPUT);
}

void loop() 
{
  ListenBluetooth();
  PeriodicSend_5000();
  PeriodicSend_3000();
  
}

int len_BT = 0;
byte receivedBuffer[3] = {0};  
//byte sendBuffer[3] = {0}; 
int DataLength = 3;
void ListenBluetooth()
{  
  if(Serial3.available())
  {
    //int  v = Serial3.read();
    
    
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
void SendBatteryValue()
{
  if(Serial3.availableForWrite()){
        
        int r = random(0,240);
        byte sendBuffer[3] = {0}; 
        sendBuffer[0] = 0x10;
        sendBuffer[1] = 0x05;
        sendBuffer[2] = (byte)r;
        Serial3.write(sendBuffer,DataLength);
        Serial3.flush();
        Serial.println(sendBuffer[2]);             
      }
}

bool x = false;
void SendEngineStatus()
{
   if(Serial3.availableForWrite()){
        x = !x;
        byte sendBuffer[3] = {0}; 
        sendBuffer[0] = 0x10;
        sendBuffer[1] = 0x04;
        sendBuffer[2] = (byte)x;
        Serial3.write(sendBuffer,DataLength);
        Serial3.flush();  
   }
}
