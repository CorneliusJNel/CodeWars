using System;

public static class Kata
{
  public static bool IsLeapYear(int year)
  {
    bool isLeap = false;
    if(year%4 == 0)
    {
      if(year%100 == 0)
      {
        if(year%400 == 0) isLeap =true;
        else isLeap= false;
      }
      else isLeap = true;
    }
    return isLeap;
  }
}