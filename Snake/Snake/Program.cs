using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point();
            p1.Draw(1, 3, '*');
            Point p2 = new Point();
            p2.Draw(5, 4, '#');

            Console.ReadLine();
        }
    }
}
