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


            Console.ReadLine();

            Wall hor1 = new Wall("x", 1, 15, 1, '#');
            hor1.DrawWall();
            Console.ReadLine();

            Wall ver1 = new Wall("y", 1, 15,15,'@');
            ver1.DrawWall();
            Console.ReadLine();


        }
    }
}
