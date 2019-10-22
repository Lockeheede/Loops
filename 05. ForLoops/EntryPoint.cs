using System;
class EntryPoint
{
    //The for loop is similar to the while loop, but with less writing. The for loop always increases on an int value
    //While the while is based on booleans
    static void Main()
    {
        int number = 10;

        for(int i = 0; i < number; i++)//The i is the indexing variable that is used to operate against another value
            //It can be a variable (number) or another number
        {
            Console.WriteLine(i);
        }

    }
}

