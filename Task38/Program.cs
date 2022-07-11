double[] NewArr (int size, int min, int max)
{
    double[] array = new double [size];
    for (int i=0; i<size; i++)
    array[i] = (new Random().Next(min,max+1)) + new Random().NextDouble();

    return array;
}


void PrintArr (double[] array)
{
    for (int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

double Min (double[] array)
{
    double Min = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] < Min) 
        Min = array[i];
    }
        
    return Min;
}

double Max (double[] array)
{
    double Max = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > Max) 
        Max = array[i];
    }
        
    return Max;
}

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите минимальное число массива ");
int minim = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите максимальное число массива ");
int maxim = Convert.ToInt32(Console.ReadLine());  

double[] newArray = NewArr(n, minim, maxim);
PrintArr(newArray);

double min = Min(newArray);
Console.WriteLine("Минимальное число массива =" + min);

double max = Max(newArray);
Console.WriteLine("Максимальное число массива =" + max);

Console.WriteLine("Разница =" + (max - min));

