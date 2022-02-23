int n, response = 1, aux = 1;
Console.WriteLine("Enter number: ");
List<int> list = new List<int>();
n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    if(i == 0 || i == 1)
    {
        list.Add(i);
        Console.Write(list[i] + " ");
    }
    else
    {
        list.Add(response);
        response = response + list[i-1];
        Console.Write(list[i] + " ");


    }

    
}