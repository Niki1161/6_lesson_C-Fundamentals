namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var str = Console.ReadLine();
            //var sum = str.Sum(x => char.GetNumericValue(x));
            //Console.WriteLine(sum);

            //string number = Console.ReadLine();
            //

            //Console.WriteLine(digit);

            string number = Console.ReadLine();

            for (int i = 0; i < args.Length; i++)
            {
                
                char digit = number[number.Length - 1];
                int sum = digit + digit;
                Console.WriteLine(sum);
            }

            
        }
    }
}