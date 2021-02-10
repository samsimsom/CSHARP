
using System;
using System.Collections;
using static System.Console;

namespace WhileStatements
{
    public class WhileStatementsClass
    {
        // ---------------------------------------------------------------------
        
        public void DropTeaTemperature()
        {
            var temperature = 100;
            var newList = new ArrayList();

            while (temperature > 90)
            {
                temperature--;
                newList.Add(temperature);
            }

            WriteLine(string.Join('>', newList.ToArray()));
            WriteLine("The tea is cool enough.");
        }

        // ---------------------------------------------------------------------

        public void ExplosiveTimer()
        {
            
        }
        
    }
}