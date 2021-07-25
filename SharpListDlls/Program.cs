using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SharpListDlls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting a current process object
            Process localProc = Process.GetCurrentProcess();

            // Process#Id returns the PID of the proc
            Console.WriteLine("Listing loaded modules inside process PID: {0}", localProc.Id);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

            // Looping and printing all loaded modules using Process#Modules
            foreach (ProcessModule module in localProc.Modules)
            {
                Console.WriteLine("{0} is loaded @ 0x{1}", module.ModuleName, module.BaseAddress.ToString("X4"));
            }
        }
    }
}
