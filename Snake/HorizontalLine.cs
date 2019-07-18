using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine()
        {
            pList = new List<Point>();
            Point p1 = new Point(6, 6, '*');
            Point p2 = new Point(7, 6, '*');
            Point p3 = new Point(8, 6, '*');
            Point p4 = new Point(9, 6, '*');

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

        }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
