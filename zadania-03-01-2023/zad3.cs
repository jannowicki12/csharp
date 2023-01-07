List<int> list = new List<int>();

for (int i = 0; i < 7; i++) {
    list.Add(i);
}

list.Sort();

foreach (int i in list)
    Console.Write(i + " ");

Console.WriteLine();

list.RemoveAt(1);
list.Add(7);

list.Sort();

foreach (int i in list)
    Console.Write(i + " ");
Console.WriteLine();
