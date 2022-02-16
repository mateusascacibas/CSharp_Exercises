double n1, n2,n3, average;

Console.WriteLine("Enter 1º number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 2º number: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 3º number: ");
n3 = Convert.ToDouble(Console.ReadLine());
average = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
Console.WriteLine("AVERAGE = " + Math.Round(average, 1));