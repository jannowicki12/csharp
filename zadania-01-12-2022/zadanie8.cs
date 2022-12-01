double losuj, zgadnij;
Console.WriteLine("losuje liczby i zgadujesz");
Random r = new Random();
losuj = Math.Round(10*(r.NextDouble()));
zgadnij = double.Parse(Console.ReadLine());
if (losuj == zgadnij)
{
    Console.WriteLine("zgadles!");
}
else
{
    Console.WriteLine("nie zgadles, liczba to {0}.", losuj);
}
