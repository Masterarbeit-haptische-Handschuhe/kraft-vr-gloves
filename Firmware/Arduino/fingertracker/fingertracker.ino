int thumb = A7; //white
int middle = A6; //blue
int ring = A5; //violet
const int flexPin = A4;

int thumbVal = 0, middleVal = 0, ringVal = 0;

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  int flexValue; 
  flexValue = analogRead(flexPin);
  thumbVal = analogRead(thumb);
  middleVal = analogRead(middle);
  ringVal = analogRead(ring);
  Serial.print(thumbVal);
  Serial.print(",");
  Serial.print(flexValue);
  Serial.print(",");
  Serial.print(middleVal);
  Serial.print(",");
  Serial.print(ringVal);
  Serial.println();
  delay(20);
}
