using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // creating of counter for battles 
            int count = 5;
            Console.WriteLine("Welcome to BATTLETANK!\r\n\nWinners:");

            // loop with battles 
            for (int i = 0; i < count; i++)
            {
                // Using ABSTRACT FACTORY for creating 2 types of Tanks - inheritants of basic class Tank 
                FactoryTank[] arrTank = { new FactoryT34(), new FactoryPantera() };
                // Imitation of battle 
                Console.WriteLine(arrTank[0].Create() * arrTank[1].Create());
            }

            // Demonstration of method which returns ToString 
            Tank pan = new Pantera("Pantera");
            string st = pan.Ammo();
            Console.WriteLine(st);

        }
    }
}
