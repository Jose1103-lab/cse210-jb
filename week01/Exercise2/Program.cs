using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade: ");
        string grade = Console.ReadLine();
        int realGrade = int.Parse(grade);
        string finalGrade = "";

        if (realGrade > 90){
            if (realGrade < 93 ){
                finalGrade = "-A";
            }
            else{
                finalGrade = "A";
            }
        }
        else if (realGrade > 80){
            if (realGrade < 83 ){
                finalGrade = "-B";
            }
            else if (realGrade >= 87){
                finalGrade = "+B";
            }
            else{
                finalGrade = "B";
            }
        }
        else if (realGrade > 70){
            if (realGrade < 73 ){
                finalGrade = "-C";
            }
            else if (realGrade >= 77){
                finalGrade = "+C";
            }
            else{
                finalGrade = "C";
            }
        }
        else if (realGrade > 60){
            if (realGrade < 73 ){
                finalGrade = "-D";
            }
            else if (realGrade >= 67){
                finalGrade = "+D";
            }
            else{
                finalGrade = "D";
            }
        }
        else{
            finalGrade = "F";
        }
        
        Console.WriteLine($"Grade for the course: {finalGrade}");

        

    }
}