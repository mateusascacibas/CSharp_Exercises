int total, in_ = 0, out_ = 0;
List<int> list = new List<int> ();
Console.WriteLine("Enter number values: ");
total = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
for (int i = 0; i < total; i++)
{
    int n;
    Console.WriteLine("Number: ");
    n = Convert.ToInt32(Console.ReadLine());
    list.Add(n);
    Console.WriteLine("");
}

for(int i = 0; i < list.Count; i++)
{
    if(list[i] >= 10 && list[i] <= 20)
    {
        in_ += 1;
    }
    else
    {
        out_ += 1;
    }
}

Console.WriteLine(in_ + " in\n" + out_ + " out");