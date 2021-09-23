using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class square : BaseShape
    {
        public square(Point leftTop, char theChar, ConsoleColor color) : base(leftTop, theChar, color)
        {
            int random = new Random().Next(3, 10);
            for (int i = 1; i >= random; i++)
            {
                Console.Write(theChar);
                for (int j = i; j >= random-1; j++)
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
