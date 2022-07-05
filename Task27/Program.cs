int Sum(int x)
{
    int sum = 0;
        while ( x%10 > 1/10 )
            {
             sum = sum + x%10;
             x = x/10;
            }
    return sum;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int summa = Sum(num);

Console.WriteLine(summa);
