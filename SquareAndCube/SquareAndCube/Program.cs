int n;
Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
List<double> list2 = new List<double>();
for (int i = 1; i <= n; i++)
{   
    list2.Add(i);
    double a = Math.Pow(i,2);
    list2.Add(a);
    double b = Math.Pow(i,3);
    list2.Add(b); 
}

for(int i = 0; i < list2.Count; i++)
{
    int j = i + 1;
    Console.Write(list2[i] + " ");
    if(j % 3 == 0)
    {
        Console.WriteLine("");
    }
}