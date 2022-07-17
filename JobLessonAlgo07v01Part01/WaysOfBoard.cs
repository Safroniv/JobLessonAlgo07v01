// Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой
// клетки в правую нижнюю. Известно что ходить можно только на одну клетку вправо или вниз.


public class MathWaysOnBoard
{
    public static int SummWaysOnBoard (int m, int n)
    {
        if ((m == 0) || (n == 0))
        { return 1; }
        return SummWaysOnBoard(m-1,n)+SummWaysOnBoard(m,n-1);
    }
}