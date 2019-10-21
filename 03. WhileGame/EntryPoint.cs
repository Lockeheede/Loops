using System;
using System.Threading;

class EntryPoint
{
static void Main()
{
Console.Title = "The Battle System v0.0.1";

var rand = new Random();
string[] characters = { "Lockes The Thief", "Meek RatFace" };

Thread.Sleep(15000);
Console.WriteLine($"This is a battle system in the works! \n" +
    $"{characters[0]} versus {characters[1]}. \n" +
    $"In 5...");
Thread.Sleep(1000);
Console.WriteLine("4...");
Thread.Sleep(1000);
Console.WriteLine("3...");
Thread.Sleep(1000);
Console.WriteLine("2...");
Thread.Sleep(1000);
Console.WriteLine("1...");
Console.WriteLine("Begin!");
Thread.Sleep(500);
        //Make stats like HP, SP, ATK, sATK, DEF, sDEF, PER, INT, AGL, END, CHM, and LUK 
        //But also make chakra levels such as Crown (Spirituality), Third Eye (Awareness), Throat (Communication), Heart (Love/Healing), Solar Plexus (Wisdom/Power), Sacral (Sexuality/Creativity), and Root (Basic/Trust)
        //Then have them revolve around the three attribute points - Mind, Body, and Spirit
        //Leveling up enough attribute points will then increase a character's overall level, giving access to higher level gear, bonuses, achievements, unlocks, etc
double ThiefHP = 300;
double ThiefATK = 25;
double ThiefSPL = 40;
        //Next time make the options CharacterOptions so each specific character can be used with $""
string[] ThiefOptions = { "ThiefRegular", "ThiefRegular2", "ThiefSpecial", "ThiefSpecial1", "ThiefSpecial2" };
        //Note for the game. Maybe always have two regular attacks and two special attacks at a minimum? 
        //Potentially for the idea that most gaming controllers have 4 face buttons

double RatHP = 100;
double RatATK = 50;
double RatSPL = 10;

string[] RatOptions = { "RatRegular", "RatRegular1", "RatSpecial", "RatSpecial1" };

int move = 0;
int tMove = rand.Next(ThiefOptions.Length);
int rMove = rand.Next(RatOptions.Length);

bool attackPhase = true;
bool isThiefDead = false;
bool isRatDead = false;

while (attackPhase)
{
    //Use the randomizer to determine who attacks
    int attacker = rand.Next(characters.Length);
            //In the future you can use rand.Next(1,100) to do a random range of 1-100 etc. 

    //After the character is chosen, use another randomizer to determine what kind of attack
    if (ThiefHP > 0 && RatHP > 0)
    {
            if (characters[attacker] == characters[0])
            {
                move = rand.Next(ThiefOptions.Length);
                if (ThiefOptions[move] == ThiefOptions[0])
                {
                    RatHP = RatHP - (ThiefATK * .10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{characters[0]} hit {characters[1]} with an attack!\n" +
                        $"{characters[1]} HP = {RatHP}");
                    Thread.Sleep(3000);
                }
                else if ((ThiefOptions[move] == ThiefOptions[1]))
                {
                    RatHP = RatHP - (ThiefATK * .20);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{characters[0]} hit {characters[1]} with an attack!\n" +
                        $"{characters[1]} HP = {RatHP}");
                    Thread.Sleep(3000);
                }
                else if ((ThiefOptions[move] == ThiefOptions[2]))
                {
                    RatHP = RatHP - (ThiefSPL * 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{characters[0]} hit {characters[1]} with a special!\n" +
                        $"{characters[1]} HP = {RatHP}");
                    Thread.Sleep(3000);
                }
                else if ((ThiefOptions[move] == ThiefOptions[3]))
                {
                    RatHP = RatHP - (ThiefSPL * 1.25);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{characters[0]} hit {characters[1]} with a special!\n" +
                        $"{characters[1]} HP = {RatHP}");
                    Thread.Sleep(3000);
                }
                else if ((ThiefOptions[move] == ThiefOptions[4]))
                {
                    RatHP = RatHP - (ThiefSPL * 1.50);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{characters[0]} hit {characters[1]} with a special!\n" +
                        $"{characters[1]} HP = {RatHP}");
                    Thread.Sleep(3000);
                }



                else if (characters[attacker] == characters[1])
                {
                    move = rand.Next(RatOptions.Length);
                    if (RatOptions[move] == RatOptions[0])
                    {
                        ThiefHP = ThiefHP - (RatATK * .10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{characters[1]} hit {characters[0]} with an attack!\n" +
                        $"{characters[0]} HP = {ThiefHP}");
                        Thread.Sleep(3000);
                    }
                    else if (RatOptions[move] == RatOptions[1])
                    {
                        ThiefHP = ThiefHP - (RatATK * .15);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{characters[1]} hit {characters[0]} with an attack!\n" +
                        $"{characters[0]} HP = {ThiefHP}");
                        Thread.Sleep(3000);
                    }
                    else if (RatOptions[move] == RatOptions[2])
                    {
                        ThiefHP = ThiefHP - (RatSPL * .50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{characters[1]} hit {characters[0]} with an special!\n" +
                        $"{characters[0]} HP = {ThiefHP}");
                        Thread.Sleep(3000);
                    }
                    else if (RatOptions[move] == RatOptions[3])
                    {
                        ThiefHP = ThiefHP - (RatSPL * 1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{characters[1]} hit {characters[0]} with an special!\n" +
                        $"{characters[0]} HP = {ThiefHP}");
                        Thread.Sleep(3000);
                    }
                }
                    Console.ResetColor();

            }

                //Determine if one or another character is now dead
                if (ThiefHP <= 0 || RatHP <= 0)
            {
                if (ThiefHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{characters[0]} has died! ");
                    isThiefDead = true;
                    attackPhase = false;
                    Thread.Sleep(3000);
                }
                else if (RatHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{characters[1]} has died! ");
                    isRatDead = true;
                    attackPhase = false;
                    Thread.Sleep(3000);
                }
            }
               
                   
        }
    }

    
                //Game over screen
                if (isThiefDead == true)
                {
                    Console.WriteLine($"Game over for {characters[0]}!! \n" +
                        $"{characters[1]} lives on with {RatHP} HP left. \n" +
                        $"The city is under mind control!");
                           
                }
                else if (isRatDead == true)
                {
                    Console.WriteLine($"Game over for {characters[1]}!! \n" +
                        $"{characters[0]} lives on with {ThiefHP} HP left. \n" +
                        $"The will of the city is free forever!");     
                }
       /* Use and fix this code to try to repeat the game over. Eventually you would
        * need to find a way to give users a list of characters to choose from, as well
        * as more than two characters in combat (or healing) and targetting systems. 
        * Console.Write("Would you like to start the game over? Y/N: ");
        string startOver = Console.ReadLine();
        if(startOver == "Y" || startOver == "y" || startOver == "yes")
        {
            Console.Clear();
            Console.WriteLine("Game starting in 5 seconds.");
            ThiefHP = 300;
            RatHP = 100;
            Thread.Sleep(5000);
            isThiefDead = false; isRatDead = false; attackPhase = true;
        }
        else if(startOver == "N" || startOver == "n" || startOver == "no")
        {
            Console.WriteLine("Game Over.");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }*/
    }
}
            
        
 

 
    

