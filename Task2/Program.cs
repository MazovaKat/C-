int n1, n2;

Console.WriteLine("Введите первое число:");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
n2 = Convert.ToInt32(Console.ReadLine());

if (n1<n2)
{
    Console.WriteLine ("Максимальное число:" + n2);
}
else 
{
    Console.WriteLine ("Максимальное число:" + n1);
}


