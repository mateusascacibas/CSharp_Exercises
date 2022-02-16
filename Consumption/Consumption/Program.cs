int km;
double liters, response;
Console.WriteLine("Enter total KM: ");
km = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter total liters: ");
liters = Convert.ToDouble(Console.ReadLine());
response = km / liters;

Console.WriteLine(Math.Round(response, 3) + " km/l");   
