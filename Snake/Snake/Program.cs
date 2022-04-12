using System.Drawing;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int FIELD_HEIGHT = 30;
            int FIELD_WIDTH = 120;
            Console.SetBufferSize(FIELD_WIDTH, FIELD_HEIGHT);
            Walls walls = new(FIELD_WIDTH, FIELD_HEIGHT);
            walls.Draw();

            Point p = new(5, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(119, 29, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

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

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(55, 14);
            Console.WriteLine("GAME OWER!!!");
            Console.Read(); 

        }
    }
}


