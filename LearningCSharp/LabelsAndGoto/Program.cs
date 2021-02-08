using System;
using System.Net;
using System.Threading;

namespace LabelsAndGoto
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}