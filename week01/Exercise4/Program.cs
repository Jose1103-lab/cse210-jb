using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Exercise NO.4.");
        List<int> data = new List<int>();
        int smallerNumber = 100000000;
        float average = 0;
        int largest = 0; 
        
        do{
            Console.WriteLine("Enter a number to save it: ");
            int entry = int.Parse(Console.ReadLine());
            if (entry == 0){
                average = average / data.Count;
                data.Sort();  //stretch challenge
                Console.WriteLine();
                break;
            }
            if (entry < smallerNumber && entry > 0){//stretch challenge
                smallerNumber = entry;
            }
            else if (entry > largest){
                largest = entry;
            }
            average += entry; 
            data.Add(entry);  
            
        }while(true);
    
        foreach (int item in data)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"The largest isL: {largest}");
        Console.WriteLine($"The smallest isL: {smallerNumber}");        
        Console.WriteLine($"The average isL: {average}");        
    }
}