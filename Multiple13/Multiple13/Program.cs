int n1, n2, sum = 0;
Console.WriteLine("Enter 1º ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2º ");
n2 = Convert.ToInt32(Console.ReadLine());
for(int i = n1; i <= n2; i++)
{
    if(i % 13 != 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum);