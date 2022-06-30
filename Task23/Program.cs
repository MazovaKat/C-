void Cube (int n)
{
    
    for ( int x=1; x<=n; x++)
    {
        Console.Write(x*x*x + " ");
    }
}

Console.WriteLine ("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Cube (num);
