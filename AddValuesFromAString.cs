using System;
					
public class Program
{
	public static void Main()
	{
		/*Add the values of a given string given by parameter. Letter U represents positive 1, and D represents negative one.*/
		
		int result = 0;
		
    //assigned a variable to function in main class since it's the entry point
   
   //01 Happy path test
		result = sumOfAllLetters("UDDUUU");
		Console.WriteLine("Total is " + result);
//-----------------------------------------------------------
  //Start - other tests

   /*Negative scenario 02- Add a letter that is not U or D
    -Expected result = it should still be 2.
    */
   result = sumOfAllLetters("UDDUUUI");
   Console.WriteLine("Total is with another letter " + result);
	

  /*
    03 Add a space - should still be 2
  */
	
   result = sumOfAllLetters("UDDUU U");
   Console.WriteLine("Total is with a space " + result);

    /*
    04 Add a number - should still be 2
  */
	
   result = sumOfAllLetters("UDDUU2U");
   Console.WriteLine("Total is with number " + result);

    /*
    04 Add a symbol - should still be 2
  */
	
   result = sumOfAllLetters("UDDUU$U");
   Console.WriteLine("Total is with symbol" + result);

    /*
    05 Lower case D and U  - should add up to 0
  */
	
   result = sumOfAllLetters("udduuu");
   Console.WriteLine("Total should be zero for lower case 'd' and 'u' " + result);
  }

  //Method for string
	public static int sumOfAllLetters(string letters)
	{
		int sum = 0; 
		
    //
		for(int position =0; position < letters.Length; position++)
		{
      //if the value at a given position is "U", then add 1.
			if( letters [position] == 'U' )
			{
				sum = sum + 1;	
			}
      //Does nothing if value is other than 'U' or 'D'  
			else { 

        //if it is a "D" subtract -1
        if(letters [position] == 'D')
          {
            	sum = sum - 1;
          }
			}
      //Printing in this method alone, won't print anything. Method has to be called from main entry point
			Console.WriteLine($"position {position} sum {sum}");
		}
		return sum;
	}
 }