
double n1;
int count = 0;
List<double> list = new List<double>();
Console.WriteLine("Enter 1º number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console
    .WriteLine("");
while(count < 6)
{
    if(n1 % 2 != 0)
    {
        list.Add(n1);
        count++;
    }
    n1 += 1;
}
list.ForEach(n => Console.WriteLine(n));


