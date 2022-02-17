double num;

Console.WriteLine("Enter number: ");
num = Convert.ToDouble(Console.ReadLine());
if(num >= 0.0 && num <= 25.0)
{
    Console.WriteLine("Interval [0,25]");
} else if (num > 25.0 && num <= 50.0){
    Console.WriteLine("Interval [25,50]");
} else if (num > 50.0 && num <= 75.0){
    Console.WriteLine("Interval [50,75]");
} else if (num > 75.0 && num <= 100.0){
    Console.WriteLine("Interval [75,100]");
}
else
{
    Console.WriteLine("Out of interval");
}