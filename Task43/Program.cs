double Point (double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    return x;
}

Console.WriteLine("Найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ");

Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double x1 = Point(k1, k2, b1, b2);
double y1 = k1*x1+b1;

Console.WriteLine("Точка пересечения:" + x1 + "," + y1);