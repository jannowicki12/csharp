int sum = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine("Suma liczb parzystych od 1 do 100 wynosi: " + sum);