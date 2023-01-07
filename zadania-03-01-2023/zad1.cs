int[] dane = new int[100];
int suma = 0;

for (int i = 0; i < dane.Length; i++)
    dane[i] = i + 1;

foreach (int element in dane)
    suma += element;

Console.WriteLine("Suma liczb w tablicy wynosi " + suma);