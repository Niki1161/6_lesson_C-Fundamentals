namespace TheLift3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int seats = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                int freePlaces = seats - lift[i]; // find free places in current cabin

                if (peopleWaiting >= freePlaces) // Waiting are more than free places
                {
                    peopleWaiting -= freePlaces;  // reduce the waiting people 
                    lift[i] += freePlaces;    // load people on the free places
                }
                else // waiting are less than free places
                {
                    lift[i] += peopleWaiting;
                    peopleWaiting = 0;
                    break;
                }
                
                
            }

            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                PrintLift(lift);
            }

            else if (HasEmptySlots(lift))
            {
                Console.WriteLine("The lift has empty spots!");
                PrintLift(lift);
            }
            //else
            //{
            //    PrintLift(lift);
            //}

           
        }

        static bool HasEmptySlots(int[] lift)
        {
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    return true;
                }
            }

            return false;
        }

        static void PrintLift(int[] lift)
        {
            for (int i = 0; i < lift.Length; i++)
            {
                Console.Write(lift[i] + " ");
            }
        }
    }
}