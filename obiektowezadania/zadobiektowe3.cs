class tablice
{
    static void Main(string[] args)
    {
        tablice tabliczki = new tablice();
        // deklaracja zmiennej, utworzenie obiektu i przypisanie go do zmiennej
        tabliczki.czytaj_dane(); // wywołanie metody czytaj_dane()
        tabliczki.przetworz_dane(); // wywołanie metody przetworz_dane()
        tabliczki.wyswietl_wynik(); // wywołanie metody wyswietl_wynik()
        Console.Read(); // naciśnij klawisz Enter
    }
    int[,] x = new int[10, 10];
    int suma = 0;
    public void czytaj_dane() // deklaracja i definicja metody czytaj_dane()
    {
        Console.WriteLine("Macierz:");
        for (int i = 0; i < 10; i++)
        {
            x[i, i] = i;
            suma += x[i, i];
        }
    }
    public void przetworz_dane() // deklaracja i definicja metody przetworz_dane()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(x[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
    public void wyswietl_wynik() // deklaracja i definicja metody wyswietl_wynik()
    {   
        Console.WriteLine("Suma elementów z przekątnej xy wynosi: " + suma);
        Console.ReadKey();
    }
}