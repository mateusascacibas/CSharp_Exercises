double salary, reaj;
int perc;

Console.WriteLine("Salary: ");
salary = Convert.ToDouble(Console.ReadLine());
if(salary <= 400.0)
{
    perc = 15;
    reaj = salary * 0.15;
    salary += reaj;
}else if(salary <= 800.0)
{
    perc = 12;
    reaj = salary * 0.12;
    salary += reaj;
}
else if (salary <= 1200.0)
{
    perc = 10;
    reaj = salary * 0.10;
    salary += reaj;
}
else if (salary <= 2000.0)
{
    perc = 7;
    reaj = salary * 0.07;
    salary += reaj;
}
else
{
    perc = 4;
    reaj = salary * 0.04;
    salary += reaj;
}

Console.WriteLine("New Salary: " + salary);
Console.WriteLine("Readjust: " + reaj);
Console.WriteLine("Percentage: " + perc);

