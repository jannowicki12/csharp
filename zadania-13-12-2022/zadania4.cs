int i = 1;
int sum = 0;

while (i <= 100)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
    i++;
}

Console.WriteLine(sum);