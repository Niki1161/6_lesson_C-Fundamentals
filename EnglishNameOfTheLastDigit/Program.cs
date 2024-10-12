namespace EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            string res = Spell(input);

            Console.WriteLine(res);
        }

        static string Spell (string number)
        {
            string result = string.Empty;
            
            char digit = number[number.Length - 1];

            if (digit == '0')
            {
                result = "zero";
            }
            else if (digit ==  '1')
            {
                result = "one";
            }
            else if (digit == '2')
            {
                result = "two";
            }
            else if (digit == '3')
            {
                result= "three";
            }
            else if (digit == '4')
            {
                result = "four";
            }
            else if (digit == '5')
            {
                result = "five";
            }
            else if (digit == '6')
            {
                result = "six";
            }
            else if (digit == '7')
            {
                result = "seven";                
            }else if (digit == '8')
            {
                result = "eight";                
            }else if (digit == '9')
            {
                result = "nine";                
            }


            return result;
        }
    }
}