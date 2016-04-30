using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Walls
    {
        List<Figurs> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figurs>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VertikalLine leftLine = new VertikalLine(0, 0, mapHeight - 1, '+');
            VertikalLine rightLine = new VertikalLine(mapWidth - 2,0, mapHeight - 1, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figurs figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
