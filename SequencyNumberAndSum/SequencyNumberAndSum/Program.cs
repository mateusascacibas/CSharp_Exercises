int a, b,c,d, sum = 0, mai, men;
Console.WriteLine("Enter number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
d = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    mai = a;
    men = b;
}
else{
    mai = b;
    men = a;
}
for(int i = men; i <= mai; i++)
{
    sum += i;
    Console.Write(i + " ");
}

Console.WriteLine("Sum = " + sum);
sum = 0;
if (c > d)
{
    mai = c;
    men = d;
}
else
{
    mai = d;
    men = c;
}
for (int i = men; i <= mai; i++)
{
    sum += i;
    Console.Write(i + " ");
}

Console.WriteLine("Sum = " + sum);