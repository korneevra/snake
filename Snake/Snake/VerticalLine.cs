using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine : Figure
    {

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int i = yUp; i < yDown; i++)
            {
                pList.Add(new Point(x, i, sym));
            }
        }

    }
}
