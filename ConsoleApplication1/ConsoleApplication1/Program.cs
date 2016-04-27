using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.draw();

            Point p2 = new Point(3, 5, '#');
            p2.draw();

            Point p3 = new Point(6, 4, '^');
            p3.draw();


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            int c = numList[3];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(3);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            Console.ReadLine();
        }
    }
}
