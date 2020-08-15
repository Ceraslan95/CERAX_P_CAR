//
//
//#include <Arduino.h>
//
//
//#ifndef SysMotor_h
//#define SysMotor_h
//
//
//
//#include <Servo.h>  /* Servo kutuphanesi projeye dahil edildi */
//#include <AFMotor.h>
//#define Pin_Direction 9
//
//#define Pin_FrontMotor 2
//#define Pin_BackMotor 4

#define TID_speedValue 0x01
#define TID_directionAngle 0x02
#define TID_motorPower 0x03
//
//AF_DCMotor motorFront(Pin_FrontMotor); // on motor
//AF_DCMotor motorBack(Pin_BackMotor); // arka motor
//
//class SysMotor 
//{
//    
//  public:
// 
//    SysMotor();
//    void LocalLoop();
//    void SolveData(byte TAddress ,byte value);
//
//  void SetMotorPower(byte mPower)
//  {
//    switch(mPower)
//    {
//      case 0x00 ://stop
//      {
//        motorFront.run(RELEASE);
//        motorBack.run(RELEASE);
//      }break;
//      case 0x01 ://4x4 ileri
//      {
//        motorFront.run(FORWARD);
//        motorBack.run(FORWARD);
//      }break;
//      case 0x02 ://4x4 geri
//      {
//        motorFront.run(BACKWARD);
//        motorBack.run(BACKWARD);
//      }break;
//      case 0x03 ://onden cekisli ileri
//      {
//        motorFront.run(FORWARD);
//        motorBack.run(RELEASE);
//      }break;
//      case 0x04 ://arkadan itisli ileri
//      {
//        motorFront.run(RELEASE);
//        motorBack.run(FORWARD);
//      }break;
//      case 0x05 ://onden itisli geri
//      {
//        motorFront.run(BACKWARD);
//        motorBack.run(RELEASE);
//      }break;
//      case 0x06 ://arkadan cekisli geri
//      {
//        motorFront.run(RELEASE);
//        motorBack.run(BACKWARD);
//      }break;
//    }
//  }
//  private:
//    
//    void SetDirectionAngle(byte dAngle);
//    //void SetMotorPower(byte mPower);
//    void SetMotorSpeed(byte mSpeed);
//
//    
//
//    int _dAngle;
//    int _mSpeed;
//    Servo cDirection;
//    
//
//};
//
//#endif
