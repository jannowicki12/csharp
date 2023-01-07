int[,] x = new int[10, 10];
int suma= 0;
int s= 0;
int it = 1;
Console.WriteLine("Macierz:"); 
for (int i = 0; i < x.GetLength(0); i++)
{
    x[i, i] = i;
    suma += x[i, i];
}

for (int i = 1; i < x.GetLength(0); i++)
{
    for (int j = 0; j < x.GetLength(1); j++)
    {   
        if (i + j == x.GetLength(0) - 1)
        {
            x[i, j] = it;
            it = it + 1;
        }
        else
            x[i, j] = 0;
        Console.Write(x[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Suma elementów z przekątnej xy wynosi: " + suma);
Console.ReadKey();