int[,] x = new int[10, 10];
int suma = 0;
Console.WriteLine("Macierz:"); 
for (int i = 0; i < 10; i++)
{
    x[i, i] = i;
    suma += x[i, i];
}


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(x[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Suma elementów z przekątnej xy wynosi: " + suma);
Console.ReadKey();