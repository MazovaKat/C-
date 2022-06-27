int FindThirdDigit (int num)
{   
    int third = 0;
    if (num >= 100)
        {
            while (num >= 1000)
                    {
                         num = num / 10;
                    }
            third = num%10;
        }
    else
        {
            return -1;
        }

return third;  
}
  

Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());  
int th = FindThirdDigit(n);

Console.WriteLine(th);
