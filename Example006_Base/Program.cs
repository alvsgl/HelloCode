int[5] values = {1, 2, 6, 8, 4};
int max = 0;
Console.Write("values = ");
foreach (int value in values)
{
    Console.Write(value + " ");
    if(value > max) max = value;
}

Console.WriteLine("\nmax = " + max);