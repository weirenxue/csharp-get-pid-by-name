using System;
using System.Diagnostics;

namespace csharp_get_pid_by_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string processName = "notepad";
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes == null || processes.Length == 0)
            {
                Console.WriteLine("Process '" + processName + "' is not found.");
                Console.ReadKey();
                return;
            }
            for (var i = 0; i < processes.Length; i++)
            {
                Console.WriteLine("Process '" + processName + "' ID is " + processes[i].Id + ".");
            }
            Console.ReadKey();
        }
    }
}
