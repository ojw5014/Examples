/*
 * Test FlySky IBus interface on an Arduino Mega.
 *  Connect FS-iA6B receiver to Serial1.
 */
 
#include "FlySkyIBus.h"
#include <SoftwareSerial.h>

SoftwareSerial mySerial(3, 2); // RX, TX
 
void setup() 
{
  Serial.begin(57600);
  mySerial.begin(115200);
  IBus.begin(mySerial);//Serial);
}

void loop() 
{
  IBus.loop();
  /*
  int i = 0;
  int nLast = 10;
  for (i = 0; i < nLast; i++)
  {    
    Serial.print(IBus.readChannel(i), HEX);
    Serial.print(" , ");
  }
  Serial.println(IBus.readChannel(nLast), HEX);
  //Serial.println(" ");
  */
  int nSeq = 0;
  int nVal;
  int nCount = 6;
  for (int i = 0; i < nCount; i++)
  {
    nVal = IBus.readChannel(i)/8;
    
    //nVal_L = nVal & 0xff;
    //nVal_H = nVal >> 8 & 0xff;
    
    Serial.write(0xff);
    Serial.write(0x55);
    Serial.write(nSeq);
    Serial.write((nSeq ^ 0xff) & 0xff);
    Serial.write(nVal);
    Serial.write((nVal ^ 0xff) & 0xff);
    //Serial.print(nVal, HEX);  
    //Serial.print(',');
    nSeq++;
  }
  //Serial.println(".");
  

 //////////////////
 
  /*  
  Serial.print(0xff,HEX);
  Serial.print(0x55,HEX);
  Serial.print(val1,HEX);
  Serial.print((val1 ^ 0xff) & 0xff,HEX);
  Serial.print(val0,HEX);
  Serial.println((val0 ^ 0xff) & 0xff,HEX);
  */
}
