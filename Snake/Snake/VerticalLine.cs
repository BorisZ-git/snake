using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {

        public VerticalLine (int UpY, int DownY, int x, char sym)
        {
            pLineList = new List<Point>();
            for (; UpY <= DownY; UpY++)
            {
                pLine = new Point(x, UpY, sym);
                pLineList.Add(pLine);
            }
        }
        public override void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.DrawLine();

            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
