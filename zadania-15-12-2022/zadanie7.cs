int[,] array = new int[10, 10];
int row, col;
int sum1 = 0;
int sum2 = 0;
for(row = 0; row < 10; row++) 
    array[row, 0] = row; 
for (row = 0; row < 10; row++)
    array[row, 1] = row * row;

for (row = 0; row < 10; row++)
    for (col = 2; col < 10; col++)
        array[row, col] = 0;

for(row = 0; row < 10; row++)
    sum1 += array[row, 0];

for (row = 0; row < 10; row++)
    sum2 += array[row, 1];
Console.WriteLine("x:");
for (row = 0; row < 10; row++)
{
    for (col = 0; col < 10; col++)
        Console.Write(array[row, col] + "  ");
    Console.WriteLine();
}
Console.WriteLine("suma liczb w pierwszej kolumnie: " + sum1);
Console.WriteLine("suma liczb w drugiej kolumnie: " + sum2);
Console.ReadLine();