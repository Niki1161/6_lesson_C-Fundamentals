using System.Net.WebSockets;
using System.Security.Cryptography;

namespace Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] array1 = new string[n];
            string[] array2 = new string[n];

           for (int i = 0; i < n; i++)
           {
                string line = Console.ReadLine();
                string[] splited = line.Split(); 

                string first = splited[0];
                string second = splited[1];

                if (i % 2 == 0)
                {
                    array1[i] = first;
                    array2[i] = second;
                }
                else
                {
                    array1[i] = second;
                    array2[i] = first;
                }
                                
           }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }


        }

    }
}