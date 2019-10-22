using System;
class EntryPoint
{
    //A do-while loop is exactly the same as a while loop with a slight difference

    static void Main()
    {
        int firstNumber = 4;
        int endNumber = 10;

        do
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        } while (firstNumber <= endNumber);
        //The difference is you do the loop at least once and then you check if the information is correct and continue
        //So, even if the firstNumber was bigger than the endNumber, it would still work at least once.
    }
}

