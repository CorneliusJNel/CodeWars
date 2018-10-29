public class Kata
{
  public static bool SmallEnough(int[] a, int limit)
  {
    bool isSmall = true;
    foreach(int element in a)
    {
      if(element>limit)
      {
        isSmall = false;
        break;
      }
    }
    return isSmall;
  }
}