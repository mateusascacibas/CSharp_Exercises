int n1, n2;

Console.WriteLine("Enter n1 value: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n2 value: ");
n2 = Convert.ToInt32(Console.ReadLine()); 
if (n1 > n2)
{
    if(n1 % n2 == 0)
    {
        Console.WriteLine("Are multiple");
    }
    else
    {
        Console.WriteLine("Are not multiple");
    }
} else
{

        if (n2 % n1 == 0)
        {
            Console.WriteLine("Are multiple");
        }
        else
        {
            Console.WriteLine("Are not multiple");
        }
}