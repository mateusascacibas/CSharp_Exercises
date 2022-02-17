double x, y;

Console.WriteLine("Enter X value coordinates: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y value coordinates: ");
y = Convert.ToDouble(Console.ReadLine());

if(x == 0 && y == 0)
{
    Console.WriteLine("Origin");
}else if(x == 0 && y != 0)
{
    Console.WriteLine("Axle Y");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("Axle X");
}
else
{
    if(x > 0 && y > 0)
    {
        Console.WriteLine("Q1");
    }else if(x < 0 && y < 0)
    {
        Console.WriteLine("Q3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Q4");
    }
    else
    {
        Console.WriteLine("Q2");
    }

}