using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    string sentenceRev = "";
		string[] words = str.Split(" ");
    for(int i = 0; i < words.Length; i++)
    {
      string  wordRev = "";
      char[] letters = words[i].ToCharArray();
      for(int j = letters.Length-1; j >= 0; j--)
      {
        wordRev += letters[j];
      }
      sentenceRev += wordRev + " ";
    }
    return sentenceRev.Trim();
  }
}