int n;
Console.WriteLine("Enter limit number: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
for (int i = 1; i <= n; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}