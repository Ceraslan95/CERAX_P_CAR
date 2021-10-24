

void setup()
{
  Serial.begin(9600);
  Serial3.begin(9600); // Bluetooth
}

void loop() 
{
  ListenBluetooth();
}

uint8_t len_BT = 0;
uint8_t receivedBuffer[5] = {0};  
uint8_t sendBuffer[5] = {0}; 
uint8_t DataLength = 5;
void ListenBluetooth()
{  
  if(Serial3.available())
  {
    int  v = Serial3.read();
    Serial.println(v);
    
//    len_BT = BT.readBytes(receivedBuffer,DataLength);
//    
//    Serial.println("Length : "); Serial.print(len_BT); 
//    if (len_BT > 0)
//    {
//       Serial.println("Received Data -----------------");   
//       Serial.println("Length : "); Serial.print(len_BT); 
//       Serial.println("0 : "); Serial.print(receivedBuffer[0]);   
//       Serial.println("1 : "); Serial.print(receivedBuffer[1]);    
//       Serial.println("2 : "); Serial.print(receivedBuffer[2]);             
//    }
  }    
}
