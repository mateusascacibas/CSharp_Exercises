int a, b;
Console.WriteLine("Enter number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
b = Convert.ToInt32(Console.ReadLine());
List<int> list = new List<int>();
for (int i = a; i < b; i++)
{
    if(i % 5 == 2 || i % 5 == 3)
    {
        list.Add(i);
    }
}
Console.WriteLine("");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine("");
    Console.WriteLine(list[i]);
}