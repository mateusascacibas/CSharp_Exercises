double n1, n2, average;

Console.WriteLine("Enter 1º number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 2º number: ");
n2 = Convert.ToDouble(Console.ReadLine());
average = ((n1 * 3.5) + (n2 * 7.5)) / 11;
Console.WriteLine("AVERAGE = " + Math.Round(average, 2));