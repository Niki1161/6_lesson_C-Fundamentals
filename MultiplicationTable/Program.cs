namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int result1 = n * 1;
            //int result2 = n * 2;
            //int result3 = n * 3;
            //int result4 = n * 4;
            //int result5 = n * 5;
            //int result6 = n * 6;
            //int result7 = n * 7;
            //int result8 = n * 8;
            //int result9 = n * 9;
            //int result10 = n * 10;  

            //Console.WriteLine($"{n} X 1 = {result1}");
            //Console.WriteLine($"{n} X 2 = {result2}");
            //Console.WriteLine($"{n} X 3 = {result3}");
            //Console.WriteLine($"{n} X 4 = {result4}");
            //Console.WriteLine($"{n} X 5 = {result5}");
            //Console.WriteLine($"{n} X 6 = {result6}");
            //Console.WriteLine($"{n} X 7 = {result7}");
            //Console.WriteLine($"{n} X 8 = {result8}");
            //Console.WriteLine($"{n} X 9 = {result9}");
            //Console.WriteLine($"{n} X 10 = {result10}");








            for ( int i = 1; i <= 10; i++ )
            {
                int result = n * i;

                Console.WriteLine($"{n} X {i} = {result}");

            }
        }
    }
}