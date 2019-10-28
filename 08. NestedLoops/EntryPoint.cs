using System;
class EntryPoint
{    static void Main()
    {
        /*for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(i);
            }//For everytime the the outer loop goes one time, the inner loop goes 10 times
            //So if you were to use a console.write using polymorphism, you could put the iterations 
            //on a striaght line. Or a Console.WriteLine() outside the inner loop to make a space after
            //each tenth line, making a gride
        }*/
        for (int i = 9; i > 0; i--)//notice the new choice of element to start at 9 instead of 0 and go down by 1 using --
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }        
        //You can even make to make matrices
        //A matrix is data that can be defined in rows and columns
        //Matrices can be added as long as the rows and columns are equal
        //While they can (sort of) be multiplied as long as the columns of the first
        //Matrix equals the rows of the second (m*n)-matrix * (n*p)-matrix = (m*p)-matrix
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Console.Write($"Index[{i}][{j}] ");
            }
            Console.WriteLine();
        }
    }
}

