using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    // Base class 
    class Tank
    {
        // Fields with parameters 
        protected string strTankName;
        protected int iAmmo;
        protected int iArmor;
        protected int iManeuver;

        // static variable for generating different digits 
        protected static Random rand = new Random();

        public Tank(){}

        // operation of battle imitation 
        public static string operator *(Tank tOur, Tank tAlien)
        {
            // score counters for 2 Tanks 
            int rankOur = 0, rankAlien = 0;

            // arrays with parameters of 2 Tanks 
            int[] masRanksOur = {tOur.iAmmo, tOur.iArmor, tOur.iManeuver};
            int[] masRansAlien = {tAlien.iAmmo, tAlien.iArmor, tAlien.iManeuver};
            
            // loop for comparing parameters of Tank 
            for (int i = 0; i < masRanksOur.Length; i++)
            {
                if (masRanksOur[i] > masRansAlien[i])
                    rankOur++;
                if (masRanksOur[i] < masRansAlien[i])
                    rankAlien++;
            }
            // variable for returning from loop 
            string winner = "Draw";

            if (rankOur > rankAlien)
                winner = tOur.strTankName;
            if (rankOur < rankAlien)
                winner = tAlien.strTankName;
            return winner;
        }

        // Methods which return parameters of Tank using ToString
        public string Ammo()
        {
            return iAmmo.ToString(); 
        }

        public string Armor()
        {
            return iArmor.ToString(); 
        }

        public string Maneuver()
        {
            return iManeuver.ToString(); 
        }
    }


}