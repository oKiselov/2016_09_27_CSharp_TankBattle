using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    class T34:Tank
    {
        // Constructor with parameter - Name of Tank 
        public T34(string strName)
        {
            strTankName = strName;

            iAmmo = rand.Next(0, 101);
            iArmor = rand.Next(0, 101);
            iManeuver = rand.Next(0, 101);
        }
    }
}
