int n, aux = 1, auxMai = 3;
Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    for(int j = aux; j <= auxMai; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine(" PUM ");
    aux = aux + 4;
    auxMai = aux + 2;
}