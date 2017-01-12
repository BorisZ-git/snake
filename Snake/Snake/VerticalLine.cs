using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        Point pVer;
        List<Point> pVerList;
        public VerticalLine (int UpY, int DownY, int x, char sym)
        {
            pVerList = new List<Point>();
            for (; UpY <= DownY; UpY++)
            {
                pVer = new Point(x, UpY, sym);
                pVerList.Add(pVer);
            }
        }
        public void DrawVerLine ()
        {
            foreach (Point i in pVerList)
            {

                i.Draw();
            }
        }
    }
}
