int n, total, cQ = 0, rQ = 0, sQ = 0;

Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int sum;
    sum = i + 1;
    Console.WriteLine("Number: " + sum);
    int q;
    String t;
    Console.WriteLine("Quantity: ");
    q = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Type: ");
    t = Console.ReadLine();
    if(t == "C")
    {
        cQ += q;
    }else if(t == "R")
    {
        rQ += q;
    }else if (t == "S")
    {
        sQ += q;
    }

}
total = cQ + rQ + sQ;   
double p1, p2,p3;
p1 = ((cQ / (double)total) * 100);
p2 = ((rQ / (double)total) * 100);
p3 = ((sQ / (double)total) * 100);
Console.WriteLine("Total: "+ total + " guinea pigs");
Console.WriteLine("Total rabbits: " + cQ);
Console.WriteLine("Total mouse: " + rQ);
Console.WriteLine("Total frogs: " + sQ);
Console.WriteLine("Rabbits percentual: " + p1 + " %");
Console.WriteLine("Mouse percentual: " + p2 + " %");
Console.WriteLine("Frogs percentual: " + p3 + " %");