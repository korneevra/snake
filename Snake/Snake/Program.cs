using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            HorizontalLine uplLine = new HorizontalLine(0, 119, 0, '+');
            HorizontalLine downlLine = new HorizontalLine(0, 119, 29, '+');
            VerticalLine leftlLine = new VerticalLine(0, 0, 29, '+');
            VerticalLine rightlLine = new VerticalLine(119, 0, 29, '+');
            uplLine.Draw();
            downlLine.Draw();
            leftlLine.Draw();
            rightlLine.Draw();

            Point p = new(5, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKay(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            


            Console.Read(); 

        }
    }
}


