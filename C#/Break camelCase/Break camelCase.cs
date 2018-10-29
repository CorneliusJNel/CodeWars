public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
      if (char.IsUpper(str[i]))result += " ";                    
      result += str[i].ToString();
    }
    return result;
  }
}