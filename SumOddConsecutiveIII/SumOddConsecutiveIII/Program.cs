int n, x, y, sumNum = 1, sum = 0, aux = 0, vz;
List<int> list = new List<int>();
Console.WriteLine("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    
    Console.WriteLine("Enter number X: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number Y: ");
    y = Convert.ToInt32(Console.ReadLine());

    vz = y;
    int sumX = x;

    if (x % 2 != 0)
    {
        sumX = x;
        sum = sumX;
        vz = y - 1;
        sumNum = 2;
    }

    while(aux < vz)
    {

        sumX = sumX + sumNum;
        if(sumX % 2 != 0)
        {
            sum += sumX;
            sumNum = 2;

        }
        aux = aux + 1;

    }
    list.Add(sum);
    aux = 0;
    Console.WriteLine(" ");
}

list.ForEach(i => Console.WriteLine(i));
