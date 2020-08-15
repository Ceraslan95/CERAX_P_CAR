//#include "SysMotor.h"
//
// 
//
//SysMotor::SysMotor()
// { 
//   
//   cDirection.attach(Pin_Direction); // direksiyon
//   cDirection.write(90); // direksiyon açısı
//      
////   motorFront.run(RELEASE);  
////   motorBack.run(RELEASE);
//   Serial.println("System Motor initialized");
//  }
//
//  
//  
//  void SysMotor::LocalLoop()
//  {
//
//  }
//  
//  void SysMotor::SolveData(byte TAddress ,byte value)
//  {
//    switch(TAddress)
//    {
//      
//
//
//    }
//  }
//
//  void SysMotor::SetDirectionAngle(byte dAngle)
//  {
//    _dAngle = (int)dAngle;
//    if(_dAngle >= 0 && _dAngle <= 180)
//    {
//      cDirection.write(_dAngle);
//    }
//    
//  }
//
////  void SysMotor::SetMotorPower(byte mPower)
////  {
////    switch(mPower)
////    {
////      case 0x00 ://stop
////      {
////        motorFront.run(RELEASE);
////        motorBack.run(RELEASE);
////      }break;
////      case 0x01 ://4x4 ileri
////      {
////        motorFront.run(FORWARD);
////        motorBack.run(FORWARD);
////      }break;
////      case 0x02 ://4x4 geri
////      {
////        motorFront.run(BACKWARD);
////        motorBack.run(BACKWARD);
////      }break;
////      case 0x03 ://onden cekisli ileri
////      {
////        motorFront.run(FORWARD);
////        motorBack.run(RELEASE);
////      }break;
////      case 0x04 ://arkadan itisli ileri
////      {
////        motorFront.run(RELEASE);
////        motorBack.run(FORWARD);
////      }break;
////      case 0x05 ://onden itisli geri
////      {
////        motorFront.run(BACKWARD);
////        motorBack.run(RELEASE);
////      }break;
////      case 0x06 ://arkadan cekisli geri
////      {
////        motorFront.run(RELEASE);
////        motorBack.run(BACKWARD);
////      }break;
////    }
////  }
//
//  void SysMotor::SetMotorSpeed(byte mSpeed)
//  {
//    _mSpeed = (int)mSpeed;
//    if(_mSpeed >= 0 && _mSpeed <= 255)
//    {
////      motorFront.setSpeed(_mSpeed);
////      motorBack.setSpeed(_mSpeed);
//    }
//  }
