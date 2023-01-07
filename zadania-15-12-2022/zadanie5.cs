int[,] x = new int[10, 10];
int suma = 0;

for (int i = 0; i < x.GetLength(0); i++)
{
    for (int j = 0; j < x.GetLength(1); j++)
    {
        if (i + j == x.GetLength(0) - 1)
            x[i, j] = 1;
        else
            x[i, j] = 0;
        Console.Write(x[i, j] + " ");
        suma += x[i, j];
    }
    Console.WriteLine();
}

Console.WriteLine("Suma macierzy: " + suma);
Console.ReadKey();