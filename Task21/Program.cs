double Dist (double x1, double y1, double z1, double x2, double y2, double z2 )
{
    double dist = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    return dist;
    
}

Console.WriteLine ("Введите координату первой точки X");
double X1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите координату первой точки Y");
double Y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите координату первой точки Z");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите координату второй точки X");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите координату второй точки Y");
double Y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите координату второй точки Z");
double Z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Расстояние между точками " + Dist (X1, Y1, Z1, X2, Y2, Z2));


