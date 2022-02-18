double x1, x2, y1, y2, distance;

Console.WriteLine("Enter x1 value: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y1 value: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x2 value: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y2 value: ");
y2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(Math.Round(distance,4));