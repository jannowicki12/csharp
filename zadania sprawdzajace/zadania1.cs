// ZADANIE 1
double a, b, c;
Console.WriteLine("Program oblicza czy liczba jest trojka pitagorajska.");
Console.WriteLine("Podaj bok a.");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj bok b.");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj bok c.");
c = double.Parse(Console.ReadLine());
if (a*a+b*b==c*c)
{
    Console.WriteLine("liczba jest trojka pitagorajska");
}
else
{
    Console.Write("nie");
}