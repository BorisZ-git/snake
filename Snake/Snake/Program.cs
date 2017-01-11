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
            Point p1 = new Point( 1, 3, '*');
            p1.Draw();
            Point p2 = new Point( 5, 4, '#');
            p2.Draw();

            p1 = p2;
            Move(p2, 10, 10);
            p1.Draw();
            Console.ReadKey();
                        

        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

    }
}
