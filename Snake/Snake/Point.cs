using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public Point(int x,int y,char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
