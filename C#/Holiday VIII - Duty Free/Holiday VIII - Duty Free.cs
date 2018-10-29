public class Kata
{
  public static int DutyFree(int normPrice, int Discount, int hol)
  {
    return (int)(hol/(normPrice* ((double)Discount / 100)));
  }
}