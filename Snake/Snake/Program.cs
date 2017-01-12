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

            HorizontalLine wall_1 = new HorizontalLine(3, 10, 10, '*');
            wall_1.DrawHorLine();
            
            Console.ReadLine();

            VerticalLine Vwall_1 = new VerticalLine(4, 12, 11, '#');
            Vwall_1.DrawVerLine();

            Console.ReadLine();

        }
    }
}
