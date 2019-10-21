using System;
using System.Threading;

class EntryPoint
{
static void Main()
{
        //While challenge. A good note, make min and max variables so they can be changed on the fly
        //Set numbers become hard to change if you need to change the code along the way
        //But variables are good for changing all the info in one setting
        //As long as you use the WriteLine($""); operation
        int number = 0;
        int min = 652;
        int max = 777;
        bool isNumberInRange = false;
       

        while(!isNumberInRange)
        {
            Console.Write($"Input a number in the range of {min} and {max} to win: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= min && number <= max)
            {
                isNumberInRange = true;
            }
            else
            {
                if(number == 420)
                {
                    Console.WriteLine("That's a lucky number for a select few...");
                }
                else if (number == 1111)
                {
                    Console.WriteLine("You see this number way too much for it to be normal \n" +
                        "But then again...there are only 10 numbers to choose from...\n" +
                        "24 hours a day, 60 minutes and hour, 60 seconds a minute\n" +
                        "So, what are the odds? I'd calculate it for you...");
                    Thread.Sleep(5000);
                    Console.WriteLine("but I haven't learned that much yet.");
                    Thread.Sleep(5000);
                }
                Console.WriteLine($"Please enter a number between {min} and {max}. The number {number} is not valid!");
                Thread.Sleep(2000); //Pauses the console in milliseconds. Use System.Threading
                Console.Clear(); //Clears the console
            }
        }
        //Just when the number is in the range of 777. Remember if the ranges are changed and 777 is not an option, this needs to be changed.
        if (number != 777)
        {
            Console.WriteLine($"Good work! You entered {number} which is between {min} and {max}!");
        }
        else if(number == 777)
        {
            Console.WriteLine("Jackpot!");
            Console.WriteLine($"Good work! You entered {number} which is between {min} and {max}!");
        }
      
    }
}
