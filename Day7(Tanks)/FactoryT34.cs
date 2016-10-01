using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    // Inheritant of abstract factory which returns current object of class Tank 
    class FactoryT34:FactoryTank
    {
        public override Tank Create()
        {
            return new T34("T34");
        }
    }
}
