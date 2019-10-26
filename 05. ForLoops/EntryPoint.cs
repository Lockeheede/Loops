using System;
class EntryPoint
{
    //The for loop is similar to the while loop, but with less writing. The for loop always increases on an int value
    //While the while is based on booleans
    static void Main()
    {
        Random rand = new Random();
        int number = 10;

        for(int i = 1; i <= number; i++)//The i is the indexing variable that is used to operate against another value
            //It can be a variable (number) or another number
        {
            Console.WriteLine(i);
        }
        //Challenge: Create an integer array and output all of its elements using a for loop
        int[] numbers = {0,1,4,5,7,8,9,12,1111 };

        for(int i = 0; i < numbers.Length; i++)
        {
            //You can multiple the number in the index by the index: numbers[i] *= i; 
            
            Console.WriteLine($"Current index is {i}, current element is {numbers[i]}");
            
        }
        //Solution: When using arrays in for loops, first you need actual values. You increase along
        //The indexing variable, putting it's increase as a location holder for the array
        //ie: since i starts at 0, you are starting at the 1st index
        //If it was something else, like i=3, we would get the 4th index of the array

        //You use the .Length operator on numbers in case the array changes

        int[] randNumbers = new int[10];
        for (int i = 0; i < randNumbers.Length; i++)
        {
            //You can generate random numbers for an undeclared set of numbers in an array
            randNumbers[i] = rand.Next(1,777);
            Console.WriteLine($"The current index is {i}, it's random number is {randNumbers[i]}");
        }

        int[] byNumNumbers = { 5, 6, 7, 8, 33, 36, 33, 39, 44, 1111, 666, 777, 86, 83, 24, 21, 4, 69, 63, 64, 52, 51, 55, 9 };
        for (int i = 0; i < byNumNumbers.Length; i++)
        {
            //You can post each number that is an even index number. Remember if a number divided by a modulus equals 0 and it
            //is two, it is even, or one, it is odd.
            if(i % 2 == 0)
            {
                Console.WriteLine($"The current index is {i}, an even number. It's element is {byNumNumbers[i]}");
            }
        }
        for(int i = 0; i < byNumNumbers.Length; i++)
        {
            if(i % 3 == 0)
            {
                //Or each index that is by three. 
                Console.WriteLine($"The current index is {i}, a number by three. It's element is {byNumNumbers[i]}");
            }
        }
        

    }
}

