using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected Point pLine;
        protected List<Point> pLineList;
        public virtual void DrawLine()
        {
            foreach (Point i in pLineList)
            {

                i.Draw();
            }
        }

    }
}
