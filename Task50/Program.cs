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

string FindInt(int[,] array, int i1, int j1)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==(i1-1) && j==(j1-1)) 
                return array[i,j].ToString();
        }
    }
      return "Такого числа в массиве нет";

}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int m1 = Convert.ToInt32(Console.ReadLine());

int[,] Massiv = Create2dArray(m,n,min,max);
Show2dArray(Massiv);
Console.WriteLine(FindInt(Massiv, n1, m1));

