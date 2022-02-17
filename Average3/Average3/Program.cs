float n1, n2, n3, n4, average;

Console.WriteLine("Enter n1 value: ");
n1 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter n2 value: ");
n2 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter n3 value: ");
n3 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter n4 value: ");
n4 = (float)Convert.ToDouble(Console.ReadLine());

average = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
Console.WriteLine("Average: " + average);
if(average >= 7.0)
{
    Console.WriteLine("Approved student");
} else if (average < 5.0)
{
    Console.WriteLine("Failed student");
} else
{
    float exam;
    Console.WriteLine("Exam student");
    Console.WriteLine("Enter exame value: ");
    exam = (float)Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Exam grade: " + exam);
    average = (average + exam) / 2;
    if(average >= 5.0)
    {
        Console.WriteLine("Approved student");
    }
    else
    {
        Console.WriteLine("Approved student");
    }
    Console.WriteLine("Final average: " + average);

}