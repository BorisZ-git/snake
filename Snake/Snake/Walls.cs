using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        int maphight;
        int mapwidth;
        List<Figure> wall = new List<Figure>();
        public Walls (int x,int y)
        {
            maphight = y;
            mapwidth = x;
            HorizontalLine wall1 = new HorizontalLine();
            HorizontalLine wall2 = new HorizontalLine();
            VerticalLine wall3 = new VerticalLine();
            VerticalLine wall4 = new VerticalLine();
            wall.Add(wall1);
            wall.Add(wall2);
            wall.Add(wall3);
            wall.Add(wall4);

        }
    }
}
