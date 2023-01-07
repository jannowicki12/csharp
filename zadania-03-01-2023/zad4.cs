List<string> imie = new List<string>();

imie.Add("Jan");
imie.Add("Bartek");
imie.Add("Adrian");
imie.Add("Jakub");
imie.Add("Kamil");
imie.Add("Karol");

imie.Sort();

foreach(string name in imie)
{
    Console.WriteLine(name);
}