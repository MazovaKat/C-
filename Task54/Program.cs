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

int[,] SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int temp = array[i,j];
            if (temp > array[i,j+1])
            {   
                array[i,j] = array[i,j+1];
                array[i,j+1]=temp;
            }

            else array[i,j] = temp;

        }
    }
 return array;
 
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
int[,] Massiv2 = (SortArray(SortArray(Massiv)));
Console.WriteLine();
Show2dArray(Massiv2);