int sum = 0;
int i = 1;
do
{
    if (i % 2 != 0)
    {
        sum += i;
    }
    i++;
}
while (i <= 100);
Console.WriteLine("Suma liczb nieparzystych w przedziale od 1 do 100 wynosi: {0}", sum);