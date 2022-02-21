int a, n = -1, b = 0;
Console.WriteLine("Enter number: ");
a = Convert.ToInt32(Console.ReadLine());
while(n <= 0)
{
    Console.WriteLine("Enter number: ");
    n = Convert.ToInt32(Console.ReadLine());
}

for(int i = 1; i < n; i++)
{
    b += a;
    a++;
}
Console.WriteLine(b);

