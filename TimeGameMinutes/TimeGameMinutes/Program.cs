int init, finish, minIni, minFin;
int hours, minutes;
Console.WriteLine("Init game hours: ");
init = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Init game minutes: ");
minIni = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Finish game hours: ");
finish = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Finish game minutes: ");
minFin = Convert.ToInt32(Console.ReadLine());
if (minIni > minFin)
{
    minutes = 60 - (minIni - minFin);
}
else if (minFin > minIni)
{
    minutes = minFin - minIni;
}
else
{
    minutes = 0;
}

if (init > finish)
{
    hours = (24 - init) + finish;
    Console.WriteLine("The duration game: " + hours + " hours and " + minutes + " minutes.");
}

else if (finish > init && minIni > minFin)
{

    hours = (finish - init) - 1;
    Console.WriteLine("The duration game: " + hours + " hours and " + minutes + " minutes.");
}
else if (finish > init && minFin > minIni)
{

    hours = finish - init ;
    Console.WriteLine("The duration game: " + hours + " hours and " + minutes + " minutes.");
}

else
{
    hours = 24;
    Console.WriteLine("The duration game: " + hours + " hours and " + minutes + " minutes.");
}