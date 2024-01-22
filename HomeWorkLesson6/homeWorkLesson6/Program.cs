string number = "28";
byte numberByte =byte.Parse(number);
nint numberNint = numberByte;
int numberInt = (int)numberNint;
long numberLong = (long)numberInt;
double numberDouble = (double)numberLong;
Console.WriteLine($"{number}\n{numberByte}\n{numberNint}\n{numberInt}\n{numberLong}\n{numberDouble}");