int[] dane = new int[100];
int wynikParzysty = 0;
int wynikNieparzysty = 0;

for(int i = 0; i < dane.Length; i++)
    dane[i] = i + 1;

foreach(int liczba in dane)
{
    if(liczba % 2 == 0)
        wynikParzysty += liczba;
    else
        wynikNieparzysty += liczba;
}

Console.WriteLine($"Suma liczb parzystych wynosi {wynikParzysty}");
Console.WriteLine($"Suma liczb nieparzystych wynosi {wynikNieparzysty}");