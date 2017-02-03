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
            //Build Wall into the Frame
            Walls frame = new Walls(80, 30);
            frame.Draw();
                //Draw the Food
                FoodCreator foodcreator = new FoodCreator(80, 25, '$');
                Point food = foodcreator.CreateFood();
                food.Draw();
                //Start the Game
                snake.DrawLine();
                while (true)
                {
                    if (frame.IsHit(snake) || snake.IsHitTail())
                    {
                        break;
                    }
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
            Console.Clear();
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("The game is over!");
            Console.SetCursorPosition(50, 14);
            Console.Write("GoodBye");
            Console.ReadLine();
            
            
        }
        static void Window()
        {
            Console.Title = "Snake";
            Console.SetBufferSize(120, 30);
        }
    }
}
