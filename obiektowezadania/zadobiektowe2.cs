class axbxc
{
    static void Main(string[] args)
    {
        axbxc x3 = new axbxc();
        // deklaracja zmiennej, utworzenie obiektu i przypisanie go do zmiennej
        x3.czytaj_dane(); // wywołanie metody czytaj_dane()
        x3.przetworz_dane(); // wywołanie metody przetworz_dane()
        x3.wyswietl_wynik(); // wywołanie metody wyswietl_wynik()
        Console.Read(); // naciśnij klawisz Enter
    }
    double a, b, c, delta, x1, x2;
    public void czytaj_dane() // deklaracja i definicja metody czytaj_dane()
    {
        Console.WriteLine("Program oblicza pole prostokąta.");
        Console.WriteLine("Podaj bok a.");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj bok b.");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj bok c.");
        c = double.Parse(Console.ReadLine());

    }
    public void przetworz_dane() // deklaracja i definicja metody przetworz_dane()
    {
        delta = b*b-4*a*c;

    }
    public void wyswietl_wynik() // deklaracja i definicja metody wyswietl_wynik()
    {
        if (delta > 0)
        {
            x1 = (-b-Math.Sqrt(delta))/(2*a);
            x2 = (-b+Math.Sqrt(delta))/(2*a);
            Console.WriteLine("x1 = {0:##.##}, x2 = {1:##.##}.", x1, x2);
        }
        else if (delta == 0)
        {
            x1 = -b/(2*a);
            Console.WriteLine("jedno miejsce zerowe x1 = {0:##.##}.", x1);
        }
        else if (delta < 0)
        {
            Console.WriteLine("brak miejsc zerowych");
        }

    }
}