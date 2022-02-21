int n, a, b, mai, men, sum = 0;
List<int> list = new List<int>();
Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Enter number: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number: ");
    b = Convert.ToInt32(Console.ReadLine());
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
    for(int j = mai-1; j > men; j--)
    {
        if(j % 2 != 0)
        {
            sum += j;
        }
    }
    list.Add(sum);
    sum = 0;
}

for(int k = 0; k < list.Count; k++)
{
    Console.WriteLine(" ");
    Console.WriteLine(list[k]);
}