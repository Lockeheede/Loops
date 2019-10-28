using System;
    class EntryPoint
    {
        static void Main()
        {
        //foreach is a derivitive of the foor loop that uses an item element and works on arrays
        int[] array = { 1, 2, 3, 4, 5, 6, 777, 8, 9, 10, 1111 };

        foreach (var item in array)//where the item is the element of the array collection
        {//typing foreach and tab twice makes the loop automatically
            //the item is an element used each time there is an item in the array
            Console.WriteLine(item);
            //The item is being printed off as each iteration of itself in the array
            //The difference between a foreach and a for loop is that the foreach loop 
            // goes through all the elements. for loops have more options including all the elements
        }
        }
    }

