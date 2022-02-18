int a, b, mai, men, count = 0;

Console.WriteLine("Enter 1º number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2º number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(a > b)
{
    mai = a;
    men = b;
}
else
{
    mai = b;
    men = a;
}

for(int i = men; i < mai; i++)
{
    if (i != men && i % 2 != 0)
    {
        count += i;
    }
}

Console.WriteLine(count);
