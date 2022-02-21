int n, aux = 1;

Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    for(int j = 0; j < 2; j++)
    {
        int a = i * i;
        Console.Write(i + " ");
        if (j == 0)
        {
            
            Console.Write(a + " ");
            Console.Write(a * i + " ");
        }
        else
        {
            int b = (a * i) + 1;
            a +=1;
            
            Console.Write(a + " " );
            Console.Write(b + " " );
        }
        Console.WriteLine();

    }

    
}
