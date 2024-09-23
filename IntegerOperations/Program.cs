using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber;
        int divisionResult = sum / thirdNumber;
        int finalResult = divisionResult * fourthNumber;

        Console.WriteLine(finalResult);
    }
}
