namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      string repeat = "";
      for(int i = 0; i < n; i++)
      { 
        repeat += s;  
      }
      return repeat;
    }
  }
}