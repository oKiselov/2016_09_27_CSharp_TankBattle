using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    // Inheritant of abstract factory which returns current object of class Tank 
    class FactoryPantera:FactoryTank
    {
        public override Tank Create()
        {
            return new Pantera("Pantera");
        }
    }
}
