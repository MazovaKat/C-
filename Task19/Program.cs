void Palindrom ( int x)
{
    int b = 0;
    int a = x;
        while ( a%10 > 1 )
            {
             b = (b*10) + a%10;
             a = a/10;
            }
    b = (b*10) + a;

    if ( b == x)
    { 
        Console.WriteLine("Число палиндром");
    }
    else 
    {
        Console.WriteLine("Число не палиндром");
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);