using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    // Abstract factory 
    abstract class FactoryTank
    {
        public abstract Tank Create(); 
    }
}
