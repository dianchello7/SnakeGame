using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Triangle : BaseShape
    {
        public Triangle(Point leftTop, char theChar, ConsoleColor color): base(leftTop, theChar, color)
        {
            for (int counter = 1; counter <= new Random().Next(3, 10)
                ; counter++)
            {
                for (int j = 1; j <= counter; j++)
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
