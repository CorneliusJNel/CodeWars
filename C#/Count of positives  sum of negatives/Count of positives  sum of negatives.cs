using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
      if (input == null || input.Length == 0)return new int[0];
      else
      {
        int sumNeg = 0, count = 0;
        foreach(int i in input)
        {
          if(i > 0) count+=1;
          else sumNeg += i;
        }
        int[] arr = {count,sumNeg};
        return arr;
      }
    }
}