using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
    public class Kitchen : House
    {
        public Kitchen()
        {
            SquareFootage = 500;
            Flooring = FloorType.Wood;
        }
        public int NumberOfAppliances { get; set; }
        public bool HasIsland { get; set; }
        public string GoodPartySpace { get; set; }

    }
}
