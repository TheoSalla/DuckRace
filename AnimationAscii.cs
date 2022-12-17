using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckRace
{
    public class AnimationAscii
    {
        public AnimationAscii()
        {

            // Define the ASCII figure as a string
            string figure = @"
                   __
                  /  \
                 |    |
                 |    |
                  \__/
            ";

            // Define the initial position of the figure
            int xPos = 0;
            int yPos = 0;

            // Set the speed of the animation (in milliseconds)
            int speed = 100;

            while (true)
            {
                // Clear the console before printing the figure
                Console.Clear();

                // Move the figure to its new position
                Console.SetCursorPosition(xPos, yPos);

                // Print the figure to the console
                Console.WriteLine(figure);

                // Update the position of the figure for the next iteration of the loop
                xPos++;
                yPos++;

                // Pause the execution of the program for the specified amount of time
                Thread.Sleep(speed);
            }
        }
    }
}

