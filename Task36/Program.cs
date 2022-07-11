int[] NewArr (int size, int min, int max)
{
    int[] array = new int [size];
    for (int i=0; i<size; i++)
    array[i] = new Random().Next(min,max+1);

    return array;
}


void PrintArr (int[] array)
{
    for (int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumNumb (int[] array)
{
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (i %2 != 0) 
        sum = sum + array[i];
    }
        
    return sum;
}

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите минимальное число массива ");
int minim = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите максимальное число массива ");
int maxim = Convert.ToInt32(Console.ReadLine());  

int[] newArray = NewArr(n, minim, maxim);
PrintArr(newArray);

int x = SumNumb(newArray);
Console.WriteLine("Общая сумма на нечетных позициях = " + x);
