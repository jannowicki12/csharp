int a = 0;
int total = 1;

do {
    if (i % 2 == 0)
    {
        total=total+i;
        i=i+1;
    }
    else {
        i=i+1;
    }
}
while (i<=100);
Console.WriteLine(total);