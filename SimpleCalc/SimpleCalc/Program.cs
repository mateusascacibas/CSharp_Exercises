int p1, numP1, p2, numP2;
double valueP1, valueP2, finalValue;

Console.WriteLine("Enter the P1 code: ");
p1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the P1 number of pieces: ");
numP1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the P1 price of unit: ");
valueP1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the P2 code: ");
p2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the P2 number of pieces: ");
numP2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the P1 price of unit: ");
valueP2 = Convert.ToDouble(Console.ReadLine());

valueP1 = valueP1 * numP1;
valueP2 = valueP2 * numP2;
finalValue = valueP1 + valueP2;

Console.WriteLine("AMOUNT TO PAY: "  + finalValue);

