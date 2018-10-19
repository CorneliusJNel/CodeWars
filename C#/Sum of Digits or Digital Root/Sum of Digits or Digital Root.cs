public class Number
{
  public int DigitalRoot(long n)
  {
    int num = (int)n;
    bool singleDigit = true;
    bool negative = false;
    if(num < 0)
    {
      negative = true;
      num = num *(-1);
    }
    do
    {
      if(num < 10)
      {
        break;
      }
      num = FindNum(num, negative);
      negative = false;
    }while(singleDigit);
    return num;
  }
  
  public int FindNum(int input, bool neg)
  {
    string numbers = input.ToString();
		char[] individual = numbers.ToCharArray();
		int sum = 0;
    if(neg)
    {
      for (int i = 0; i < individual.Length; i++)
  		{
  			double num = char.GetNumericValue(individual[i]);
			int number = (int)num;
			if(i==0) number = number *(-1);
  			sum  += number;
  		}
    }
    else
    {
  		for (int i = 0; i < individual.Length; i++)
  		{
  			double num = char.GetNumericValue(individual[i]);
			int number = (int)num;
  			sum  += number;
  		}
    }
		return sum;
  }
}