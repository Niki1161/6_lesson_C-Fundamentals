namespace TheLift_Midexam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                int currentCabin = lift[i];

                int freePlaces = 4 - currentCabin;

                if (peopleWaiting >= freePlaces)
                {
                    peopleWaiting -= freePlaces;
                    lift[i] += freePlaces;
                }
                else
                {
                    lift[i] += peopleWaiting;
                    peopleWaiting = 0;
                }

                if (peopleWaiting == 0)
                {
                    break;
                }
            }

            if (HasEmptySlot(lift))
            {
                Console.WriteLine("The lift has empty spots!");
            }

            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }

            PrintList(lift);            
          
        }
        static bool HasEmptySlot(List<int> lift)
        {
            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] < 4)
                {
                    return true;
                }
            }

            return false;
        }

        static void PrintLift(List<int> lift)
        {
            foreach (int i in lift)
            {
                Console.Write(i + " ");
            }
        }
               
        static void PrintList(List<int> lift)
        {
            var joined = string.Join(" ", lift);

            Console.WriteLine(joined);
        }
    }
}