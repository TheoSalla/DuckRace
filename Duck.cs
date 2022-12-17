using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckRace
{
    public class Duck
    {
        private readonly string name;
        private readonly string position = "1";
        public int Speed { get; set; }
        public string Color { get; set; }
        private int xPos = 0;
        private int yPos = 0;
        public string DuckBody { get; set; } = @" 
     __
 ___( o)>
 \ <_. )
  `---'
";

        public Duck(string name)
        {
            this.name = name;
            var rand = new Random();
            Speed = rand.Next(5, 10);
        }
        public string Move()
        {
            return position;
        }
        public override string ToString()
        {
            var p = Move();
            return name + "s current position is " + p;
        }

        public void MovingDuck2()
        {
            while (true)
            {
                Console.WriteLine(DuckBody);
                DuckBody = DuckBody.Substring(1) + DuckBody[0];
                Thread.Sleep(100);
            }


        }

        public void MovingDuck()
        {
            // Define the initial position of the figure
            int xPos = 0;
            int yPos = 0;

            // Set the speed of the animation (in milliseconds)
            int speed = 1000;

            while (true)
            {
                // Clear the console before printing the figure
                Console.Clear();

                // Move the figure to its new position
                Console.SetCursorPosition(xPos, yPos);

                // Print the figure to the console
                Console.WriteLine(DuckBody);

                // Update the position of the figure for the next iteration of the loop
                xPos++;
                // yPos++;

                // Pause the execution of the program for the specified amount of time
                Thread.Sleep(speed);
            }
        }


        public string DuckPic()
        {
            return @"
    __
___( o)>
\ <_. )
 `---'
";



        }

        public string DuckPic2()
        {
            return @"
         __
     ___( o)>
     \ <_. )
      `---'
";
        }
        public string DuckPic3()
        {
            return @"
             __
          __( o)>
         \ <_. )
          `---'
";
        }
        public string DuckPic4()
        {
            return """
                    __
                 __( o)>
                \ <_. )
                 `---'
""";
        }
        public string DuckPic5()
        {
            return """
                            __
                         __( o)>
                        \ <_. )
                         `---'
""";
        }
        public string DuckPic6()
        {
            return """
                                    __
                                 __( o)>
                                \ <_. )
                                 `---'
""";
        }

        public string DuckPic7()
        {
            return """
                                                    __
                                                 __( o)>
                                                \ <_. )
                                                 `---'
""";
        }
        public string DuckPic8()
        {
            return @"
                                                                            __
                                                                         __( o)>
                                                                        \ <_. )
                                                                         `---'
""";
        }



    }
}
