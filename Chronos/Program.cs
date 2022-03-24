using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate 2 Stopwatch variables
            Stopwatch chron1 = new Stopwatch(), chron2 = new Stopwatch();

            // Start counting time in chron1
            chron1.Start();

            // Pause program for 1 second
            Thread.Sleep(1000);

            // Start counting time in chron2
            chron2.Start();

            // Pause program for 1 second
            Thread.Sleep(1000);

            // Stop counting time in both stopwatches
            chron1.Stop();
            chron2.Stop();

            // Print time counted in each stopwatch
            Console.WriteLine(
                $"Stopwatch 1 : {chron1.ElapsedMilliseconds} milliseconds");
            Console.WriteLine(
                $"Stopwatch 2 : {chron2.ElapsedMilliseconds} milliseconds");
        }
    }
}
