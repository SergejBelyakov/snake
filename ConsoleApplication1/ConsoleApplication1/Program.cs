﻿using System;
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
            Console.SetBufferSize(80, 25);

            HorizontalLine topline = new HorizontalLine(0, 78, 0, '+');
                topline.Drow();
            HorizontalLine botline = new HorizontalLine(0, 78, 24, '+');
                botline.Drow();
            VertikalLine leftline = new VertikalLine(0, 0, 24, '+');
                leftline.Drow();
            VertikalLine raightline = new VertikalLine(78, 0, 24, '+');
                raightline.Drow();

            Point p = new Point(4, 5, '+');
            Snyke snake = new Snyke(p, 4, Direktion.RIGHT);




            Console.ReadLine();
        }
    }
}
