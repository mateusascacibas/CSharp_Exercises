double n;
Console.WriteLine("Enter number: ");
n = Convert.ToDouble(Console.ReadLine());
List<double> list = new List<double>();
for (int i = 0; i < n; i++)
{
    int count = i + 1;
    Console.WriteLine("Number: " + count);
    double n1, n2, n3, average;
    Console.WriteLine("Enter n1: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter n2: ");
    n2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter n3: ");
    n3 = Convert.ToDouble(Console.ReadLine());
    average = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
    list.Add(Math.Round(average, 2));
}
list.ForEach(x => Console.WriteLine(x));
