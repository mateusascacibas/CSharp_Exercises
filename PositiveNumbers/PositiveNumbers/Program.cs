double n1, n2, n3, n4, n5, n6;
int count = 0;
List<double> list = new List<double>();
Console.WriteLine("Enter 1º number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 2º number: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 3º number: ");
n3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 4º number: ");
n4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 5º number: ");
n5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 6º number: ");
n6 = Convert.ToDouble(Console.ReadLine());
list.Add(n1);
list.Add(n2);
list.Add(n3);
list.Add(n4);
list.Add(n5);
list.Add(n6);
for (int i = 0; i < list.Count; i++)
{
    if(list[i] > 0)
    {
        count += 1;
    }
}

Console.WriteLine(count + " positive values");

