// Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой
// клетки в правую нижнюю. Известно что ходить можно только на одну клетку вправо или вниз.


Console.WriteLine("Для прямоугольного поля размера M на N клеток");
Console.WriteLine("Введите параметр M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Спасибо.");
Console.WriteLine("Теперь введите параметр M:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Здорово. подождите немного....");
int[,] tableMassive = new int[m - 1, n - 1];
Thread.Sleep(5000);
Console.WriteLine($"А вот и результат - количество путей = {WaysOfBoard.MathWaysOfBoard(m - 1, n - 1)}");
