using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.\n\n");

        MathAssignment example = new MathAssignment("Jose", "Science", "O'Reilly", "Me quemé");
        WritingAssigment example2 = new WritingAssigment("Juan", "Arts", "The book of Mormon");



        Console.WriteLine("-----------------------\n" + example.GetHomeworkList());
        Console.WriteLine("-----------------------\n" + example2.GetWritingInformation());
         
    }
}