using System.Linq;
namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
    {
      int[] arr = input;
      for(int i = 0; i < arr.Length;i++) arr[i] = -(arr[i]);
      return arr;
    }
  }
}