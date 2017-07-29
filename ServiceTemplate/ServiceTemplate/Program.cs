using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace ServiceTemplate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (!Environment.UserInteractive)
            {
                Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] 
                { 
				    new Service() 
                };

                ServiceBase.Run(ServicesToRun);
            }
            else
            {
                var service = new Service();
                service.ToStart();

                WaitForExit();

                service.ToStop();
            }
        }

        static void WaitForExit()
        {
            while (true)
            {
                if (Console.ReadLine().ToUpper() == "QUIT")
                    break;
            }
        }
    }
}
