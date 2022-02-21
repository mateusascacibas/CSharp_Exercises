using System.Collections.Generic;
using System;

int n, a, b,result;
var list = new List<int>();
Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Number 1º = ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number 2º = ");
    b = Convert.ToInt32(Console.ReadLine());
    if(b == 0)
    {
        Console.WriteLine("Impossible Split");
    }
    else
    {
        if(a == 0)
        {
            result = 0;
        }
        else
        {
            result = a / b;
        }
       

        list.Add(result);
    }

}

for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
