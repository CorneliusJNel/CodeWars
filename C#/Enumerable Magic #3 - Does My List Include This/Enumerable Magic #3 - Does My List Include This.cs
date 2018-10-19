public class Kata
{
  public static bool Include(int[] arr, int item)
  {
    bool included = false;
    for(int i = 0; i < arr.Length; i++)
    {
      if(arr[i] == item) included = true;
    }
    return included;
  }
}