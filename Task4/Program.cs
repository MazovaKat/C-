int n1, n2, n3;

Console.WriteLine("Введите первое число:");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (max < n2) max = n2;
if (max < n3) max = n3;

Console.WriteLine ("Максимальное число:" + max);
