using System;

namespace SnowBalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double maxSnowBallValue = 0;
            int maxSnowBallSnow = 0;
            int maxSnowBallTime = 0;
            int maxSnowBallQuality = 0;

            for (int i = 0; i < count; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                double snowBallValue = Math.Pow((double)snowBallSnow / snowBallTime, snowBallQuality);

                if (snowBallValue > maxSnowBallValue)
                {
                    maxSnowBallValue = snowBallValue;
                    maxSnowBallSnow = snowBallSnow;
                    maxSnowBallTime = snowBallTime;
                    maxSnowBallQuality = snowBallQuality;
                }
            }

            Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = {maxSnowBallValue} ({maxSnowBallQuality})");
        }
    }
}
