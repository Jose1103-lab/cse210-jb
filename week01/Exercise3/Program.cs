using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool guessed = false;
        int attempts = 0;  

        do
        {
            
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 50);
            Console.WriteLine("Magic number picked ");

            while (guessed == false)
            {   
                attempts++; //stretch requirements
                Console.WriteLine();
                Console.WriteLine("What is your guess? ");

                string imput2 = Console.ReadLine(); 
                int guess = int.Parse(imput2);         


                if (guess < magic){
                    Console.WriteLine("Greater");
                }
                else if(guess > magic){
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine("You guessed it");
                    Console.WriteLine($"Total attempts: {attempts}");
                    break;
                }
            }
            Console.WriteLine("Play again? [Y/N]"); //stretch requirements
            string playAgain = Console.ReadLine();
            
            if (playAgain == "n" || playAgain == "N"){
                Console.WriteLine("Thanks for playing");
                break;
            }
        } while (true);


    }
}