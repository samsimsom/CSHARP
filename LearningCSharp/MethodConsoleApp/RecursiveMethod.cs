using System;

namespace MethodConsoleApp
{
    public class RecursiveMethod
    {
        private int _loopCount = 0;
        public int LoopCount { get; set; }
        
        public void MyMethod(string name)
        {

            Console.WriteLine($"Iam the best method in the world - {name}");

            LoopCount++;
            if (LoopCount <= 10)
            {
                MyMethod("Komancero");
            }
        }
    }
}