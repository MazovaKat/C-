int FindSecondDigit (int num)
{
    int d = num / 10;
    while ( d > 10)
    { 
        d = d - 10;
    }

    return d;
}

Console.WriteLine("Введите трехзначное число");

int n = Convert.ToInt32(Console.ReadLine());
int second = FindSecondDigit (n);

Console.WriteLine("Вторая цифра это " + second);


