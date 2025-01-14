class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        string lname = Console.ReadLine();
        
        Console.WriteLine($"Welcome {lname.ToUpper()}, {fname.ToUpper()} {lname.ToUpper()} ");
        //I will add the fucntion to capitalize the first letter
    }
}