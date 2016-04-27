using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VertikalLine
    {
        List<Point> pListV;

        public VertikalLine(int x, int yTop, int yBot, char sym)
        {
            pListV = new List<Point>();
            for (int y = yTop; y <= yBot; y++)
            {
                Point p3 = new Point(x, y, sym);
                pListV.Add(p3);
            }
                        
        }
        public void drow()
        {
            foreach(Point p in pListV)
            {
                p.Draw();
            }
        }
    }
}
