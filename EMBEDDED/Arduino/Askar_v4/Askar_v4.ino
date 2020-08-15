
#include <AFMotor.h> // motor shild in ktpnsi 
#include <Servo.h>  /* Servo kutuphanesi projeye dahil edildi */
#include <dht11.h> // sıcaklık sensoru
#include <Wire.h> // Ivme sensorunun
#include <I2Cdev.h> //I2C kütüphanesini ekledik
#include <MPU6050.h> //Mpu6050 kütüphanesi ekledik

#define DHT11PIN 22

dht11 DHT11;

MPU6050 ivme_sensor; // sensörümüze ivme_sensor adını verdik
int16_t ax, ay, az; //ivme tanımlama
int16_t gx, gy, gz; //gyro tanımlama

unsigned long T_SMTD = 0, T_BlueLed = 0, T_4Led = 0, T_Cyro = 0, T_Bluetooth = 0, T_SerialPort = 0, T_Speed = 0;

Servo direksiyon;
int direksiyonDerecesi=90;
AF_DCMotor motorMain(2, MOTOR12_8KHZ); // Ana motor

const int U_FrontLeft_T = 39;
const int U_FrontLeft_E = 41;
const int U_FrontFront_T = 35;
const int U_FrontFront_E = 37;
const int U_FrontRight_T = 45;
const int U_FrontRight_E = 43;

const int U_RightFront_T = 47;
const int U_RightFront_E = 49;
const int U_RightBack_T = 53;
const int U_RightBack_E = 51;

const int U_LeftFront_T = 31;
const int U_LeftFront_E = 33;
const int U_LeftBack_T = 25;
const int U_LeftBack_E = 23;

const int U_BackLeft_T = 32;
const int U_BackLeft_E = 30;
const int U_BackRight_T = 36;
const int U_BackRight_E = 34;

volatile float distance, duration;
byte dataSerialPort = 0x00;
//char receivedBTdata = '0';
bool thereIsReceivedData = false;
int carSpeed = 0;
byte SpeedControlMode = 0x02;
bool LockBlink4Leds=false;

byte sendData[5];
byte receivedData[10];
int readLength=5;
//***********************************************************************************SETUP

void setup()
{
  //Serial SerialPort
  //Serial1 Bluetooth

  InitializeSetLed();
  InitializeSetDirection();
  InitializeSetMotor();
  InitializeSetSensors();

  Wire.begin();
  Serial.begin(9600); //Seri haberleşme başlatılır
  Serial1.begin(9600);// BLUETOOTH  Haberleşme Protokolü Serial1
  ivme_sensor.initialize();
  
 
}

//***********************************************************************************LOOP

void loop()
{
  P_SendMotorTempData();
  // BlueLedShow();
  //if(LockBlink4Leds){Blink4Leds();}
 
  
  // P_SendCyroData();
  CheckBluetoothConnection();
  //CheckSerialPortConnection();
 // P_SpeedControlUnit();

   //checkDistance(U_LeftFront_T, U_LeftFront_E);

}



//****************************************************************************
//****************************************************************************Initializations
//****************************************************************************
void InitializeSetLed()
{
  //********** LEDs ********************
  pinMode (40, OUTPUT); // geri led
  pinMode (27, OUTPUT); // sisler led
  pinMode (24, OUTPUT); // ön mavi led
  pinMode (52, OUTPUT); // sol sinyal
  pinMode (50, OUTPUT); // sag sinyal
  pinMode (48, OUTPUT); // uzunlar led
  pinMode (46, OUTPUT); //kisalar led
  pinMode (44, OUTPUT); // acik stoplar led
  pinMode (42, OUTPUT); // koyu stoplar led

}
void InitializeSetDirection()
{
  //********** Direction ********************
  direksiyon.attach(9); // direksiyon
  direksiyon.write(direksiyonDerecesi); // direksiyon açısı
}
void InitializeSetMotor()
{
  //********** Main Motor ********************
  motorMain.setSpeed(0);
  motorMain.run(RELEASE);
}

void InitializeSetSensors()
{
  //**********Distance Sensors****************
  pinMode(U_FrontLeft_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_FrontLeft_E, INPUT);
  pinMode(U_FrontFront_T, OUTPUT); // sensörleri tanıtılması
  pinMode(U_FrontFront_E, INPUT);
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

}
//****************************************************************************
//****************************************************************************Periodic Controls
//****************************************************************************
void P_SendCyroData()
{
  if (millis() - T_Cyro > 200)
  {
    ivme_sensor.getMotion6(&ax, &ay, &az, &gx, &gy, &gz); // ivme ve gyro değerlerini okuma
    Serial.print(ax); Serial.print("\t");
    Serial.print(ay); Serial.print("\t");
    //Serial.print(az); Serial.print("\t");
    Serial.print(gx); Serial.print("\t");
    Serial.print(gy); Serial.print("\t");
    //Serial.print(gz); Serial.println("\t");
    T_Cyro = millis();
  }
}

void P_SendMotorTempData()
{
  if (millis() - T_SMTD > 3000)
  {
    //Serial.println("\n");
    int chk = DHT11.read(DHT11PIN);
    //Serial.print("Nem (%): ");
    //Serial.println((byte)DHT11.humidity); // virgulden sonrası kac sıfır olacagını belirtmek icin

    //Serial.print("Sicaklik (Celcius): ");
    //Serial.println((byte)DHT11.temperature);

    //Serial.print("Cig Olusma Noktasi: ");
    //Serial.println(DHT11.dewPoint(), 2);

    sendData[0]=0x16;
    sendData[1]=0x03;
    sendData[2]=(byte)DHT11.humidity;
    sendData[3]=(byte)DHT11.temperature;
    Serial1.write(sendData,5);
    Serial.println((byte)DHT11.temperature);
    T_SMTD = millis();
  }
}

void P_SpeedControlUnit()
{

  if (thereIsReceivedData == false)
  {
    if (carSpeed > 0)
    {
      switch (SpeedControlMode)
      {
        case 0x00://Low Slow
          {

          } break;

        case 0x01://Slow
          {

          } break;

        case 0x02://Normal
          {
            if (millis() - T_Speed > 50)
            {
              carSpeed--;
              T_Speed = millis();
            }


          } break;

        case 0x03://Fast
          {

          } break;

        case 0x04://Very Fast
          {

          } break;


      }
 Serial.println(carSpeed);
    }
     motorMain.setSpeed(carSpeed);
  }
  
  


}

//****************************************************************************
//****************************************************************************Functions
//****************************************************************************
void CheckSerialPortConnection()
{
  if (millis() - T_SerialPort > 11)
  {
    if (Serial.available())
    {
      dataSerialPort = Serial.read();
      Serial.println(dataSerialPort);
      switch (dataSerialPort)
      {
        case 0x01:
          {
            digitalWrite(24, HIGH);
            dataSerialPort = '*';
          } break;
        case 0x00:
          {
            digitalWrite(24, LOW);
            dataSerialPort = '*';
          } break;
      }

    }
    T_SerialPort = millis();
  }


}



void CheckBluetoothConnection()
{
  if (millis() - T_Bluetooth > 5)
  {
    if (Serial1.available()) // eğer Bluetooth ta Bağlantı var ise
    {
      //digitalWrite(24, HIGH);
      thereIsReceivedData = true;
      Serial1.readBytes(receivedData,readLength);
      Serial.write(Serial1.read());
        if(receivedData[0]==0x16) // checksum Control
        {
          switch (receivedData[1]) // Address
          {
            case 0x00://MotorRunStop
            {
              if(receivedData[2] ==0x01 )//On
              {
               digitalWrite(42, HIGH);
               digitalWrite(46, HIGH);
              }
              else //Off
              {
               digitalWrite(24,LOW); //led durumunu değiştir
               digitalWrite(40,LOW);
               digitalWrite(27,LOW);
               digitalWrite(50,LOW);
               digitalWrite(52,LOW);
               digitalWrite(42,LOW);
               digitalWrite(44,LOW);
               digitalWrite(46,LOW);
               digitalWrite(48,LOW);
              }                    
            }break;
              case 0x01://uzunlar
             {
              if(receivedData[2] ==0x01 )//On
              {
                digitalWrite(48, HIGH);
              }
              else //Off
              {
                digitalWrite(48, LOW);
              }                    
            }break;
             case 0x02://kisalar
            {
              if(receivedData[2] ==0x01 )//On
              {
               digitalWrite(46, HIGH);
               
              }
              else //Off
              {
                digitalWrite(46, LOW);
             
              }                    
            }break;
             case 0x03://sisler
            {
              if(receivedData[2] ==0x01 )//On
              {
               digitalWrite(27, HIGH);
              }
              else //Off
              {
                digitalWrite(27, LOW);
              }                    
            }break;
             case 0x04://sol sinyal
            {
              if(receivedData[2] ==0x01 )//On
              {             
                  digitalWrite(52,HIGH);
                  digitalWrite(50,LOW);   
              }
              else //Off
              {              
                  digitalWrite(52,LOW);
                  
              }                    
            }break;
             case 0x05://sag sinyal
            {
              if(receivedData[2] ==0x01 )//On
              {                
                  digitalWrite(50,HIGH);  
                  digitalWrite(52,LOW);              
              }
              else //Off
              {               
                  digitalWrite(50,LOW);               
              }                    
            }break;
              case 0x06://dortluler
            {
              if(receivedData[2] ==0x01 )//On
              {
                 // LockBlink4Leds =true;
                  digitalWrite(50,HIGH);
                  digitalWrite(52,HIGH);
              }
              else //Off
              {
                 // LockBlink4Leds =false;
                  digitalWrite(50,LOW);
                  digitalWrite(52,LOW);
              }                    
            }break;
            case 0x07://stop abs
            {
              if(receivedData[2] ==0x01 )//On
              {
               digitalWrite(44, HIGH);
              }
              else //Off
              {
                digitalWrite(44, LOW);
              }                    
            }break;
             case 0x08://back light
            {
              if(receivedData[2] ==0x01 )//On
              {
               digitalWrite(40, HIGH);
              }
              else //Off
              {
                digitalWrite(40, LOW);
              }                    
            }break;
             case 0x10://speed
            {
                if(receivedData[3]==0x01)
              {
                motorMain.run(FORWARD); 
              }
              else
              {
                motorMain.run(BACKWARD); 
              }
              carSpeed=(int)receivedData[2];
              motorMain.setSpeed(carSpeed);                          
            }break;
            case 0x11://Turn Left
            {
              if(receivedData[2] ==0x01 )//Turn
              {
                if(direksiyonDerecesi<180)
                {
                   //direksiyonDerecesi++;
                   //direksiyon.write(direksiyonDerecesi); // direksiyon açısı
                   direksiyon.write(180);
                }
                 
              }
                              
            }break;
             case 0x12://Turn Right
            {
              if(receivedData[2] ==0x01 )//Turn
              {
                if(direksiyonDerecesi>0)
                {
//                   direksiyonDerecesi--;
//                   direksiyon.write(direksiyonDerecesi); // direksiyon açısı
                    direksiyon.write(0);
                }
              }
                              
            }break;
         
          }
        
       }
    } 
    T_Bluetooth = millis();
  }
}



void checkDistance(int TP, int EP) {
  digitalWrite(TP, LOW);  //para generar un pulso limpio ponemos a LOW 4us
  delayMicroseconds(4);
  digitalWrite(TP, HIGH);  //generamos Trigger (disparo) de 10us
  delayMicroseconds(10);
  digitalWrite(TP, LOW);
  duration = pulseIn(EP, HIGH);
  distance = duration * 10 / 292 / 2;  //convertimos a distancia, en cm
  Serial.print("Distance: ");
  Serial.print(distance);
  Serial.println(" cm");
}

void Blink4Leds()
{
  if (millis() - T_4Led > 800)
  {
    digitalWrite(50, !digitalRead(50));
    digitalWrite(52, !digitalRead(52));
    T_4Led = millis();
  }
}

void BlueLedShow()
{
  if (millis() - T_BlueLed > 50)
  {
    digitalWrite(24, !digitalRead(24)); //led durumunu değiştir
    //    digitalWrite(40, !digitalRead(40));
    //    digitalWrite(27, !digitalRead(27));
    //    digitalWrite(50, !digitalRead(50));
    //    digitalWrite(52, !digitalRead(52));
    //    digitalWrite(42, !digitalRead(42));
    //    digitalWrite(44, !digitalRead(44));
    //    digitalWrite(46, !digitalRead(46));
    //    digitalWrite(48, !digitalRead(48));

    T_BlueLed = millis();
  }
}
