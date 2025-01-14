using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int number;

        static void Welcome(){
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName(){
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber(){
            Console.Write("Enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int favNumber){
            return favNumber * favNumber;
        }
        static void DisplayResult(string uName = "Guess", int favNumber = 0){
            Console.WriteLine($"{uName}, the square of your number is: {favNumber}");
        }


        Welcome();
        name = PromptUserName();
        number = PromptUserNumber();
        DisplayResult(name , SquareNumber(number));

    }
}