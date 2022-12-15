using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckRace
{
    public class Race
    {
        public int Distance { get; set; } = 500;
        public bool isFinish { get; set; }


        public void Run(IEnumerable<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Distance -= duck.Speed;
                duck.Move();
                Console.WriteLine(duck.ToString());
                if (Distance <= 0)
                {
                    isFinish = true;
                    break;
                }
                isFinish = false;
            }
        }
    }
}