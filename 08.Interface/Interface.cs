using System;
using System.IO;

namespace _08.Interface
{
    class Interface
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
        }
    }

    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
            Console.WriteLine("git test");
        }


    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path){
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0}, {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;

        }

        public void start()
        {
            while(true)
            {
                Console.Write(" Type the Temperature : ");
                string temperature = Console.ReadLine();
                if(temperature == "")
                    break;
                
                logger.WriteLog("Current Temperature : " + temperature);

            }
        }
    }
}
