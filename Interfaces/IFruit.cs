using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // This is a contract.
    //Anything that implements IFruit must adhere to the contract-- it must do all of its methods and have all of its props
    //
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; set; }

        string Peel();
    }
}
