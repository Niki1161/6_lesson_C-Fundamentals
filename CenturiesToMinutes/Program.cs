using System;

class Program
{
    static void Main()
    {        
        int centuries = int.Parse(Console.ReadLine());

        int yearsPerCentury = 100;    
        double averageDaysPerYear = 365.2422;  
        int hoursPerDay = 24;         
        int minutesPerHour = 60;      
        
        double totalYears = centuries * yearsPerCentury;
        
        double totalDays = Math.Round(totalYears * averageDaysPerYear, 0);

        double totalHours = totalDays * hoursPerDay;

        double totalMinutes = totalHours * minutesPerHour;

        Console.WriteLine($"{centuries} centuries = {totalYears} years = {(int)totalDays} days = {(int)totalHours} hours = {(int)totalMinutes} minutes");
    }
}
