using System;
class EntryPoint
{
    /*Using nested loops, create a calendar for the year of 2020. 
     * Hint, make two string arrays: 1 for the Months and 1 for the Days
     * A couple of nested loops and a couple of conditional statements
     */

    static void Main()
    {
        Console.WriteLine("2020 Calendar");
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int daysInAMonth = 31;
        int dayType = 0;

        for (int currentMonth = 0; currentMonth < months.Length; currentMonth++)
        {

            Console.Write($"Month: {months[currentMonth]}");
            Console.WriteLine();

            //One thing the instructor forgot to do was put in the code to make the month start on the right day
            //This little piece makes the month of January start with dayType of 2 which is a Wednesday.
            if (currentMonth == 0)
            {
                dayType = 2;
            }
           

            for (int currentDay = 1; currentDay <= daysInAMonth; currentDay++)
            {
                Console.WriteLine($"{currentDay} {days[dayType]}");

                dayType++;

                if (dayType == 7)
                {
                    dayType = 0;
                }

                if ((currentMonth == 1 && currentDay == 29) ||
                    (currentMonth == 3 && currentDay == 30) || (currentMonth == 5 && currentDay == 30) || (currentMonth == 8 && currentDay == 30) || (currentMonth == 10 && currentDay == 30))
                {
                    break;
                }

            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

}












               
                

