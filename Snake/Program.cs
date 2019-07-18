using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(3, 5, '&');
            Point p4 = new Point(5, 7, '@');


            List<Point> pPoint = new List<Point>();
            pPoint.Add(p1);
            pPoint.Add(p2);
            pPoint.Add(p3);
            pPoint.Add(p4);

           /* int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            */
            foreach (Point i in pPoint)
            {
                i.Draw();
            }

            pPoint.RemoveAt(0);

            Console.ReadLine();

        }
    }
}
