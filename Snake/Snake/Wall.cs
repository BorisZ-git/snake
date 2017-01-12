using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        Point p;
        List<Point> pList = new List<Point>();
        public Wall(string side, int from, int to, int position, char sym)
        {
            if (side == "x")
            {
                for (;from <= to; from++)
                {
                    p = new Point(from, position, sym);
                    pList.Add(p);
                }
            }
            if (side == "y")
            {
                for (; from <= to; from++)
                {
                    p = new Point(position, from, sym);
                    pList.Add(p);
                }
            }
        }
        public void DrawWall()
        {
            foreach (Point i in pList)
            {
                Console.Write(i);
            }
        }
    }
}
