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
            //Set the window size
            Int16 width = 80, heigth = 25;
            Console.Title = "Snake";
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(width, heigth);
            Console.SetBufferSize(width, heigth);
            Console.ForegroundColor = ConsoleColor.Green;
            //Draw the frame
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            UpLine.DrawLine();
            DownLine.DrawLine();
            LeftLine.DrawLine();
            RightLine.DrawLine();
            //Start class Snake
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            Console.ReadLine();
            snake.DrawLine();         
            Console.ReadLine();


        }
    }
}
