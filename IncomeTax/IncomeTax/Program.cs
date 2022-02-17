double salary;
double tax;
Console.WriteLine("Enter salary: ");
salary = Convert.ToDouble(Console.ReadLine());

if(salary <= 2000.00)
{
    Console.WriteLine("Isento");
}else if(salary <= 3000.00)
{
    tax = salary * 0.08;
    Console.WriteLine("R$: " + tax);
}
else if (salary <= 4500.00)
{
    tax = salary * 0.18;
    Console.WriteLine("R$: " + tax);
}
else if (salary > 4500.00)
{
    tax = salary * 0.28;
    Console.WriteLine("R$: " + tax);
}