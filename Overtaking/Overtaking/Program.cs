int x, z = 0, count = 0, sum = 0;
Console.WriteLine("Enter x number: ");
x = Convert.ToInt32(Console.ReadLine());
while(z <= x)
{
    Console.WriteLine("Enter z number: ");
    z = Convert.ToInt32(Console.ReadLine());
}

while(sum < z)
{
    count += 1;
    sum += x;
    x = x + 1;
}

Console.WriteLine(count);