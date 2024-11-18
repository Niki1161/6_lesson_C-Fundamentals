namespace SumOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            int sum = 0; 

            int currentOdd = 1; 

            for (int i = 1; i <= n; i++)  
            {
                Console.WriteLine(currentOdd);  
                sum += currentOdd;  
                currentOdd += 2; 
            }

            Console.WriteLine("Sum: " + sum);  
        }
    }
}