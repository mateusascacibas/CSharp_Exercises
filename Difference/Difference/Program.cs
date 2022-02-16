int n1, n2, n3, n4, diff;

Console.WriteLine("Enter 1º number: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2º number: ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3º number: ");
n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 4º number: ");
n4 = Convert.ToInt32(Console.ReadLine());

diff = (n1 * n2 - n3 * n4);
Console.WriteLine("DIFFERENCE = " + diff);