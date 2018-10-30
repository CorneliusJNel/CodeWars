public class Kata
{
  public static string Greet(string name, string owner)
  {
    if(name.Equals(owner))return "Hello boss";
    return "Hello guest";
  }  
}