using System;
using System.Collections.Generic;

namespace Lumberjacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<LumberJack> lumberJacks = new Queue<LumberJack>();

            string name;
            Console.WriteLine($"First Lumberjack's name: ");
            while((name = Console.ReadLine()) != " ")
            {
                Console.WriteLine("Number of flapjacks: ");
                if(int.TryParse(Console.ReadLine(), out int number))
                {
                    LumberJack lumberjack = new LumberJack(name);
                    for (int i = 0; i <= number; i++)
                    {
                        lumberjack.FlapJack((FlapJack)random.Next(0, 4));
                    }
                    lumberJacks.Enqueue(lumberjack);
                }
                Console.Write("Next lumberjack's name (blank to end): ");
            }

            while(lumberJacks.Count > 0)
            {
                LumberJack next = lumberJacks.Dequeue();
                next.EatFlapjacks();
            }
        }
    }
}
