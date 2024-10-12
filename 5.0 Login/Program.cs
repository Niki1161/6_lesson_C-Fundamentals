namespace _5._0_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string correctPassword = string.Empty;
            for (int i = userName.Length-1; i >= 0; i--)
            {               
                correctPassword += userName[i];
            }
            int attempts = 4;

            while (attempts > 0)
            {
                attempts -= 1;
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == correctPassword)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (attempts == 0)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }

        }
    }
}