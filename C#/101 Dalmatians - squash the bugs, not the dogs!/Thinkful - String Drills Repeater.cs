public static class Kata
{
    public static string HowManyDalmatians(int n)
    {
      string howMany = "";
        if (n <= 10) howMany = "Hardly any";
        else if (n <= 50) howMany = "More than a handful!";
        else if (n == 101) howMany = "101 DALMATIONS!!!";
        else howMany = "Woah that's a lot of dogs!";
        return howMany;
    }
}