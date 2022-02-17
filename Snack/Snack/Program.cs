int cod, qtd;
double price;

Console.WriteLine("Enter Code: ");
cod = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Qtd: ");
qtd = Convert.ToInt32(Console.ReadLine());
if (cod == 1)
{
    price = 4.00 * qtd;
}else if(cod == 2)
{
    price = 4.50 * qtd;
}else if(cod == 3)
{
    price = 5.00 * qtd;
} else if(cod == 4)
{
    price = 2.00 * qtd;
} else if(cod == 5)
{
    price = 1.50 * qtd;
}
else
{
    price = 0;
}

Console.WriteLine("Total: R$ " + price);