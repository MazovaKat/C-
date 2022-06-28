void HappyWeekend (int day)
{
    if (day<6)
        {
            Console.WriteLine ("Сегодня рабочий день");
        }
       else 
        {
            Console.WriteLine ("Сегодня выходной");
        }
}

Console.WriteLine("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine());  

HappyWeekend(n);