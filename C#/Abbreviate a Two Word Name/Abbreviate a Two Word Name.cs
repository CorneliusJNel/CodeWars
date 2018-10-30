public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] arr = name.ToUpper().Split(" ");
    return arr[0].Substring(0, 1) + "." + arr[1].Substring(0, 1);
  }
}