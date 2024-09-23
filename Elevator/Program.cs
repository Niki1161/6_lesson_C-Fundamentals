using System;

class Program
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine()); 
        int elevatorLimit = int.Parse(Console.ReadLine()); 

        int courses = (int)Math.Ceiling((double)peopleCount / elevatorLimit);


        Console.WriteLine(courses);
        //if(courses == 1)
        //{
        //    Console.WriteLine("All the persons fit inside in the elevator.");
        //    Console.WriteLine("Only one course is needed.");
        //}
        //else
        //{
        //    Console.WriteLine(courses);
        //}
        //Console.WriteLine(courses);
    }
}
