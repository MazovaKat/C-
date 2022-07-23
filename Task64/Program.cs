int count (int n)
{
    if (n/10!=0)
        return 1+count(n/10);
    else
        return 1;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(count(num));
