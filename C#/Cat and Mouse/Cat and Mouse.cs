using System;

public class Kata
{
  public static string CatMouse(string x)
  {
    int distance =  catDistance(x);
    if (distance <= 3) return "Caught!";
    else return "Escaped!";
  }
  public static int catDistance(string g)
  {
    int count = 0;
    int flag = 0;
    char[] arr = g.ToCharArray();
    for(int i = 0; i < arr.Length; i++)
    {
      if(arr[i] == 'C')
      {
        for(int j = i ; j < arr.Length; j++)
        {
          if(arr[j] != 'm')count++;
          else
          {
            flag = 1;
            break;
          }
        }
      }
      if(flag == 1)break;
    }
    return count - 1;
  }
}