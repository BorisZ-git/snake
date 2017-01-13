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

        internal void Move()
        {
            Point tail = pLineList.First();
            pLineList.Remove(tail);
            Point head = GetNextPoint();
            pLineList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pLineList.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }
    }
}
