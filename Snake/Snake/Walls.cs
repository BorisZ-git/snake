using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {           
        List<Figure> walls = new List<Figure>();

        public Walls (int mapwidth, int mapheight)
        {
            HorizontalLine wall1 = new HorizontalLine(0, mapwidth - 2, 0, '+');
            HorizontalLine wall2 = new HorizontalLine(0, mapwidth - 2, 29, '+');
            VerticalLine wall3 = new VerticalLine(0, mapheight - 1, 0, '+');
            VerticalLine wall4 = new VerticalLine(0, mapheight - 1, 78, '+');

            walls.Add(wall1);
            walls.Add(wall2);
            walls.Add(wall3);
            walls.Add(wall4);        
        }
        internal bool IsHit (Figure figure)
        {
            foreach (var wall in walls)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in walls)
            {
                wall.DrawLine();
            }
        }
    }
}
