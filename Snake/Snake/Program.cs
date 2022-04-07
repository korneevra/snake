using static System.Console;

static void Draw(int x, int y, char symb)
{
    SetCursorPosition(x, y);
    Write(symb);
}

Draw(2, 2, '*');