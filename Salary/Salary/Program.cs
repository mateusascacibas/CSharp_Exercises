int num, hours;
double hoursValue, salary;

Console.WriteLine("Enter the employee number: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the employee hours working in month: ");
hours = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the value hours: ");
hoursValue = Convert.ToDouble(Console.ReadLine());

salary = hours * hoursValue;

Console.WriteLine("NUMBER = " + num);
Console.WriteLine("SALARY = R$ " + salary);

