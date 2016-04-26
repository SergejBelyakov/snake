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
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            Point p1 = new Point(1, 4, '%');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y =" + p1.y);

            Point p2 = new Point(4, 6, '&');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y =" + p1.y + ", p2.x =" + p2.x + ", p2.y =" + p2.y);

            p1 = new Point(1, 6, '*');


            Console.ReadLine();
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        /*public static void Update(Point p)
        {
            p = new Point();
        }*/

        public static void Func1(int value)
        {

        }
    }
}
