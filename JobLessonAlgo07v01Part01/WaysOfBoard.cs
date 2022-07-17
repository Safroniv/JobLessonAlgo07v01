// Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой
// клетки в правую нижнюю. Известно что ходить можно только на одну клетку вправо или вниз.


public class WaysOfBoard
{
    public static int MathWaysOfBoard (int m, int n)
    {
        if ((m == 0) || (n == 0))
        { return 1; }
        return MathWaysOfBoard(m-1,n)+MathWaysOfBoard(m,n-1);
    }
}