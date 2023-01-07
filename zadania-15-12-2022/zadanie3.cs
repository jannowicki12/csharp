int[,] x = new int[10, 10]; 
int suma = 0; 

Console.WriteLine("Macierz:"); 
for (int j = 0; j < 10; j++) 
{ 
    for (int i = 0; i < 10; i++) 
    { 
        if (i == j) 
            x[i, j] = 1; 
        if (i == j) 
            suma += x[i, j]; 

        else 
            x[i, j] = 0; 

        Console.Write(x[i, j] + " "); 
    } 
    Console.WriteLine(); 
} 
Console.WriteLine("Suma elementów na przekątnej wynosi: " + suma); 
