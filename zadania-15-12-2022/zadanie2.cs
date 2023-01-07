int[] tablica = new int[10];
int liczba = 9;
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = liczba;
    liczba--;
}
Console.WriteLine("Elementy tablicy:");
foreach (int element in tablica)
{
    Console.Write(element + " ");
}