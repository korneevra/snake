using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            p1.Draw();
            Point p2 = new Point(5, 6, '#');
            p2.Draw();
        }
    }
}


