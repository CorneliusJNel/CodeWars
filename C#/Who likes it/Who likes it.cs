using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string result = "";
    if(name.Length == 1)
    {
      result = name[0] + " likes this";
    }
    else if(name.Length == 2)
    {
      result = name[0] + " and " + name[1] +" like this";
    }
    else if(name.Length == 3)
    {
      result = name[0] + ", " + name[1] + " and " + name[2] +" like this";
    }
    else if(name.Length >= 4)
    {
      result = name[0] + ", " + name[1] + " and " + (name.Length - 2)  +" others like this";
    }
    else
    {
      result = "no one likes this";
    }
    return result;
  }
}