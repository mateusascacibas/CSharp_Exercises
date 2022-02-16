int hours, vel;
double total;
Console.WriteLine("Enter hours: ");
hours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter average velocity: ");
vel = Convert.ToInt32(Console.ReadLine());

total = hours * vel;
total = total / 12;

Console.WriteLine(Math.Round(total, 3));
