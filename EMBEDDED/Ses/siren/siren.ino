

int i=0;
void setup() {
  // put your setup code here, to run once:
pinMode(8, OUTPUT); 
}

void loop() {
  for(i=700;i<800;i++){   // for police siren
  tone(8,i);
  delay(15);
  }
  for(i=800;i>700;i--){
  tone(8,i);
  delay(15);
  }

}
