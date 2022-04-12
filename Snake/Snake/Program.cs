using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int CONSOLE_HEIGHT = 30;
            int CONSOLE_WIDTH = 120;
            Console.SetBufferSize(CONSOLE_WIDTH, CONSOLE_HEIGHT);

            HorizontalLine uplLine = new HorizontalLine(0, CONSOLE_WIDTH - 1, 0, '+');
            HorizontalLine downlLine = new HorizontalLine(0, CONSOLE_WIDTH - 1, CONSOLE_HEIGHT - 1, '+');
            VerticalLine leftlLine = new VerticalLine(0, 0, CONSOLE_HEIGHT - 1, '+');
            VerticalLine rightlLine = new VerticalLine(CONSOLE_WIDTH - 1, 0, CONSOLE_HEIGHT - 1, '+');
            uplLine.Draw();
            downlLine.Draw();
            leftlLine.Draw();
            rightlLine.Draw();

            Point p = new(5, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(119, 29, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else snake.Move();
                
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKay(key.Key);
                }
            }

            


            Console.Read(); 

        }
    }
}


