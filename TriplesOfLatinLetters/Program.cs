namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            char initial = 'a';

            char firstLetter = ' ';
            char secondLetter = ' ';
            char thirdLetter = ' ';

            for (int i = 0; i < number; i++) // a
            {
                //firstLetter = (char)(initial + i);
                
                for (int j = 0; j < number; j++)  // a
                {
                    //secondLetter = (char)(initial + j);

                    for (int k = 0; k < number; k++) // a
                    {
                        firstLetter = (char)(initial + i);
                        secondLetter = (char)(initial + j);
                        thirdLetter = (char)(initial + k); // aaa

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");

                    }
                    
                }
                
                
            }
        }

        
    }
}