float a, b, c, max, min, mid;

Console.WriteLine("Digit A value: ");
a = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digit B value: ");
b = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digit C value: ");
c = (float)Convert.ToDouble(Console.ReadLine());

List<float> list = new List<float>();
list.Add(a);
list.Add(b);
list.Add(c);
list.Sort();

if(list[2] >= list[1] + list[0])
{
    Console.WriteLine("Does Not Shape Triangle");
}else if((list[2] * list[2]) == (list[1] * list[1]) + (list[0] * list[0]))
{
    Console.WriteLine("Right Triangle");
}else if((list[2] * list[2]) > (list[1] * list[1]) + (list[0] * list[0]))
{
    Console.WriteLine("Obtusangle Triangle");
}
else if ((list[2] * list[2]) < (list[1] * list[1]) + (list[0] * list[0]))
{
    Console.WriteLine("Shortcut Triangle");
}

if(list[0] == list[1] && list[0] == list[2])
{
    Console.WriteLine("Equilateral Triangle");
}
else if (list[0] == list[1] && list[0] != list[2])
{
    Console.WriteLine("Isosceles Triangle");
}
else if (list[1] == list[2] && list[1] != list[0])
{
    Console.WriteLine("Isosceles Triangle");
}
else if (list[2] == list[0] && list[2] != list[1])
{
    Console.WriteLine("Isosceles Triangle");
}