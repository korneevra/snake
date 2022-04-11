﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        public Snake(Point taile, int length, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new(taile);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
