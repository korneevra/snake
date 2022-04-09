using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            //p1.Draw();
            Point p2 = new Point(3, 4, '#');
            //p2.Draw();
            Point p3 = new Point(4, 5, '@');
            Point p4 = new Point(5, 6, '$');

            List<int> newList = new();
            newList.Add(6);
            newList.Add(7);
            newList.Add(9);
            int x = newList[0];
            int y = newList[1];
            int z = newList[2];

            foreach (int i in newList)
            {
                Console.WriteLine(i);
            }

            List < Point > points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            points[2].Draw();

            foreach (Point i in points)
            {
                i.Draw();
            }

            

        }
    }
}


