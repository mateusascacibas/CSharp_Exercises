int position= 0, maior= 0;
for(int i = 0; i < 5; i++)
{
    int a;
    Console.WriteLine("Number: ");
    a = Convert.ToInt32(Console.ReadLine());
    if(i == 0)
    {
        maior = a;
        position = i+1;
    }
    else if(a > maior) {
        position = i+1;
        maior = a;
    }
}

Console.WriteLine(maior);
Console.WriteLine(position);
