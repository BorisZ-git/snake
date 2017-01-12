using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {       
        List<Point> photlist;

        public HorizontalLine(int leftX, int rightX, int y, char sym)
        {
            Point p;
            photlist = new List<Point>();

            for (; leftX <= rightX; leftX++)
            {
                p = new Point(leftX, y, sym);
                photlist.Add(p);                
            }
        }
        public void DrawHorLine()
        {
            foreach (Point i in photlist)
            {
                i.Draw();
            }
        }

    }
}
