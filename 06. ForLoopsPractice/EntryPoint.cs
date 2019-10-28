using System;
class EntryPoint
{
    static void Main()
    {
        int choice = 0;
        bool newChoice = false;
        string[] characters = new string[100];
        int chosenCharacter = 0;//This was in case 2 but was changed into a global variable so it can be used across all cases
        //Remember, global variables are in the main function outside of loops. Local variables inside of loops and other 
        //functions can only be used within said loops and variables

        Console.Write("This is a character collection system." +
                "\nYou can add up to 100 characters. " +
                "\nFollow the directions.\n");

        while (!newChoice)
        {
                Console.Write("1. Add Character" +
                "\n2. Edit Character" +
                "\n3. Remove Character" +
                "\n4. View Character List" +
                "\n5. Exit" +
                "\nYour Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch(choice)
            {

                case 1://Adding a character
                    //Use refracting > extract method or ctrl + r + m to make an automatic custom method
                    //Just highlight the entire method and do the quick key
                    AddItem(characters);
                    Console.WriteLine();
                    break;

                case 2://Editing an added character

                    chosenCharacter = EditItem(characters);
                    break;


                case 3://Removing an added character
                    chosenCharacter = RemoveItem(characters);
                    break;

                case 4://Viewing character list
                    ViewItem(characters);

                    break;

                case 5:
                    newChoice = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice, please choose between 1 and 4!");
                    break;
            }
        }
    }
   
    //Automatically created methods end up being created underneath the main method
    private static void ViewItem(string[] characters)
    {
        Console.WriteLine("Current characters :");
        for (int i = 0; i < characters.Length; i++)//If you type for and press tab twice it makes an automatic for loop method
        {
            if (characters[i] != null)
            {
                Console.WriteLine($"{i + 1} : {characters[i]}");
            }
        }
        Console.WriteLine();
    }

    private static int RemoveItem(string[] characters)
    {
        int chosenCharacter;
        Console.Write("Which character do you want to remove? Between (1-100): ");
        chosenCharacter = Convert.ToInt32(Console.ReadLine());
        if (characters[chosenCharacter - 1] != null)
        {
            Console.Write($"The character you chose is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(characters[chosenCharacter - 1]);
            Console.ResetColor();
            characters[chosenCharacter - 1] = null;
            Console.WriteLine("It is now empty!");

            //Create a tempArray that will hold the new null character array index
            //If you don't, when you add a new element, if the null one was before
            //A filled one, a new added element will be the ahead of the filled one
            string[] tempArray = new string[characters.Length];
            int tempArrayIndex = 0;

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] != null)
                {
                    //In this case, the loop tests to see if the character is not null
                    tempArray[tempArrayIndex] = characters[i];
                    //If it is it skips this loop, but if it isn't, the tempArrayIndex
                    //increases by 1, bringing the character up one in the list
                    //Until it is no longer a null value
                    tempArrayIndex++;
                }
            }
            //Use the array class and copy method to move an array into another array
            Array.Copy(tempArray, characters, tempArray.Length);
        }
        else
        {
            Console.WriteLine("That is an empty character. Try again");
        }
        Console.WriteLine();
        return chosenCharacter;
    }

    private static int EditItem(string[] characters)
    {
        int chosenCharacter;
        Console.Write("Which character do you want to edit? Between (1-100): ");
        chosenCharacter = Convert.ToInt32(Console.ReadLine());
        if (characters[chosenCharacter - 1] != null)
        {
            Console.Write($"The character you chose is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(characters[chosenCharacter - 1]);
            Console.ResetColor();
            Console.WriteLine("What would you like to change it to?");
            characters[chosenCharacter - 1] = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That is an empty character. Try again");
        }
        Console.WriteLine();
        return chosenCharacter;
    }

    private static void AddItem(string[] characters)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] == null)
            {
                Console.WriteLine("Please add a new character.");
                characters[i] = Console.ReadLine();
                break;
            }

        }
    }
}

