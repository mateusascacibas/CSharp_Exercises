int value;
int note = 0;
Console.WriteLine("Enter value amount: ");
value = Convert.ToInt32(Console.ReadLine());

while(value != 0)
{
    if(value >= 100)
    {
        note = value / 100;
        value = value - (100 * note);
        Console.WriteLine(note + " Banknotes R$ 100");
    }
    else if (value >= 50)
    {
        note = value / 50;
        value = value - (50 * note);
        Console.WriteLine(note + " Banknotes R$ 50");
    }
    else if (value >= 20)
    {
        note = value / 20;
        value = value - (20 * note);
        Console.WriteLine(note + " Banknotes R$ 20");
    }
    else if (value >= 10)
    {
        note = value / 10;
        value = value - (10 * note);
        Console.WriteLine(note + " Banknotes R$ 10");
    }
    else if (value >= 5)
    {
        note = value / 5;
        value = value - (5 * note);
        Console.WriteLine(note + " Banknotes R$ 5");
    }
    else if (value >= 2)
    {
        note = value / 2;
        value = value - (2 * note);
        Console.WriteLine(note + " Banknotes R$ 2");
    }
    else if (value >= 1)
    {
        note = value / 1;
        value = value - (1 * note);
        Console.WriteLine(note + " Banknotes R$ 1");
    }
}