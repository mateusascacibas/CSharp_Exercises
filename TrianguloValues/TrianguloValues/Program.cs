float n1, n2, n3, response;
List<float> vs = new List<float>();
Console.WriteLine("Enter N1º value: ");
n1 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter N2º value: ");
n2 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter N3º value: ");
n3 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
vs.Add(n1);
vs.Add(n2);
vs.Add(n3);
vs.Sort();

if(vs[2] < vs[1] + vs[0])
{
    response = vs[2] + vs[1] + vs[0];
    Console.WriteLine("Perimeter: " + response);
}
else
{
    response = ((n1 + n2) / 2) * n3;
    Console.WriteLine("Area: " + response);
}