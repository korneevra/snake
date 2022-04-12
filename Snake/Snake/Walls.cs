using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidt, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine uplLine = new HorizontalLine(0, mapWidt - 1, 0, '+');
            HorizontalLine downlLine = new HorizontalLine(0, mapWidt - 1, mapHeight - 1, '+');
            VerticalLine leftlLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightlLine = new VerticalLine(mapWidt - 1, 0, mapHeight - 1, '+');
            wallList.Add(uplLine);
            wallList.Add(downlLine);
            wallList.Add(rightlLine);
            wallList.Add(leftlLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (Figure f in wallList) { f.Draw(); }
        }
    }
}
