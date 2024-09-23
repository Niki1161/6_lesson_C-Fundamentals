using System;

class VacationCalculator
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();

        double pricePerPerson = 0;

        if (groupType == "Students")
        {
            if (dayOfWeek == "Friday") pricePerPerson = 8.45;
            else if (dayOfWeek == "Saturday") pricePerPerson = 9.80;
            else if (dayOfWeek == "Sunday") pricePerPerson = 10.46;
        }
        else if (groupType == "Business")
        {
            if (dayOfWeek == "Friday") pricePerPerson = 10.90;
            else if (dayOfWeek == "Saturday") pricePerPerson = 15.60;
            else if (dayOfWeek == "Sunday") pricePerPerson = 16.00;
        }
        else if (groupType == "Regular")
        {
            if (dayOfWeek == "Friday") pricePerPerson = 15.00;
            else if (dayOfWeek == "Saturday") pricePerPerson = 20.00;
            else if (dayOfWeek == "Sunday") pricePerPerson = 22.50;
        }

        double totalPrice = peopleCount * pricePerPerson;

        if (groupType == "Students" && peopleCount >= 30)
        {
            totalPrice -= totalPrice * 0.15;
        }
        else if (groupType == "Business" && peopleCount >= 100)
        {
            totalPrice -= pricePerPerson * 10; 
        }
        else if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
        {
            totalPrice -= totalPrice * 0.05;
        }

        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}
