// See https://aka.ms/new-console-template for more information
using DuckRace;

Duck donald = new("Donald");
Duck scrooge = new("Scrooge");
Duck della = new("Della");
bool finished = false;
Race race = new();
List<Duck> ducks = new()
{
    donald,
    scrooge,
    della
};





Console.Clear();
System.Console.WriteLine(donald.DuckPic());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic2());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic3());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic4());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic5());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic6());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic7());
Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine(donald.DuckPic8());
Thread.Sleep(1000);
Console.Clear();

System.Console.WriteLine(donald.DuckBody);
while (!race.isFinish)
{
    race.Run(ducks);
    Thread.Sleep(4000);

    Console.Clear();


}

System.Console.WriteLine("Finished");
