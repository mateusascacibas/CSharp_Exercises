int n, f;

Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number: ");
f = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < f; i = i+3)
{
        int b, c;
        b = i + 1;
        c = b + 1;
        Console.Write(i + " ");
        Console.Write(b + " ");
        Console.Write(c + " ");
        Console.WriteLine();

}
