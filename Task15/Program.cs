void HappyWeekend (int day)
{
    if (day<6)
        {
            Console.WriteLine ("Рабочий день");
        }
       else 
        {
            Console.WriteLine ("Выходной");
        }
}

Console.WriteLine("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine());  

HappyWeekend(n);

