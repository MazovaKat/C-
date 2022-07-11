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

int PositiveCount (int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) 
        count++;
    }
        
    return count;
}

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите минимальное трехзначаное число массива ");
int minim = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите максимальное трехзначаное число массива ");
int maxim = Convert.ToInt32(Console.ReadLine());  

int[] newArray = NewArr(n, minim, maxim);
PrintArr(newArray);

int x = PositiveCount(newArray);
Console.WriteLine("Количество четных = " + x);


