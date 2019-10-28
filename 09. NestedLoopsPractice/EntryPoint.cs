using System;
class EntryPoint
{
    /*Using nested loops, create a calendar for the year of 2020. 
     * Hint, make two string arrays: 1 for the Months and 1 for the Days
     * A couple of nested loops and a couple of conditional statements
     */

    static void Main()
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int numOfDays = 1;
        //30 days have September, April, June and November
        bool thirtyDays = false;
        //All the rest have 31
        bool thirtyOneDays = false;
        //Except February all alone (27)
        bool isItFebruary = false;

        for (int i = 0; i < months.Length; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
            {
                thirtyOneDays = true;
            }
            else if (i == 4 || i == 6 || i == 9 || i == 11)
            {
                thirtyDays = true;
            }
            else
            {
                isItFebruary = true;
            }

            if (i == 1)
            {
                Console.WriteLine("January");

                for (int j = 2; j < days.Length;)
                {
                    if (thirtyOneDays == true)
                    {

                        Console.Write(numOfDays + " " + days[j] + "\n");
                        numOfDays++;
                        j++;
                        if (j == 7)
                        {
                            j = 0;
                        }
                        if (numOfDays > 31)
                        {
                            break;
                        }


                    }
                }
                
            }
        }
    }
}












               
                

