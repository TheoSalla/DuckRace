using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckRace
{
    public class Race
    {
        public int Distance { get; set; } = 100;
        public bool isFinish { get; set; }

        private void Track(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Console.Write("-");
            }
            System.Console.WriteLine();
        }

        public void Run(IEnumerable<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Track(Distance);
                duck.Move();
                Console.WriteLine(duck.ToString());

                Distance -= duck.Speed;
                if (Distance <= 0)
                {
                    System.Console.WriteLine("Winner: " + duck.ToString());
                    isFinish = true;
          
                }
                isFinish = false;
            }
            /*  */
        }
    }
}