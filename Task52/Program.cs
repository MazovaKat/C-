int[,] Create2dArray(int m, int n, int min, int max)
{
   int[,] newArray = new int[m,n];

   for(int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        newArray[i,j] = (new Random().Next(min,max+1));

    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write( array[i,j]+ " ");

        Console.WriteLine();
    }        
}

void Sum(int[,] array)
{    int sum = 0;
     double arif = 0;
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            sum = sum + array[i,j];
        }
    arif = sum/array.GetLength(1);
    Console.WriteLine(arif +"; ");
    sum = 0;
    arif = 0;
    }

}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] Massiv = Create2dArray(m,n,min,max);
Show2dArray(Massiv);
Sum(Massiv);

