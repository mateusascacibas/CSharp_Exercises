int init, finish;
int hours;
Console.WriteLine("Init game hours: ");
init = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Finish game hours: ");
finish = Convert.ToInt32(Console.ReadLine());

if(init > finish)
{
    hours = (24 - init) + finish;
    Console.WriteLine("The duration game: " + hours + " hours.");
}else if(finish > init)
{

    hours = finish - init;
    Console.WriteLine("The duration game: " + hours + " hours.");
}
else
{
    hours = 24;
    Console.WriteLine("The duration game: " + hours + " hours.");
}