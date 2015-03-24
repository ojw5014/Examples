#define LED 13
#define INS_QUICK 10
#define INS_SLOW 11
void setup() {
  pinMode(LED, OUTPUT);
  pinMode(INS_QUICK, OUTPUT);
  pinMode(INS_SLOW, OUTPUT);
  //Serial.begin(9600);
  Serial.begin(115200);
}

void loop() {
  if(Serial.available()) {
    char command = Serial.read();
    Serial.println("Serial Command");
    switch(command) {
      case'0': //Insert(Quick)
        {
          digitalWrite(INS_SLOW, LOW);
          digitalWrite(INS_QUICK, HIGH);
          Serial.println("Insert(Quick).");
          break;
        }
      case'1': //Eject
        {
          //Next : LED Blink Loop
          digitalWrite(INS_QUICK, HIGH);
          digitalWrite(INS_SLOW, HIGH);
          Serial.println("Eject.");
          break;
        }
      case'2': //Stop
        {
          digitalWrite(INS_SLOW, LOW);
          digitalWrite(INS_QUICK, LOW);
          Serial.println("Stop.");
          break;
        }
      case'3': //Insert(slow)
        {
          //digitalWrite(LED, HIGH);
          digitalWrite(INS_QUICK, LOW);
          digitalWrite(INS_SLOW, HIGH);
          Serial.println("Insert(Slow).");
          break;
        }
      default:
        {
          Serial.print("Wrong command : ");
          Serial.println(command);
        }
    }
  }
}
