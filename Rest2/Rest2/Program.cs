int a;
Console.WriteLine("Enter number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 0; i < 10000; i++)
{
    if(i % a == 2)
    {
        Console.WriteLine(i);
    }
}