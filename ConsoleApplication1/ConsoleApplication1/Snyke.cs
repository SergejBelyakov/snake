using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snyke : Figurs
    {
        Direktion direction;

        public Snyke(Point tail, int lenght, Direktion _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nexPoint = new Point(head);
            nexPoint.Move(1, direction);
            return nexPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direktion.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direktion.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direktion.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direktion.UP;
        }
    }
}
