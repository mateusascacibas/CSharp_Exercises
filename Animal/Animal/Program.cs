String p1, p2, p3;

Console.WriteLine("Enter word 1: ");
p1 = Console.ReadLine();
Console.WriteLine("Enter word 2: ");
p2 = Console.ReadLine();
Console.WriteLine("Enter word 3: ");
p3 = Console.ReadLine();

if (p1.Equals("Vertebrado"))
{
    if (p2.Equals("Ave"))
    {
        if (p3.Equals("Carnivoro"))
        {
            Console.WriteLine("Aguia");
        }
        else
        {
            Console.WriteLine("Pomba");
        }
    }
    else
    {
        if (p3.Equals("Onivoro"))
        {
            Console.WriteLine("Homem");
        }
        else
        {
            Console.WriteLine("Vaca");
        }
    }
}else if (p1.Equals("Invertebrado"))
{
    if (p2.Equals("Inseto"))
    {
        if (p3.Equals("Hemafogo"))
        {
            Console.WriteLine("Pulga");
        }
        else
        {
            Console.WriteLine("Lagarta");
        }
    }
    else
    {
        if (p3.Equals("Onivoro"))
        {
            Console.WriteLine("Sanguessuga");
        }
        else
        {
            Console.WriteLine("Minhoca");
        }
    }
}