void NewArr (int[] array)
{
    int count = array.Length;
    int index = 0;

        while (index < count)
        {
            array[index] = new Random().Next(1,10);
            Console.Write (array[index]);
            index ++;
        }

}

int[] newArray = new int[8];

NewArr(newArray);