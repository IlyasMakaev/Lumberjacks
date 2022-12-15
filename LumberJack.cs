using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjacks
{
    class LumberJack
    {
        public string Name { get; set; }
        private Stack<FlapJack> flapjackStack = new Stack<FlapJack>();
        
        public LumberJack(string name)
        {
            Name = name;
        }

        public void FlapJack(FlapJack flapjack )
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while(flapjackStack.Count > 0)
            {
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }
}
