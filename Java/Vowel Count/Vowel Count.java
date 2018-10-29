using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
      int vowelsCount = 0;
      char[] arrVowel = { 'a', 'e', 'i', 'o','u' };
      char[] charStr = str.ToCharArray();
      for (int i = 0; i < charStr.Length; i++)
      {
        for (int j = 0; j < arrVowel.Length; j++)
        {
          if (charStr[i] == arrVowel[j]) vowelsCount++;
        }
      }
      return vowelsCount;
    }
}