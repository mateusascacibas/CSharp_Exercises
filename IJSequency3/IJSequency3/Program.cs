int aux = 7;
int auxMin = aux - 3;
for(int i = 1; i < 10; i= i + 2)
{
    for(int j = aux; j > auxMin; j = j-1)
    {
        Console.Write("I = " + i);
        Console.WriteLine(" J = " + j);
    }
    aux = aux + 2;
    auxMin = aux - 3;
}
