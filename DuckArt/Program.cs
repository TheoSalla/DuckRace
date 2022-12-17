using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

Console.Clear();


try
{
    // Create a Task for each thread
    Task duck1Task = Task.Factory.StartNew(() => MovingDuck2(0, 500));
    Task duck3Task = Task.Factory.StartNew(() => MovingDuck2(14, 500));



    // Wait for all tasks to complete
    Task.WaitAll(duck1Task, duck3Task);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}



// Thread duck1 = new Thread(() => MovingDuck(0));
// Thread duck2 = new Thread(() => MovingDuck(7));
// Thread duck3 = new Thread(() => MovingDuck(14));

Thread duck1 = new(() => MovingDuck2(0, 1000));
duck1.Name = "Duck1";
Thread duck2 = new(() => MovingDuck2(7, 5));
Thread duck3 = new(() => MovingDuck2(14, 200));
duck3.Name = "Duck3";
// Thread duck2 = new Thread(MovingDuck);
// Thread duck3 = new Thread(MovingDuck);
duck1.Start();
// duck2.Start();
duck3.Start();


void MovingDuck3(int y, int speed)
{
    string DuckBody = @$" Donald {Thread.CurrentThread.Name}
     __
 ___( o)>
 \ <_. )
  `---'
";
    List<string> s = DuckBody.Split('\n').ToList();
    int xPos = 0;

    // Create a Stopwatch to measure the time elapsed between iterations
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    while (true)
    {   
        // Use the console.Write() method to update the output
        Console.CursorTop = y;
        Console.CursorLeft = xPos;
        Console.Write(DuckBody);

        // Measure the time elapsed and use it to determine the delay for the next iteration
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        stopwatch.Restart();
        int delay = (int)Math.Max(0, speed - elapsedMilliseconds);
        Thread.Sleep(delay);

        xPos++;
    }

}




void MovingDuck2(int y, int speed)
{
    string DuckBody = @$"
     __
 ___( o)>
 \ <_. )
  `---'
";
    List<string> s = DuckBody.Split('\n').ToList();
    int xPos = 0;
    while (true)
    {   
        int counter = 0;
        for (int i = 0; i < 6; i++)
        {
            Console.SetCursorPosition(xPos, y + counter);
            Thread.Sleep(1);
            counter++;
            System.Console.WriteLine(s[i]);
            if (counter == 4)
            {
                counter = 0;
            }

        }
        Thread.Sleep(speed);

        xPos++;
    }

}

void MovingDuck(int y)
{
    string track = "_________________________________________________________________________________________________";
    var rand = new Random();
    int Speed = rand.Next(100, 1000);
    int x = 0;
    Console.Clear();
    Console.CursorVisible = false;
    while (true)
    {

        Console.SetCursorPosition(x, y);
        Console.WriteLine("     __");

        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine(" ___( o)>");

        Console.SetCursorPosition(x, y + 2);
        Console.WriteLine(" \\ <_. )");

        Console.SetCursorPosition(x, y + 3);
        Console.WriteLine("  `---'");

        x += 1;
        Thread.Sleep(Speed);
        Speed = rand.Next(10, 700);

    }
}