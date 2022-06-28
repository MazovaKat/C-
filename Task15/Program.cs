void HappyWeekend (int day)
{
    if (day<6)
        {
            Console.WriteLine ("Все плохо, иди на работу, если ты офисный тусер");
        }
       else 
        {
            Console.WriteLine ("Пока выходной, но скоро все равно на работу");
        }
}

Console.WriteLine("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine());  

HappyWeekend(n);