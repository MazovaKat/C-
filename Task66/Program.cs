int SumOfNum (int m, int n)
{
    int sum =m;
    if (m>n)
    {
       sum = sum +(SumOfNum(m-1,n));
       n = n+1;
    }
    return sum;
}

Console.Write("Введите число M (большее из чисел): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N (меньшее из чисел): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNum(m,n));
