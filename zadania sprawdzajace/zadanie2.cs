double a, b, c, delta, x1, x2;
Console.WriteLine("Program oblicza czy liczba jest trojka pitagorajska.");
Console.WriteLine("Podaj a.");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj b.");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj c.");
c = double.Parse(Console.ReadLine());
delta = b*b-4*a*c;
if (delta > 0)
{
    x1 = (-b-Math.Sqrt(delta))/(2*a);
    x2 = (-b+Math.Sqrt(delta))/(2*a);
    Console.WriteLine("x1 = {0:##.##}, x2 = {1:##.##}.", x1, x2);
}
else if (delta == 0)
{
    x1 = -b/(2*a);
    Console.Write("jedno miejsce zerowe x1 = {0:##.##}.", x1);
}
else if (delta < 0)
{
    Console.Write("brak miejsc zerowych");
}