using System;
public static class Kata
{
  public static int MakeNegative(int number)
  {
    if(number < 0) return number;
    if(number > 0) return number * (-1);
    return 0;
  }
}