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

while (!race.isFinish)
{
    race.Run(ducks);
    Thread.Sleep(1000);
    System.Console.WriteLine("----------------------------------");

}

System.Console.WriteLine("Finished");
