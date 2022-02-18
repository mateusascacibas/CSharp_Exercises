int n;

Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int n2;
    Console.WriteLine("Enter number: ");
    n2 = Convert.ToInt32(Console.ReadLine());
    if (n2 == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("NULL");
        Console.WriteLine("");
    } else if (n2 % 2 == 0)
    {
        if (n2 > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("EVEN POSITIVE");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("EVEN NEGATIVE");
            Console.WriteLine("");
        }
    }
    else
    {
        if (n2 > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("ODD POSITIVE");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("ODD NEGATIVE");
            Console.WriteLine("");
        }
    } 
}
