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
            int x1 = 1;
            int y1 = 3;

            char sym1 = '*';

            draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;

            char sym2 = '#';
            draw(x2, y2, sym2);

            Console.ReadLine();
        }

        static void draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
