int n, r = 1;
Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
for(int i = n; i > 1; i--)
{
    r = r * i;
}
Console.WriteLine(r);
