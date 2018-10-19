using System;

public class Kata
{
 public static int SquareDigits(int n)
	  {
		string numbers = n.ToString(); // Converting to strign to split numbers later
		char[] individual = numbers.ToCharArray(); //Splitting numbers in char array
		string output = "";  //Final output var for to be converted for return
		for(int i = 0; i < individual.Length; i++){ // Squaring the individual numbers 
			double num = Char.GetNumericValue(individual[i]);
			int numSq = Convert.ToInt32(num * num);
			output += numSq; // Appending output string
		}
		int square = Convert.ToInt32(output); //converting output for required return var
		return square;
	  }
}