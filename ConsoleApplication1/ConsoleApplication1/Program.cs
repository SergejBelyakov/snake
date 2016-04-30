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
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p = new Point(4, 5, '+');
            Snyke snyke = new Snyke(p, 4, Direktion.RIGHT);
            snyke.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

              while(true)
            {
                if(walls.IsHit(snyke)||snyke.IsHitTail())
                {
                    break;
                }
                 if (snyke.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
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
    }
}
