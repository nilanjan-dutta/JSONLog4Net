using System;

namespace JSONLOgging
{
    class Program
    {        
        static void Main(string[] args)
        {
            var loggerEx = new LoggingExample();
            loggerEx.LogError();

            //Console.ReadKey();
        }
    }
}
