double promien, objetosc;

Console.WriteLine("Podaj objetosc.");
promien = double.Parse(Console.ReadLine());
objetosc=4/3 * Math.PI * Math.Pow(promien, 3);
Console.WriteLine("{0: ##.##}.", objetosc);