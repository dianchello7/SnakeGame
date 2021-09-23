using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Line : BaseShape
    {
        public Line(Point leftTop, char theChar, ConsoleColor color) : base(leftTop, theChar , color)
        {

            for (int i = 2; i < new Random().Next(3,10)
                ; i++)
            {
                Console.Write(theChar);
            }
        }

        public override void PrintShape()
        {

            
        }
    }
}
