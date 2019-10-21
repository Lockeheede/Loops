using System;
class EntryPoint
{
static void Main()
{
        //Loops are needed to make the process of computer programming easier and managable
        //If you need to do an operation 1000 times, you don't want to make 1000 sets of code
        //keyword (condition)
        //{
        //  Conducted action as long as condition is true
        //}
        //example
        //keyword (notFull)
        //{
        //keep eating
        //}
        //
        //This particular loop is a while loop. A counter is needed and is added at the end of each action while it is in the loop
        Console.WriteLine("I am learning loops!");
        int counter = 0;
        while (counter < 10)
        {  
            Console.WriteLine($"This is going to happen {10 - counter} more times.");
            if(counter == 9)
                Console.WriteLine($"This is going to happen {10 - counter} more time.");
            counter++;
        }


}
}
