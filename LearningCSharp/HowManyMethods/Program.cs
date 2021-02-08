using System;
using HelpersLibrary;
using System.Linq;
using System.Reflection;

namespace HowManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // unused assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            
            var helpers = new Helpers();
            
            helpers.ConsoleCleaner();   
            helpers.Title("How Many Methods", 35);
            // -----------------------------------------------------------------

            foreach (var r in Assembly.GetEntryAssembly()
                .GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));

                int methodCount = 0;

                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }
                
                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name
                    );
            }
            
            // -----------------------------------------------------------------
            helpers.ConsoleStoper(count:35);
        }
    }
}