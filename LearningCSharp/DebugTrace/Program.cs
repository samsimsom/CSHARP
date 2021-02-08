
using System;
using Microsoft.Extensions.Configuration;

namespace DebugTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            var listeners = new Listeners();
            listeners.RunListeners();
        }
    }
}