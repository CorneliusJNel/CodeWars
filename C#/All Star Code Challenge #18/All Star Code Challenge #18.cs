class Kata
{
    public static int StrCount(string str, string letter)
    {
        int count = 0;
        char l = letter[0];
        foreach(char c in str)if(c==l)count+=1;
        return count;
    }
}