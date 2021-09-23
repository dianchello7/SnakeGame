using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class rectangle : BaseShape
    {
        public rectangle(Point leftTop, char theChar , ConsoleColor color) : base(leftTop, theChar , color)
        {

            for (int i = 1; i <=new Random().Next(3, 10); i++)
            {
                for (int j = 0; j <= new Random().Next(3, 10); j++)
                {
                    Console.Write(theChar);
                }
                Console.WriteLine();
                
            }
        }

        public override void PrintShape()
        {

        }
    }
}
