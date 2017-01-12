using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {        
        public HorizontalLine(int leftX, int rightX, int y, char sym)
        {
            
            pLineList = new List<Point>();

            for (; leftX <= rightX; leftX++)
            {
                pLine = new Point(leftX, y, sym);
                pLineList.Add(pLine);                
            }
        }
    }
}
