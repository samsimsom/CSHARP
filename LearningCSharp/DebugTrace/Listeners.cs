
using System.Diagnostics;
using System.IO;

namespace DebugTrace
{
    public class Listeners
    {
        //----------------------------------------------------------------------

        public void RunListeners()
        {
            // Write to text file in the project folder.
            Trace.Listeners.Add(new TextWriterTraceListener(
                File.CreateText("log.txt")));
            
            // text writter is buffered, so this options calls
            // Flush() on all listeners after writing.
            Trace.AutoFlush = true;
            
            // System.Diagnostics
            Debug.WriteLine("Debug Says: I am wathcing!");
            Trace.WriteLine("Trace Sayas: I am watching!");
        }
        
        //----------------------------------------------------------------------

    }
}