using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake (Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pLineList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pLineList.Add(p);
            }
        }
        internal bool IsHitTail ()
        {
            var head = pLineList.Last();
            for (int i = 0; i < pLineList.Count - 2; i++)
            {
                if (head.IsHit(pLineList[i]))
                {
                    return true;
                }
            }
            return false;    
        }

        internal void Move()
        {
            Point tail = pLineList.First();
            pLineList.Remove(tail);
            Point head = GetNextPoint();
            pLineList.Add(head);

            tail.Clear();
            head.Draw();
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pLineList.Add(food);
                return true;
            }
            else return false;
        }

        public Point GetNextPoint()
        {
            Point head = pLineList.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }
        public void HadleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
