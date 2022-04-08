<<<<<<< Updated upstream
﻿Console.WriteLine("Hello, World!");
=======
﻿using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.y = 1;
            p1.x = 1;
            p1.sym = '*';
            p1.Draw();
            Point p2 = new Point();
            p2.y = 5;
            p2.x = 5;
            p2.sym = '#';
            p2.Draw();
        }
    }
}


>>>>>>> Stashed changes
