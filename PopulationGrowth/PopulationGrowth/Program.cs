int t;
List<string> list = new List<string>();
Console.WriteLine("Enter number: ");
t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int pa, pb, year = 0, paM, pbM = 0;
    double g1, g2;
    Console.WriteLine("City A population: ");
    pa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("City B population: ");
    pb = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("City A develop: ");
    g1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("City B develop: ");
    g2 = Convert.ToDouble(Console.ReadLine());
    paM = (int)((int) pa * (g1 / 100));
    if(g2 > 0)
    {
        pbM = (int)((int)pb * (g2 / 100));
    }
    while (pa < pb)
    {
        paM = (int)((int)pa * (g1 / 100));
        pbM = (int)((int)pb * (g2 / 100));
        pa += paM;
        pb += pbM;
        year += 1;
        if(year > 100)
        {
            break;
        }

    }
    if(year > 100)
    {
        list.Add("More one secul.");
    }
    else
    {
        list.Add(year + " years.");
    }

}
list.ForEach(i => Console.WriteLine(i));