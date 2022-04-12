namespace Snake
{
    internal class FoodCreator
    {
        int mapWidt;
        int mapHaight;
        char sym;
        Random random = new Random();

        public FoodCreator(int mapWidt, int mapHaight, char sym)
        {
            this.mapWidt = mapWidt;
            this.mapHaight = mapHaight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidt - 2);
            int y = random.Next(2, mapHaight - 2);
            return new Point(x, y, sym);
        }

    }
}