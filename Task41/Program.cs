int[] NewArray(int m)
{   
    int[] array = new int [m];
    for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите число {i+1} :" );
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}

void PrintArr (int[] array)
{
    for (int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

int CountPos(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count ++; 
  }
  return count;
}

Console.Write("Введите число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());

int[] NewArr = NewArray(m);

PrintArr(NewArr);

int result = CountPos(NewArr);

Console.WriteLine("Введено чисел больше 0:" + result);
