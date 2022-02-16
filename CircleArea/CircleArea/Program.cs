double area, lightning;

Console.WriteLine("Enter lightning value: ");
lightning = Convert.ToDouble(Console.ReadLine());
area = 3.14159 * (lightning * lightning);
Console.WriteLine("A = " + Math.Round(area, 4));