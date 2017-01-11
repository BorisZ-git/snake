using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point( 1, 3, '*');
            p1.Draw();
            Point p2 = new Point( 5, 4, '#');
            p2.Draw();
            Point p3 = new Point(10, 10, '@');
            Point p4 = new Point(6, 9, '&');

            List<char> symList = new List<char>();
            symList.Add('#');
            symList.Add('&');
            symList.Add('@');
            symList.Add('*');
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            
            foreach (char i in symList)
            {
                Console.WriteLine(i);
            }
            foreach (Point p in pList)
            {
                Console.WriteLine(p.x);
            }

            Console.ReadLine();
        }
    }
}
