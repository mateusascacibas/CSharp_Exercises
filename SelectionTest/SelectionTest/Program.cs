int a, b, c, d;

Console.WriteLine("Enter the A value: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the B value: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the C value: ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the D value: ");
d = Convert.ToInt32(Console.ReadLine());

if(b > c && d > a && (c+d > a+b) && c > 0 && d > 0 && (a % 2 == 0)) {
    Console.WriteLine("Accept Values");
}
else
{
    Console.WriteLine("Don't accept Values");
}