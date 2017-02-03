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
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pLineList)
            {
                if (figure.IsHit(p)) 
                return true;
            }
            return false;
        }
        private bool IsHit (Point point)
        {
            foreach ( var p in pLineList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
