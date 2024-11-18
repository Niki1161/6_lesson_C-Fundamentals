namespace Substring
{
    internal class Program
    {
        //static void Main1(string[] args)
        //{
        //    string toRemove = Console.ReadLine();
        //    string text = Console.ReadLine();

        //    while (true)
        //    {
        //        int index = text.IndexOf(toRemove);

        //        if (index != -1)
        //        {
        //            text = text.Remove(index,toRemove.Length);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    Console.WriteLine(text);
        //}


        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (true)
            {
                text = text.Replace(toRemove, string.Empty);

                if (!text.Contains(toRemove))
                {
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}