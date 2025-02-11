using System;
class Program
{
    static void Main(string[] args)
    {
        bool execution = true;
        Console.WriteLine("This is the Mindfulness Project.");

        while (execution == true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═════════════════╗\n║ Mindfulness App ║\n╚═════════════════╝");
            Console.ResetColor();
            Console.WriteLine("Menu Option");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Listing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Breathing Activity");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4. Close App");
            Console.ResetColor();

            try
            {
                Console.Write("\nEnter an option: ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            ListingActivity activity = new ListingActivity("Breathing", "will guide you through a series of deep breathing exercises to help you relax and focus.", 5 );
                            // activity.DisplayStartingMessage(); //? include this in the run function
                            activity.Run();
                            Console.ReadLine(); //! include this in the run function FIXME: Included here for testing purposes
                            break;
                        }
                    case 2:
                        {
                            ReflectionActivity activity = new ReflectionActivity("Breathing", "will guide you through a series of deep breathing exercises to help you relax and focus.", 5 );
                            activity.Run();
                            break;
                        }
                    case 3:
                        {
                            BreathingActivity activity = new BreathingActivity("Breathing", "will guide you through a series of deep breathing exercises to help you relax and focus.", 5 );
                            activity.Run();
                            break;
                        }
                    case 4:
                        {
                            execution = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You input should be a number from 1-4");
                            Console.Write("Press Enter to continue...");
                            Console.ReadLine();
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You input should be a number from 1-4");
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}