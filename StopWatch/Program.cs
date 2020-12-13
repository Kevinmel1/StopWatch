using System;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            bool isRunning = true;
            var stopWatch = new StopWatch();

            while (isRunning)
            {
                Console.WriteLine("Tap + Enter: 'y' to start, 'n' to stop, or 'q' to quit.");
                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "y":
                            stopWatch.Start();
                            Console.WriteLine($"Stopwatch started at: {DateTime.Now:H:mm:ss}");
                            break;

                        case "n":
                            stopWatch.Stop();
                            Console.WriteLine($"Stopwatch stopped at: {DateTime.Now:H:mm:ss} Run time: {stopWatch.Duration}");
                            break;

                        case "q":
                            return;
                    }
                } catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
