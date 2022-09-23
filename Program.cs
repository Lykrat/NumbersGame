using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random=new Random();
            //Creates a random number between 1 and 20
            int TargetNumber = random.Next(1,21);
            //Creates a variable that I will use later
            int Attempts = 0;

            //Loops for a total of five times
            for (int i=0;i<5;i++)
            {
                //Can input a number each loop
                int Guess=Int32.Parse(Console.ReadLine());
                //Sends away the correct answer and the Guess to a method wich returns True or False
                if (CheckGuess(Guess,TargetNumber)) {
                    //If its correct it does not display the to many wrongs line and breaks the loop
                    Attempts = 1;
                    break;
                }
            }
            //If Attepempts has not changed after the loop it gives you game over
            if (Attempts !=1)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }
        }
        //A method that checks the answer and returns a bool
        static bool CheckGuess(int Guess,int TargetNumber)
        {
            if (Guess == TargetNumber)
            {
                //Correct Guess returns True
                Console.WriteLine("Woho! Du gjorde det!");
                return true;
            }
            //Wrong guess returns False and says if the correct number is higher or lower
            else if (Guess > TargetNumber)
            {
                Console.WriteLine("Tyvärr du gissade för högt!");
                return false;
            }
            else
            {
                Console.WriteLine("Tyvärr du gissade för lågt!");
                return false;
            }
        }
    }
}
