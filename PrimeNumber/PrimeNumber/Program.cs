int p;
List<string> list = new List<string>();
Console.WriteLine("Enter number: ");
p = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < p; i++)
{
    int a, b = 1, qtd = 0;
    Console.WriteLine("Number: ");
    a = Convert.ToInt32(Console.ReadLine());
    while(b <= a)
    {
        if(a % b == 0)
        {
            qtd += 1;
        }
        b++;
    }
    if (qtd == 2)
    {
        list.Add(a + " is prime number.");
    }
    else
    {
        list.Add(a + " not is prime number.");
    }
}

list.ForEach(x => Console.WriteLine(x));