double a, b, c, delta, x1, x2;
byte liczba_pierwiastkow = 0;
Console.WriteLine("Program oblicza pierwiastki równania ax^2+bx+c = 0.");
Console.WriteLine("Podaj a.");
a = double.Parse(Console.ReadLine());
if (a == 0)
{
    Console.WriteLine("zla liczba");
}
else
{
    Console.WriteLine("Podaj b.");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Podaj c.");
    c = double.Parse(Console.ReadLine());
    delta = b*b-4*a*c;
    if (delta < 0) liczba_pierwiastkow = 0;
    if (delta == 0) liczba_pierwiastkow = 1;
    if (delta > 0) liczba_pierwiastkow = 2;
    switch (liczba_pierwiastkow)
    {
        case 0:
            {
                Console.Write("brak pierwiastków rzeczywistych.");
            }
            break;
        case 1:
            {
                x1 = -b/(2*a);
                Console.Write("x1 = {0: ##.##}.", x1);
            }
            break;
        case 2:
            {
                x1 = (-b-Math.Sqrt(delta))/(2*a);
                x2 = (-b+Math.Sqrt(delta))/(2*a);
                Console.Write("x1 = {0: ##.##}", x1);
                Console.Write("x2 = {0: ##.##}.", x2);
            }
            break;
    }
}