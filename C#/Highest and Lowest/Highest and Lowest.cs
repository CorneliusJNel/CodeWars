using System;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    return Low(numbers) + " " + High(numbers);
  }
  public static int Low(string numbers)
  {
    string[] num = numbers.Split(" ");
    int low = Int32.Parse(num[0]);
    for(int i = 1; i < num.Length; i++)
    {
      int x = Int32.Parse(num[i]);
      if(x > low) low = x;
    }
    return low;
  }
  public static int High(string numbers)
  {
    string[] num = numbers.Split(" ");
    int high = Int32.Parse(num[0]);
    for(int i = 1; i < num.Length; i++)
    {
      int x = Int32.Parse(num[i]);
      if(x < high) high = x;
    }
    return high;
  }
}