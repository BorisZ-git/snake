using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            //Start class Snake
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            
          
                //Set the window size
                Window();
                //Draw the frame
                Frame();
                //Draw the Food
                FoodCreator foodcreator = new FoodCreator(80, 25, '$');
                Point food = foodcreator.CreateFood();
                food.Draw();
                //Start the Game
                snake.DrawLine();
                while (true)
                {
                    if (snake.Eat(food))
                    {
                        food = foodcreator.CreateFood();
                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }

                    Thread.Sleep(100);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HadleKey(key.Key);
                    }
                }
            
        }
        static void Window()
        {
            Int16 width = 80, heigth = 25;
            Console.Title = "Snake";
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(width, heigth);
            Console.SetBufferSize(width, heigth);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void Frame()
        {
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            UpLine.DrawLine();
            DownLine.DrawLine();
            LeftLine.DrawLine();
            RightLine.DrawLine();
        }
        static void Draw (Figure figure)
        {
            figure.DrawLine();
        }

    }
}
