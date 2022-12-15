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
        public int Speed { get; set; } = 50;
        public int Distance { get; set; }

        public Duck(string name)
        {
            this.name = name;
        }
        public string Move()
        {
          
            return position;
        }
        public override string ToString()
        {  var p = Move();
            return name + "s current position is " + p;
        }
    }
}