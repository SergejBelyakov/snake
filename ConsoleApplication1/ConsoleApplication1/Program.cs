using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            VertikalLine v1 = new VertikalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figurs fSnake = new Snyke(p, 4, Direktion.RIGHT);
            Draw(fSnake);
            Snyke snyke = (Snyke)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '$');

            List<Figurs> figures = new List<Figurs>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }

            //Console.SetBufferSize(80, 25);

            /*HorizontalLine topline = new HorizontalLine(0, 78, 0, '+');
                topline.Drow();
            HorizontalLine botline = new HorizontalLine(0, 78, 24, '+');
                botline.Drow();
            VertikalLine leftline = new VertikalLine(0, 0, 24, '+');
                leftline.Drow();
            VertikalLine raightline = new VertikalLine(78, 0, 24, '+');
                raightline.Drow();*/

            /*Point p = new Point(4, 5, '+');
            Snyke snyke = new Snyke(p, 4, Direktion.RIGHT);
            snyke.Draw();*/

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snyke.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snyke.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snyke.HandleKey(key.Key);
                }

                
            }
        }

        static void Draw(Figurs figure)
        {
            figure.Draw();
        }
    }
}
